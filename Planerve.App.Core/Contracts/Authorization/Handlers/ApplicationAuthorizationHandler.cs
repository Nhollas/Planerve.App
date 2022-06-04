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

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            ApplicationAuthorizationRequirement requirement,
            Application resource)
        {
            var userId = await _loggedInUserService.UserId();
            var isAuthorisedUser = resource.Data.Users.Where(x => x.UserId == userId && x.IsValid == true).FirstOrDefault();

            // Everything that is not on the 
            if (userId == resource.OwnerId)
            {
                context.Succeed(requirement);
                return;
            }

            if (isAuthorisedUser is null)
            {
                context.Fail();
                return;
            }

            if (requirement == ApplicationOperations.CreateApplicationRequirement)
            {
                if (userId != null)
                    context.Succeed(requirement);
                    return;
            }
            else if (requirement == ApplicationOperations.ReadApplicationRequirement)
            {
                if (isAuthorisedUser.ReadApplication)
                    context.Succeed(requirement);
                    return;
            }
            else if (requirement == ApplicationOperations.CopyApplicationRequirement)
            {
                if (isAuthorisedUser.CopyApplication)
                    context.Succeed(requirement);
                    return;
            }
            context.Fail();
            return;
        }
    }
}