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

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateAccessToken;

public class CreateAccessTokenCommandHandler : IRequestHandler<CreateAccessTokenCommand, string>
{
    private readonly ILoggedInUserService _loggedInUserService;
    private readonly IApplicationDataRepository _applicationRepository;
    private readonly IAsyncRepository<AccessToken> _tokenRepository;
    private readonly IMapper _mapper;

    public CreateAccessTokenCommandHandler(IMapper mapper, ILoggedInUserService loggedInUserService, IApplicationDataRepository applicationRepository, IAsyncRepository<AccessToken> tokenRepository)
    {
        _mapper = mapper;
        _loggedInUserService = loggedInUserService;
        _applicationRepository = applicationRepository;
        _tokenRepository = tokenRepository;
    }

    public async Task<string> Handle(CreateAccessTokenCommand request, CancellationToken cancellationToken)
    {
        var userId = _loggedInUserService.UserId;

        var validator = new CreateAccessTokenCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
            throw new ValidationException(validationResult);

        var specification = new GetApplicationByIdSpecification(request.ApplicationId, userId);

        var applicationEntity = _applicationRepository.FindWithSpecificationPattern(specification);

        if (!applicationEntity.Any())
        {
            throw new NotFoundException(nameof(Application), request.ApplicationId);
        }

        var selectedApplication = applicationEntity.First();

        if (selectedApplication.OwnerId != userId)
        {
            throw new NotAuthorisedException(nameof(Application), userId);
        }

        // If no exisitng accessTokens are present create a mockToken to stop null reference exception.
        if (selectedApplication.AccessTokens is null)
        {
            List<AccessToken> mockTokenData = new();
            selectedApplication.AccessTokens = mockTokenData;
        }

        var accessToken = ValidateToken().Result;

        var accessTokenData = new AccessToken()
        {
            Id = new Guid(),
            Token = accessToken,
            OwnerId = userId,
            ApplicationId = request.ApplicationId,
            TokenAccessLevel = request.TokenAccessLevel,
            ExpiryDate = request.TokenLifetime,
            CreationDate = DateTime.UtcNow,
            IsExpired = false
        };

        selectedApplication.AccessTokens.Add(accessTokenData);

        await _applicationRepository.UpdateAsync(selectedApplication);

        return accessToken;
    }

    private async Task<string> ValidateToken()
    {
        var accessToken = GenerateAccessToken().Result;

        bool unique = await IsAccessTokenUnique(accessToken);

        while (unique is false)
        {
            var unluckyToken = await GenerateAccessToken();

            unique = await IsAccessTokenUnique(unluckyToken);

            accessToken = unluckyToken;
        }

        return accessToken;
    }


    private static Task<string> GenerateAccessToken()
    {
        Random random = new();
        const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
        var Charsarr = new char[25];

        for (int i = 0; i < Charsarr.Length; i++)
        {
            Charsarr[i] = chars[random.Next(chars.Length)];
        }

        string accessToken = new(Charsarr);

        return Task.FromResult(accessToken);
    }

    private Task<bool> IsAccessTokenUnique(string accessToken)
    {
        var specification = new IsAccessTokenUniqueSpecification(accessToken);

        var result = _tokenRepository.FindWithSpecificationPattern(specification);

        if (!result.Any())
        {
            return Task.FromResult(true);
        }
        return Task.FromResult(false);


    }
}