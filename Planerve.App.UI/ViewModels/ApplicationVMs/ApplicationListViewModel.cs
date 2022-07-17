using Planerve.App.UI.Services.Base;

namespace Planerve.App.UI.ViewModels.ApplicationVMs;

public class ApplicationListViewModel : AuditableEntity
{
    public Guid AppId { get; set; }
    public string AppReference { get; set; }
    public string AppName { get; set; }
    public string AppVersion { get; set; }
    public string AppStatus { get; set; }
    public int AppType { get; set; }
    public int AppCategory { get; set; }
    public int PercentageComplete { get; set; }
    public Submission Submission { get; set; }
}
