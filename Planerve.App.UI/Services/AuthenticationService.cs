using Planerve.App.UI.Contracts;
using Planerve.App.UI.Services.Base;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Planerve.App.UI.Services
{
    public class AuthenticationService : IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthenticationService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ??
                throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public async Task<bool> Register(string userName, string email, string password, string confirmPassword)
        {
            var client = _httpClientFactory.CreateClient("UnauthorisedAPI");

            RegistrationRequest registrationRequest = new RegistrationRequest() { Email = email, UserName = userName, Password = password };

            var content_ = new StringContent(JsonSerializer.Serialize(registrationRequest));
            content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            var request_ = new HttpRequestMessage();

            request_.Method = HttpMethod.Post;
            request_.Content = content_;
            request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
            request_.RequestUri = new Uri("https://localhost:6001/api/account/register");

            var response_ = await client.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            var boda = await response_.Content.ReadAsStringAsync();

            var data = JsonSerializer.Deserialize<RegistrationResponse>(boda,
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            if (data != null)
            {
                return true;
            }


            return false;
        }
    }
}
