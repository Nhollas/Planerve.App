using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Planerve.App.UI.Areas.User.Controllers;

[Area("User")]
[AllowAnonymous]
public class AccountController : Controller
{
    public IActionResult Logout()
    {
        return SignOut("Cookies", "oidc");
    }
}