using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Text.Json;

namespace Planerve.App.API.Services
{
    public class PostcodeService : IPostcodeService
    {
        public async Task<AddressDto> ValidatePostcode(string postcode)
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

                var postcodeData = JsonSerializer.Deserialize<AddressDto>(response,
                    new JsonSerializerOptions()
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    });

                return postcodeData;
            }
            return null;
        }
    }
}
