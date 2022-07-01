using Planerve.App.Domain.Common;
using System;

namespace Planerve.App.Domain.Entities.ApplicationEntities;

public class Application : AuditableEntity
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string VersionNumber { get; set; }
    public ApplicationUser Users { get; set; }
    public ApplicationType Type { get; set; }
    public ApplicationDocument Document { get; set; }
    public ApplicationProgress Progress { get; set; }
}