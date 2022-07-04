using AutoMapper;
using Planerve.App.UI.Interfaces;
using Planerve.App.UI.Services.Base;
using Planerve.App.UI.ViewModels.ApplicationVMs;

namespace Planerve.App.UI.Services;

public class ApplicationDataService : BaseDataService, IApplicationDataService
{
    private readonly IMapper _mapper;

    public ApplicationDataService(IClient client, IMapper mapper) : base(client)
    {
        _mapper = mapper;
    }

    public async Task<ApplicationDetailViewModel> GetApplicationById(Guid id)
    {
        var selectedApplication = await _client.GetAsync(id);
        var mappedApplication = _mapper.Map<ApplicationDetailViewModel>(selectedApplication);
        return mappedApplication;
    }

    public async Task<List<ApplicationListViewModel>> GetApplicationList()
    {
        var applicationList = await _client.ListAsync();
        var mappedList = _mapper.Map<ICollection<ApplicationListViewModel>>(applicationList);
        return mappedList.ToList();
    }

    public async Task<ApiResponse<Guid>> CreateApplication(ApplicationDetailViewModel applicationDetailViewModel)
    {
        try
        {
            CreateApplicationCommand createApplicationCommand = _mapper.Map<ApplicationDetailViewModel, CreateApplicationCommand>(applicationDetailViewModel);
            var newId = await _client.CreateAsync(createApplicationCommand);
            return new ApiResponse<Guid>() { Data = newId, Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }

    public async Task<FormDetailViewModel> GetFormById(Guid id, int type)
    {
        var selectedForm = await _client.Get2Async(id, type);
        var mappedForm = _mapper.Map<FormDetailViewModel>(selectedForm);
        return mappedForm;
    }
}