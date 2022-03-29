using Planerve.App.Core.Contracts.Persistence;

namespace Planerve.App.API.Services
{
    public class PostcodeService : IPostcodeService
    {
        public async Task<string> ValidatePostcode(string postcode)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://api.postcodes.io/")
            };

            var apiUrl = $"/postcodes/{ postcode }";

            var request = await client.GetAsync(apiUrl);

            if (request.IsSuccessStatusCode)
            {
                var response = await request.Content.ReadAsStringAsync();

                return response;
            }
            return null;
        }
    }
}
