using Planerve.App.Domain.Entities.ApplicationEntities;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationById;

public class ApplicationDetailVm
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string OwnerId { get; set; }
    public string VersionNumber { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public ApplicationType ApplicationType { get; set; }
    public Address Address { get; set; }
    public Checklist Checklist { get; set; }
    public Form Form { get; set; }
}