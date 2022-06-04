using Planerve.App.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planerve.App.Domain.Entities.ApplicationEntities;

public class Application : AuditableEntity
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string OwnerId { get; set; }
    public string VersionNumber { get; set; }
    [ForeignKey("Id")]
    public ApplicationData Data { get; set; }
}