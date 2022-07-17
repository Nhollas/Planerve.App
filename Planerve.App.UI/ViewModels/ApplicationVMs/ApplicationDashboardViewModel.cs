using Microsoft.AspNetCore.Mvc.Rendering;

namespace Planerve.App.UI.ViewModels.ApplicationVMs
{
    public class ApplicationDashboardViewModel
    {
        public List<ApplicationListViewModel> ApplicationList { get; set; }
        public List<SelectListItem> ApplicationTypes { get; set; }
        public List<SelectListItem> ApplicationStatus { get; set; }
    }
}
