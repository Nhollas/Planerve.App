using Planerve.App.UI.Services.Base;

namespace Planerve.App.UI.ViewModels.ApplicationVMs;

public class ApplicationDetailViewModel : AuditableEntity
{
    public Guid Id { get; set; }
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string OwnerId { get; set; }
    public string VersionNumber { get; set; }
    public ApplicationDataDto Data { get; set; }
}