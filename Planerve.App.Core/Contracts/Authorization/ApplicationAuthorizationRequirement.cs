using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Planerve.App.Core.Contracts.Authorization
{
    public class ApplicationAuthorizationRequirement : OperationAuthorizationRequirement { }

    static class ApplicationOperations
    {
        public static ApplicationAuthorizationRequirement CreateApplicationRequirement = new() { Name = "CreateApplication" };
        public static ApplicationAuthorizationRequirement ReadApplicationRequirement = new() { Name = "ReadApplication" };
        public static ApplicationAuthorizationRequirement UpdateApplicationRequirement = new() { Name = "UpdateApplication" };
        public static ApplicationAuthorizationRequirement DeleteApplicationRequirement = new() { Name = "DeleteApplication" };
        public static ApplicationAuthorizationRequirement ShareApplicationRequirement = new() { Name = "ShareApplication" };
        public static ApplicationAuthorizationRequirement CopyApplicationRequirement = new() { Name = "CopyApplication" };
        public static ApplicationAuthorizationRequirement ArchiveApplicationRequirement = new() { Name = "ArchiveApplication" };
        public static ApplicationAuthorizationRequirement ImportApplicationRequirement = new() { Name = "ImportApplication" };
        public static ApplicationAuthorizationRequirement RemoveAccessRequirement = new() { Name = "RemoveAccess" };
        public static ApplicationAuthorizationRequirement RemoveApplicationRequirement = new() { Name = "RemoveApplication" };

    }

    static class ApplicationPolicies
    {
        public static AuthorizationPolicy CreateApplication = new AuthorizationPolicyBuilder()
               .AddRequirements(ApplicationOperations.CreateApplicationRequirement)
               .Build();
        public static AuthorizationPolicy ReadApplication = new AuthorizationPolicyBuilder()
                .AddRequirements(ApplicationOperations.ReadApplicationRequirement)
                .Build();
        public static AuthorizationPolicy UpdateApplication = new AuthorizationPolicyBuilder()
                .AddRequirements(ApplicationOperations.UpdateApplicationRequirement)
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
        public static AuthorizationPolicy ArchiveApplication = new AuthorizationPolicyBuilder()
                .AddRequirements(ApplicationOperations.ArchiveApplicationRequirement)
                .Build();
        public static AuthorizationPolicy ImportApplication = new AuthorizationPolicyBuilder()
                .AddRequirements(ApplicationOperations.ImportApplicationRequirement)
                .Build();
        public static AuthorizationPolicy RemoveAccess = new AuthorizationPolicyBuilder()
                .AddRequirements(ApplicationOperations.RemoveAccessRequirement)
                .Build();
        public static AuthorizationPolicy RemoveApplication = new AuthorizationPolicyBuilder()
                .AddRequirements(ApplicationOperations.RemoveApplicationRequirement)
                .Build();
    }
}
