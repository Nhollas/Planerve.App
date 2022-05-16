using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Planerve.App.UI.Contracts;
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

        var removeDuplicateLocalAuthorities = applications.Select(x => x.AddressData.Admin_district).Distinct().ToList();

        var localAuthorities = removeDuplicateLocalAuthorities.Select(x => new SelectListItem { Text = x, Value = x }).ToList();

        var removeDuplicateApplicationTypes = applications.Select(x => x.ApplicationType).Distinct().ToList();

        var applicationTypes = removeDuplicateApplicationTypes.Select(x => new SelectListItem { Text = x.ToString(), Value = x.ToString() }).ToList();

        var viewModel = new ApplicationDashboardViewModel()
        {
            ApplicationList = applications,
            LocalAuthorities = localAuthorities,
            ApplicationTypes = applicationTypes
        };

        return View(viewModel);
    }


    [HttpPost]
    public PartialViewResult DashboardFilter(ApplicationFilterModel model)
    {
        var filter = new ApplicationFilter(_applicationService);

        var viewModel = filter.FilterApplication(model).ToList();

        if (!viewModel.Any())
        {
            ViewBag.Resource = "applications";

            return PartialView("_EmptyResourcePartial");
        }

        return PartialView("_DashboardFilterPartial", viewModel);
    }


    public async Task<IActionResult> AuthPage()
    {
        var response = await HttpContext.AuthenticateAsync();

        var items = response.Properties.Items;

        ViewBag.AuthProps = items;

        return View();
    }
}