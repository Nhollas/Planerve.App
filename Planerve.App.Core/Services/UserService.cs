using Microsoft.AspNetCore.Http;
using Planerve.App.Core.Interfaces.Services;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Planerve.App.Core.Services;

public class UserService : IUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    public UserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string UserId()
    {
        string userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

        return userId;
    }

    public Task<ClaimsPrincipal> GetUser()
    {
        var user = _httpContextAccessor.HttpContext.User;

        return Task.FromResult(user);
    }
}

