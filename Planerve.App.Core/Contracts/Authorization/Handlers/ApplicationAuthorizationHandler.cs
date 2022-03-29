using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading.Tasks;

namespace Planerve.App.Core.Contracts.Authorization.Handlers
{
    public class ApplicationAuthorizationHandler : AuthorizationHandler<ApplicationAuthorizationRequirement, Application>
    {
        private readonly ILoggedInUserService _loggedInUserService;

        public ApplicationAuthorizationHandler(ILoggedInUserService loggedInUserService)
        {
            _loggedInUserService = loggedInUserService;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                    ApplicationAuthorizationRequirement requirement,
                                                    Application resource)
        {
            var userId = _loggedInUserService.UserId;

            if (userId == resource.OwnerId)
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }

            bool isAuthorisedUser = resource.AuthorisedUsers.Any(x => x.UserId == userId && x.IsValid == true);

            if (isAuthorisedUser == false)  
                return Task.FromResult(false);

            if (requirement == ApplicationOperations.CreateApplicationRequirement)
            {
                if (userId != null)
                    context.Succeed(requirement);

                return Task.FromResult(false);

            }
            else if (requirement == ApplicationOperations.ReadApplicationRequirement)
            {
                if (isAuthorisedUser)
                    context.Succeed(requirement);
            }
            else if (requirement == ApplicationOperations.DeleteApplicationRequirement)
            {
                // can only be deleted by Owner, which is covered at the top of the method
                // noop
            }
            else if (requirement == ApplicationOperations.ShareApplicationRequirement)
            {
                // can only be shared by Owner, which is covered at the top of the method
                // noop
            }

            return Task.FromResult(false);
        }
    }
}
