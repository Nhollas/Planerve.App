using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Planerve.App.Core.Authorization.Requirements;

public class FormAuthorizationRequirement : OperationAuthorizationRequirement { }

static class FormOperations
{
    public static FormAuthorizationRequirement ReadFormRequirement = new() { Name = "ReadForm" };
    public static FormAuthorizationRequirement UpdateFormRequirement = new() { Name = "UpdateForm" };
    public static FormAuthorizationRequirement DownloadFormRequirement = new() { Name = "DownloadForm" };
}

public static class FormPolicies
{
    public static AuthorizationPolicy ReadForm = new AuthorizationPolicyBuilder()
        .AddRequirements(FormOperations.ReadFormRequirement)
        .Build();
    public static AuthorizationPolicy UpdateForm = new AuthorizationPolicyBuilder()
        .AddRequirements(FormOperations.UpdateFormRequirement)
        .Build();
    public static AuthorizationPolicy DownloadForm = new AuthorizationPolicyBuilder()
        .AddRequirements(FormOperations.DownloadFormRequirement)
        .Build();
}
