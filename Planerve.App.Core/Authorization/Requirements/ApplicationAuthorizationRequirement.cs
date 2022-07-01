using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Planerve.App.Core.Authorization.Requirements;

public class ApplicationAuthorizationRequirement : OperationAuthorizationRequirement { }

static class ApplicationOperations
{
    public static ApplicationAuthorizationRequirement CreateApplicationRequirement = new() { Name = "CreateApplication" };
    public static ApplicationAuthorizationRequirement ReadApplicationRequirement = new() { Name = "ReadApplication" };
    public static ApplicationAuthorizationRequirement DeleteApplicationRequirement = new() { Name = "DeleteApplication" };
    public static ApplicationAuthorizationRequirement ShareApplicationRequirement = new() { Name = "ShareApplication" };
    public static ApplicationAuthorizationRequirement CopyApplicationRequirement = new() { Name = "CopyApplication" };
    public static ApplicationAuthorizationRequirement EditPermissionRequirement = new() { Name = "EditPermission" };
}

public static class ApplicationPolicies
{
    public static AuthorizationPolicy CreateApplication = new AuthorizationPolicyBuilder()
            .AddRequirements(ApplicationOperations.CreateApplicationRequirement)
            .Build();
    public static AuthorizationPolicy ReadApplication = new AuthorizationPolicyBuilder()
            .AddRequirements(ApplicationOperations.ReadApplicationRequirement)
            .Build();
    public static AuthorizationPolicy DeleteApplication = new AuthorizationPolicyBuilder()
            .AddRequirements(ApplicationOperations.DeleteApplicationRequirement)
            .Build();
    public static AuthorizationPolicy ShareApplication = new AuthorizationPolicyBuilder()
            .AddRequirements(ApplicationOperations.ShareApplicationRequirement)
            .Build();
    public static AuthorizationPolicy CopyApplication = new AuthorizationPolicyBuilder()
            .AddRequirements(ApplicationOperations.CopyApplicationRequirement)
            .Build();
    public static AuthorizationPolicy EditPermission = new AuthorizationPolicyBuilder()
            .AddRequirements(ApplicationOperations.EditPermissionRequirement)
            .Build();
}
