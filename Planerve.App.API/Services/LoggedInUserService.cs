using Planerve.App.Core.Contracts.Identity;
using System.Security.Claims;

namespace Planerve.App.API.Services
{
    public class LoggedInUserService : ILoggedInUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LoggedInUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Task<string> UserId ()
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);

            return Task.FromResult(userId);
        }

        public Task<ClaimsPrincipal> GetUser ()
        {
            var user = _httpContextAccessor.HttpContext?.User;

            return Task.FromResult(user);
        }
    }
}
