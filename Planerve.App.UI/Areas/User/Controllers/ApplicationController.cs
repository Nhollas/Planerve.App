using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Planerve.App.UI.Interfaces;
using Planerve.App.UI.Models;
using Planerve.App.UI.ViewHelpers;
using Planerve.App.UI.ViewModels.ApplicationVMs;

namespace Planerve.App.UI.Areas.User.Controllers;

[Area("User")]
[Authorize]
public class ApplicationController : Controller
{
    private readonly IApplicationDataService _applicationService;
    public ApplicationController(IApplicationDataService applicationService)
    {
        _applicationService = applicationService;
    }

    [HttpGet]
    public IActionResult Dashboard()
    {
        var applications = _applicationService.GetApplicationList().Result;

        var removeDuplicateApplicationTypes = applications.Select(x => x.Submission).DistinctBy(x => x.FormType).ToList();
        var removeDuplicateStatus = applications.DistinctBy(x => x.AppStatus).ToList();

        var applicationTypes = removeDuplicateApplicationTypes
            .Select(x => new SelectListItem { Text = x.TypeName, Value = x.FormType.ToString() })
            .ToList();

        var applicationStatuses = removeDuplicateStatus
            .Select(x => new SelectListItem { Text = x.AppStatus, Value = x.AppStatus })
            .ToList();

        var viewModel = new ApplicationDashboardViewModel()
        {
            ApplicationList = applications,
            ApplicationTypes = applicationTypes,
            ApplicationStatus = applicationStatuses
        };

        return View(viewModel);
    }

    [HttpPost]
    public PartialViewResult DashboardFilter(ApplicationFilterModel model)
    {
        var filter = new ApplicationFilter(_applicationService);

        model.ToDate?.AddDays(1);
        model.FromDate?.AddDays(-1);

        var viewModel = filter.FilterApplication(model).ToList();

        // If no applications are present, return the Empty partial result.
        if (viewModel.Count == 0)
        {
            ViewBag.Resource = "applications";

            return PartialView("_EmptyResourcePartial");
        }

        return PartialView("_DashboardFilterPartial", viewModel);
    }

    [HttpGet]
    public async Task<IActionResult> View(Guid Id)
    {
        var application = await _applicationService.GetApplicationById(Id);

        if (application == null)
        {
            return NotFound();
        }

        return View(application);
    }

    public IActionResult Create()
    {
        var viewModel = new ApplicationCreateViewModel();

        viewModel.OnGet();

        return View(viewModel);
    }
}