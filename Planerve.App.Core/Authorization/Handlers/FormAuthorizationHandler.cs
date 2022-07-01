using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading.Tasks;

namespace Planerve.App.Core.Authorization.Handlers;

public class FormAuthorizationHandler : AuthorizationHandler<FormAuthorizationRequirement, ApplicationUser>
{
    private readonly IUserService _userService;
    private readonly string _userId;

    public FormAuthorizationHandler(IUserService userService)
    {
        _userService = userService;
        _userId = _userService.UserId();
    }

    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        FormAuthorizationRequirement requirement,
        ApplicationUser resource)
    {
        if (_userId == resource.OwnerId)
        {
            context.Succeed(requirement);
            return Task.CompletedTask;
        }

        if (resource.AuthorisedUsers == null)
        {
            context.Fail();
            return Task.CompletedTask;
        }

        var userPermissions = resource.AuthorisedUsers.Where(x => x.UserId == _userId && x.IsValid).FirstOrDefault();

        if (userPermissions == null)
        {
            context.Fail();
            return Task.CompletedTask;
        }


        if (requirement == FormOperations.UpdateFormRequirement)
        {
            if (userPermissions.UpdateForm)
                context.Succeed(requirement);
            else
                context.Fail();
        }
        else if (requirement == FormOperations.DownloadFormRequirement)
        {
            if (userPermissions.DownloadForm)
                context.Succeed(requirement);
            else
                context.Fail();
        }
        else if (requirement == FormOperations.ReadFormRequirement)
        {
            if (userPermissions.ReadForm)
                context.Succeed(requirement);
            else
                context.Fail();
        }

        return Task.CompletedTask;
    }
}
