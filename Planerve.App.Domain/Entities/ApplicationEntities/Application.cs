using Planerve.App.Domain.Common;
using System;
using System.Collections.Generic;
using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Domain.Entities.ApplicationEntities;

public class Application : AuditableEntity
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string OwnerId { get; set; }
    public string VersionNumber { get; set; }
    public int ApplicationType { get; set; }
    public ICollection<AuthorisedUser> AuthorisedUsers { get; set; }
    public Address AddressData { get; set; }
    public Checklist ChecklistData { get; set; }
    public Form FormData { get; set; }
}