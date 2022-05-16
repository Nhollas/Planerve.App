using Planerve.App.UI.Services.Base;
using Planerve.App.UI.ViewModels.ApplicationVMs;

namespace Planerve.App.UI.Contracts;

public interface IApplicationDataService
{
    Task<ApiResponse<Guid>> CreateApplication(ApplicationDetailViewModel applicationDetailViewModel);
    Task<ApplicationDetailViewModel> GetApplicationById(Guid id);
    Task<List<ApplicationListViewModel>> GetApplicationList();
}
