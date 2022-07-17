using Planerve.App.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.ApplicationEntities;

public class Application : AuditableEntity
{
    [Key]
    public Guid AppId { get; set; } = Guid.NewGuid();
    public string AppReference { get; set; }
    public string AppName { get; set; }
    public string AppVersion { get; set; }
    public string AppStatus { get; set; }
    public int AppType { get; set; }
    public int AppCategory { get; set; }
    public int PercentageComplete { get; set; }
    public Submission Submission { get; set; }
}