using Planerve.App.Core.Models.Authentication;
using System.Threading.Tasks;

namespace Planerve.App.Core.Interfaces.Services.Authentication;

public interface IAuthenticationService
{
    public Task<RegistrationResponse> Register(RegistrationRequest request);
    public Task<string> Login(LoginRequest request);

}
