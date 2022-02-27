using Microsoft.AspNetCore.Components.Authorization;
using Planerve.App.UI.Services.Base;
using Planerve.App.UI.Contracts;

namespace Planerve.App.UI.Services
{
    public class AuthenticationService : BaseDataService, IAuthService
    {
        public AuthenticationService(IClient client) : base(client)
        {

        }

        public async Task<bool> Register(string userName, string email, string password, string confirmPassword)
        {
            RegistrationRequest registrationRequest = new RegistrationRequest() { Email = email, UserName = userName, Password = password };
            var response = await _client.RegisterAsync(registrationRequest);

            if (!string.IsNullOrEmpty(response.UserId))
            {
                return true;
            }
            return false;
        }
    }
}
