using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.UI.ViewModels.ApplicationVMs;

namespace Planerve.App.UI.Contracts;

public interface IPostcodeDataService
{
    Task<SiteApiData> GetPostcodeById(string postcode);
    Task<ValidatePostcodeViewModel> ValidatePostcode(string postcode);
}