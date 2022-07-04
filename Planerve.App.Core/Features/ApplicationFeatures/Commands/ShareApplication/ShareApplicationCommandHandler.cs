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

            var applicationToShare = _unitOfWork.ApplicationRepository.FindWithSpecificationPattern(specification).FirstOrDefault();


            var authorisedResult = await _authorizationService.AuthorizeAsync(user, applicationToShare.Users, ApplicationPolicies.ShareApplication);

            // If check fails this user doesn't have permissions to share this application, throw NotAuthorisedException.
            if (!authorisedResult.Succeeded)
            {
                throw new NotAuthorisedException(nameof(Application), _userId);
            }

            var matchedUser = _userDataRepository.QueriedUser(request.UsernameOrEmail);

            // If no user can be found with that email or username then throw NotFoundException.
            if (matchedUser == null)
            {
                throw new NotFoundException(nameof(request.UsernameOrEmail), _userId);
            }

            AuthorisedUser mockUser = _mapper.Map<AuthorisedUser>(request);
            mockUser.IsValid = true;
            mockUser.UserId = matchedUser.Id;

            applicationToShare.Users.AuthorisedUsers.Add(mockUser);

            await _unitOfWork.ApplicationRepository.UpdateAsync(applicationToShare);

            return Unit.Value;
        }
    }
}
