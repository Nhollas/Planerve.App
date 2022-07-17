using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.Models.Authentication;

namespace Planerve.App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("register", Name = "Register")]
        public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request)
        {
            var result = await _authenticationService.Register(request);

            return Ok(result);
        }

        [HttpPost("login", Name = "Login")]
        public async Task<ActionResult<string>> Login(LoginRequest request)
        {
            var token = await _authenticationService.Login(request);

            return Ok(token);
        }
    }
}