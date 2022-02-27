using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.UI.Contracts;
using Planerve.App.UI.ViewModels;
using Planerve.App.UI.ViewModels.AccountVMs;
using System.Net.Http.Headers;
using System.Text.Json;

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

    public async Task<IActionResult> CallApi()
    {
        var accessToken = await HttpContext.GetTokenAsync("access_token");

        var httpClient = _httpClientFactory.CreateClient("APIClient");

        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

        httpClient.SetBearerToken(accessToken);

        var response = await httpClient.GetAsync("/api/Identity/testapi");

        var content = await response.Content.ReadAsStringAsync();


        var parsed = JsonDocument.Parse(content);
        var formatted = JsonSerializer.Serialize(parsed, new JsonSerializerOptions { WriteIndented = true });


        CallApiViewModel model = new CallApiViewModel();

        model.Json = formatted;

        return View(model);
    }

}