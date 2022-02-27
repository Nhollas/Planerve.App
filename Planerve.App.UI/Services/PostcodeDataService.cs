using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.UI.Contracts;
using Planerve.App.UI.ViewModels.ApplicationVMs;
using System.Text.Json;

namespace Planerve.App.UI.Services;

public class PostcodeDataService : IPostcodeDataService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public PostcodeDataService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<SiteApiData> GetPostcodeById(string postcode)
    {
        var httpClient = _httpClientFactory.CreateClient("PostcodeClient");
        var apiUrl = $"postcodes/{ postcode }";

        var request = await httpClient.GetAsync(apiUrl);

        if (request.IsSuccessStatusCode)
        {
            var response = await request.Content.ReadAsStringAsync();

            var postcodeData = JsonSerializer.Deserialize<SiteApiData>(response,
                new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

            return postcodeData;
        }
        return null;
    }

    public async Task<ValidatePostcodeViewModel> ValidatePostcode(string postcode)
    {
        var httpClient = _httpClientFactory.CreateClient("PostcodeClient");
        var apiUrl = $"postcodes/{ postcode }/validate";

        var request = await httpClient.GetAsync(apiUrl);

        if (request.IsSuccessStatusCode)
        {
            var response = await request.Content.ReadAsStringAsync();

            var validateResponse = JsonSerializer.Deserialize<ValidatePostcodeViewModel>(response,
                new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            return validateResponse;
        }
        return null;
    }
}