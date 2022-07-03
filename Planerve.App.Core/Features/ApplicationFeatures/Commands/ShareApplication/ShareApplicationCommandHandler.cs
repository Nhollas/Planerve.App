using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationSpecifications;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.ShareApplication
{
    public class ShareApplicationCommandHandler : IRequestHandler<ShareApplicationCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;
        private readonly IUserRepository _userDataRepository;
        private readonly IAuthorizationService _authorizationService;
        private readonly IMapper _mapper;
        private readonly string _userId;

        public ShareApplicationCommandHandler(
            IUnitOfWork unitOfWork,
            IUserService userService,
            IUserRepository userDataRepository,
            IMapper mapper,
            IAuthorizationService authorizationService)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
            _userDataRepository = userDataRepository;
            _userId = _userService.UserId();
            _mapper = mapper;
            _authorizationService = authorizationService;
        }

        public async Task<Unit> Handle(ShareApplicationCommand request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUser();

            var specification = new GetApplicationByIdSpecification(request.ApplicationId, _userId);

            var application = _unitOfWork.ApplicationRepository.FindWithSpecificationPattern(specification);

            var selectedApplication = application.First();

            var authorisedResult = await _authorizationService.AuthorizeAsync(user, selectedApplication.Users, ApplicationPolicies.ShareApplication);

            if (!authorisedResult.Succeeded)
            {
                throw new NotAuthorisedException(nameof(Application), _userId);
            }

            // var matches = await _userDataRepository.GetUserByEmailOrName(request.UsernameOrEmail);

            // var queriedUser = matches.First();

            AuthorisedUser mockUser = _mapper.Map<AuthorisedUser>(request);

            mockUser.IsValid = true;
            // mockUser.UserId = queriedUser.Id;

            selectedApplication.Users.AuthorisedUsers.Add(mockUser);

            await _unitOfWork.ApplicationRepository.UpdateAsync(selectedApplication);

            return Unit.Value;
        }
    }
}
