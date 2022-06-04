using Planerve.App.UI.Services.Base;

namespace Planerve.App.UI.ViewModels.ApplicationVMs;

public class ApplicationDetailViewModel
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