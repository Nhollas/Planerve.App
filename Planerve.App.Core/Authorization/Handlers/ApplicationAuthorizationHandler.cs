using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading.Tasks;

namespace Planerve.App.Core.Authorization.Handlers;

public class ApplicationAuthorizationHandler : AuthorizationHandler<ApplicationAuthorizationRequirement, ApplicationPermission>
{
    private readonly IUserService _userService;
    private readonly string _userId;

    public ApplicationAuthorizationHandler(IUserService userService)
    {
        _userService = userService;
        _userId = _userService.UserId();
    }

    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        ApplicationAuthorizationRequirement requirement,
        ApplicationPermission resource)
    {
        if (_userId == resource.OwnerId)
        {
            context.Succeed(requirement);
            return Task.CompletedTask;
        }

        // If no exisitng AuthorisedUsers exist, fail authorisation.
        if (resource.AuthorisedUsers == null)
        {
            context.Fail();
            return Task.CompletedTask;
        }

        var userPermissions = resource.AuthorisedUsers.Where(x => x.UserId == _userId && x.IsValid).FirstOrDefault();


        // If no exisitng userPermissions exist, fail authorisation.
        if (userPermissions == null)
        {
            context.Fail();
            return Task.CompletedTask;
        }

        if (requirement == ApplicationOperations.CreateApplicationRequirement)
        {
            context.Succeed(requirement);
        }
        else if (requirement == ApplicationOperations.ReadApplicationRequirement)
        {
            if (userPermissions.ReadApplication)
                context.Succeed(requirement);
            else
                context.Fail();
        }
        else if (requirement == ApplicationOperations.EditPermissionRequirement)
        {
            if (userPermissions.EditPermission)
                context.Succeed(requirement);
            else
                context.Fail();
        }
        else if (requirement == ApplicationOperations.DeleteApplicationRequirement)
        {
            if (userPermissions.DeleteApplication)
                context.Succeed(requirement);
            else
                context.Fail();
        }
        else if (requirement == ApplicationOperations.CopyApplicationRequirement)
        {
            if (userPermissions.CopyApplication)
                context.Succeed(requirement);
            else
                context.Fail();
        }
        else if (requirement == ApplicationOperations.ShareApplicationRequirement)
        {
            if (userPermissions.ShareApplication)
                context.Succeed(requirement);
            else
                context.Fail();
        }

        return Task.CompletedTask;
    }
}
