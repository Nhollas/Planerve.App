using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.UI.Contracts;
using Planerve.App.UI.ViewModels.AccountVMs;

namespace Planerve.App.UI.Areas.Public.Controllers;

[AllowAnonymous]
[Area("Public")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}