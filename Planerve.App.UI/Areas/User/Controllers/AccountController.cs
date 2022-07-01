using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.UI.Contracts;
using Planerve.App.UI.ViewModels.AccountVMs;

namespace Planerve.App.UI.Areas.User.Controllers;

[Area("User")]
[AllowAnonymous]
public class AccountController : Controller
{
    private readonly IAuthService _authenticationService;

    public AccountController(IAuthService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register(RegisterViewModel model)
    {
        if (model == null)
        {
            return View();
        }

        var registerResponse = await _authenticationService.Register(model.Username, model.Email, model.Password, model.ConfirmPassword);

        if (registerResponse)
        {
            return RedirectToRoute(new { area = "User", controller = "Application", action = "Dashboard" });
        }

        return View();
    }

    public IActionResult Logout()
    {
        return SignOut("Cookies", "oidc");
    }

    [HttpGet]
    public async Task<string> AccessToken()
    {
        var accessToken = await HttpContext.GetTokenAsync("access_token");

        return accessToken;
    }
}