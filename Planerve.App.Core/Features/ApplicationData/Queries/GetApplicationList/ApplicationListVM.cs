using Planerve.App.Domain.Entities.ApplicationEntities;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationList;

public class ApplicationListVm
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string OwnerId { get; set; }
    public string VersionNumber { get; set; }
    public int ApplicationType { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public Address AddressData { get; set; }
    public Checklist ChecklistData { get; set; }
    public Form FormData { get; set; }
}