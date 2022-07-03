using System.Security.Claims;
using System.Threading.Tasks;

namespace Planerve.App.Core.Interfaces.Services
{
    public interface IUserService
    {
        public string UserId();

        public Task<ClaimsPrincipal> GetUser();
    }
}
