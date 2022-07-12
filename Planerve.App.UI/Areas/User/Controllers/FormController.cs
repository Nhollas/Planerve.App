using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.UI.Interfaces;

namespace Planerve.App.UI.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class FormController : Controller
    {
        private readonly IApplicationDataService _applicationService;
        public FormController(IApplicationDataService applicationService)
        {
            _applicationService = applicationService;
        }

        //[HttpGet]
        //public async Task<IActionResult> View(Guid Id, int type)
        //{
        //    var form = await _applicationService.GetFormById(Id, type);

        //    if (form == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(form);
        //}
    }
}
