using System.Security.Claims;

namespace Planerve.App.Core.Contracts.Identity
{
    public interface ILoggedInUserService
    {
        public string UserId { get; }

        public ClaimsPrincipal GetUser { get; }
    }
}
