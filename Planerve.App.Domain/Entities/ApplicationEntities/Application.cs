using Planerve.App.Domain.Common;
using System;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.ApplicationEntities;

public class Application : AuditableEntity
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string OwnerId { get; set; }
    public string VersionNumber { get; set; }
    public ICollection<AuthorisedUser> AuthorisedUsers { get; set; }
    public ApplicationType ApplicationType { get; set; }
    public Address Address { get; set; }
    public Checklist Checklist { get; set; }
    public Form Form { get; set; }
}