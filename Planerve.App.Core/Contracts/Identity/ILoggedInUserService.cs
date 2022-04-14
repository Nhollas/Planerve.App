using System.Security.Claims;
using System.Threading.Tasks;

namespace Planerve.App.Core.Contracts.Identity
{
    public interface ILoggedInUserService
    {
        public Task<string> UserId();

        public Task<ClaimsPrincipal> GetUser();

        public Task<bool> UsernameOrEmail();
    }
}
