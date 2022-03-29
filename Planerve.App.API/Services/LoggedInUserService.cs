using Planerve.App.Core.Contracts.Identity;
using System.Security.Claims;

namespace Planerve.App.API.Services
{
    public class LoggedInUserService : ILoggedInUserService
    {
        public LoggedInUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            GetUser = httpContextAccessor.HttpContext.User;
        }

        public string UserId { get; }

        public ClaimsPrincipal GetUser { get; }
    }
}
