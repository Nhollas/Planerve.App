using Microsoft.AspNetCore.Mvc.Rendering;

namespace Planerve.App.UI.ViewModels.ApplicationVMs
{
    public class ApplicationDashboardViewModel
    {
        public List<ApplicationListViewModel> ApplicationList { get; set; }
        public List<SelectListItem> LocalAuthorities { get; set; }
        public List<SelectListItem> ApplicationTypes { get; set; }
        public List<SelectListItem> ApplicationStatus { get; set; }

        public void OnGet()
        {
            ApplicationStatus = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "All" },
                new SelectListItem{ Value = "2", Text = "Draft" },
                new SelectListItem{ Value = "3", Text = "Payment Pending" },
                new SelectListItem{ Value = "4", Text = "Submitted to LPA" },
                new SelectListItem{ Value = "5", Text = "Received by LPA" },
                new SelectListItem{ Value = "6", Text = "Deleted" },
                new SelectListItem{ Value = "7", Text = "Archived" }
            };
        }
    }
}
