using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.UI.Contracts;

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
        var ApplicationList = await _applicationService.GetApplicationList();

        return View(ApplicationList);
    }

    public async Task<IActionResult> AuthPage()
    {
        var response = await HttpContext.AuthenticateAsync();

        var items = response.Properties.Items;


        ViewBag.AuthProps = items;

        return View();
    }


    [HttpGet]
    public async Task<IActionResult> ApplicationId(Guid Id)
    {
        var applicationToGet = await _applicationService.GetApplicationById(Id);

        return View(applicationToGet);
    }
}