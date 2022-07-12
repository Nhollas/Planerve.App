using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.Specification.ApplicationQueries;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Delete
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

            var applicationToDelete = _repository.FindWithSpecificationPattern(specification).FirstOrDefault();

            if (applicationToDelete == null)
            {
                throw new NotFoundException(nameof(Application), _userId);
            }

            var authorisedResult = await _authorizationService.AuthorizeAsync(user, applicationToDelete.Users, ApplicationPolicies.DeleteApplication);

            // If check fails this user doesn't have permissions to delete this application, throw NotAuthorisedException.
            if (!authorisedResult.Succeeded)
            {
                throw new NotAuthorisedException(nameof(Application), _userId);
            }
            await _repository.DeleteAsync(applicationToDelete);

            return Unit.Value;
        }
    }
}
