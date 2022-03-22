using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.UI.Contracts;
using Planerve.App.UI.ViewModels.AccountVMs;

namespace Planerve.App.UI.Areas.User.Controllers;

[Area("User")]
[AllowAnonymous]
public class AccountController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IAuthService _authenticationService;

    public AccountController(IAuthService authenticationService, IHttpClientFactory httpClientFactory)
    {
        _authenticationService = authenticationService;
        _httpClientFactory = httpClientFactory ??
            throw new ArgumentNullException(nameof(httpClientFactory));
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

        if (registerResponse == true)
        {
            return RedirectToRoute(new { area = "User", controller = "Application", action = "Dashboard" });
        }

        return View();
    }

    public IActionResult Logout()
    {
        return SignOut("Cookies", "oidc");
    }
}