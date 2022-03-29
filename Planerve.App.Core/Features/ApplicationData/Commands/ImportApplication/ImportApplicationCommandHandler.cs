using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Commands.ImportApplication
{
    public class ImportApplicationCommandHandler : IRequestHandler<ImportApplicationCommand, Guid>
    {
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IAccessTokenRepository _accessTokenRepository;
        private readonly IMapper _mapper;
        private readonly IApplicationDataRepository _applicationDataRepository;

        public ImportApplicationCommandHandler(IMapper mapper, ILoggedInUserService loggedInUserService, IApplicationDataRepository applicationDataRepository, IAccessTokenRepository accessTokenRepository)
        {
            _mapper = mapper;
            _loggedInUserService = loggedInUserService;
            _accessTokenRepository = accessTokenRepository;
            _applicationDataRepository = applicationDataRepository;
        }

        public async Task<Guid> Handle(ImportApplicationCommand request, CancellationToken cancellationToken)
        {
            var accessTokenData = await HandleValidToken(request);

            var importedResult = await HandleApplicationImport(accessTokenData);

            return importedResult;
        }


        public async Task<AccessToken> HandleValidToken (ImportApplicationCommand request)
        {
            var validator = new ImportApplicationCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            var specification = new GetApplicationAccessTokenSpecification(request.AccessToken);

            var token = _accessTokenRepository.FindWithSpecificationPattern(specification);

            if (!token.Any())
            {
                throw new NotFoundException(nameof(AccessToken), request.AccessToken);
            }

            var selectedToken = token.First();

            if (selectedToken.IsExpired == true || !selectedToken.IsValid)
            {
                throw new NotFoundException(nameof(AccessToken), request.AccessToken);
            }

            if (selectedToken.ExpiryDate < DateTime.UtcNow)
            {
                selectedToken.IsValid = false;
                selectedToken.IsExpired = true;

                await _accessTokenRepository.UpdateAsync(selectedToken);

                throw new NotFoundException(nameof(AccessToken), request.AccessToken);
            }

            if (selectedToken.TokenUses == 0)
            {
                selectedToken.IsValid = false;

                await _accessTokenRepository.UpdateAsync(selectedToken);

                throw new NotFoundException(nameof(AccessToken), request.AccessToken);
            }

            selectedToken.TokenUses--;

            await _accessTokenRepository.UpdateAsync(selectedToken);

            return selectedToken;
        }

        public async Task<Guid> HandleApplicationImport(AccessToken accessToken)
        {
            var specification = new GetApplicationUnauthorisedSpecification(accessToken.ApplicationId);

            var application = _applicationDataRepository.FindWithSpecificationPattern(specification);

            if (!application.Any())
            {
                throw new NotFoundException(nameof(Application), accessToken.ApplicationId);
            }

            var selectedApplication = application.First();

            var userId = _loggedInUserService.UserId;

            if (selectedApplication.AuthorisedUsers.Any(x => x.UserId == userId))
            {
                return selectedApplication.Id;

                // TODO: How should we properly handle a user who is already on the list?
            }

            // Avoid null reference exception.
            if (selectedApplication.AuthorisedUsers is null)
            {
                List<AuthorisedUser> authorisedUser = new();
                selectedApplication.AuthorisedUsers = authorisedUser;
            }

            // TODO: Map this instead.
            var authorisedUserData = new AuthorisedUser()
            {
                Id = new Guid(),
                ApplicationId = selectedApplication.Id,
                UserId = userId,
                TokenUsed = accessToken.Token,
                ImportedDate = DateTime.UtcNow,
                ExpiryDate = accessToken.ExpiryDate,
                IsValid = accessToken.IsValid,
            };

            selectedApplication.AuthorisedUsers.Add(authorisedUserData);

            await _applicationDataRepository.UpdateAsync(selectedApplication);

            return selectedApplication.Id;
        }
    }
}
