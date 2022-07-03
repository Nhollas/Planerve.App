using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Contracts.Persistence.Generic;
using Planerve.App.Core.Contracts.Specification.ApplicationSpecifications;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.DeleteApplication
{
    public class DeleteApplicationCommandHandler : IRequestHandler<DeleteApplicationCommand>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly IUserService _userService;
        private readonly IAuthorizationService _authorizationService;
        private readonly string _userId;

        public DeleteApplicationCommandHandler(IAsyncRepository<Application> repository, IUserService userService, IAuthorizationService authorizationService)
        {
            _repository = repository;
            _userService = userService;
            _authorizationService = authorizationService;
            _userId = _userService.UserId();
        }

        public async Task<Unit> Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUser();

            var specification = new GetApplicationByIdSpecification(request.Id, _userId);

            var applicationToDelete = _repository.FindWithSpecificationPattern(specification);

            var selectedApplication = applicationToDelete.First();

            var authorisedResult = await _authorizationService.AuthorizeAsync(user, selectedApplication.Users, ApplicationPolicies.DeleteApplication);

            if (!authorisedResult.Succeeded)
            {
                throw new NotAuthorisedException(nameof(Application), _userId);
            }
            await _repository.DeleteAsync(selectedApplication);
            
            return Unit.Value;
        }
    }
}
