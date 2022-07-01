using System.Threading.Tasks;
using Planerve.App.Core.Models.Authentication;

namespace Planerve.App.Core.Contracts.Identity;

public interface IAuthenticationService
{
    Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
}