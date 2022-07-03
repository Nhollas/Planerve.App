using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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