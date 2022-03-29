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
    public int ApplicationType { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastUpdated { get; set; }
    public ICollection<AuthorisedUser> AuthorisedUsers { get; set; }
    public ICollection<AccessToken> AccessTokens { get; set; }
    public Address Address { get; set; }
    public Checklist ChecklistData { get; set; }
    public Form FormData { get; set; }
}