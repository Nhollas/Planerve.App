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
    public async Task<IActionResult> Dashboard()
    {
        var applications = await _applicationService.GetApplicationList();

        // Select List Data

        var removeDuplicateLocalAuthorities = applications.Select(x => x.Data.Address.Admin_district).Distinct().ToList();
        var removeDuplicateApplicationTypes = applications.Select(x => x.Data.Type).DistinctBy(x => x.Value).ToList();

        // Select Lists..

        var localAuthorities = removeDuplicateLocalAuthorities.Select(x => new SelectListItem { Text = x, Value = x }).ToList();
        var applicationTypes = removeDuplicateApplicationTypes.Select(x => new SelectListItem { Text = x.Name, Value = x.Value.ToString() }).ToList();

        var viewModel = new ApplicationDashboardViewModel()
        {
            ApplicationList = applications,
            LocalAuthorities = localAuthorities,
            ApplicationTypes = applicationTypes
        };
        viewModel.OnGet();

        return View(viewModel);
    }

    [HttpPost]
    public PartialViewResult DashboardFilter(ApplicationFilterModel model)
    {
        var filter = new ApplicationFilter(_applicationService);

        model.ToDate?.AddDays(1);
        model.FromDate?.AddDays(-1);

        var viewModel = filter.FilterApplication(model).ToList();

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

    public async Task<IActionResult> AuthPage()
    {
        var response = await HttpContext.AuthenticateAsync();

        var items = response.Properties.Items;

        ViewBag.AuthProps = items;

        return View();
    }
}