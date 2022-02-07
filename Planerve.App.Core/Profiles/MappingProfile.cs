using Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication;
using Planerve.App.Core.Features.ApplicationData.Queries.DownloadApplicationById;
using Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationById;
using Planerve.App.Domain.Entities.ApplicationEntities;
using AutoMapper;

namespace Planerve.App.Core.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Application, CreateApplicationCommand>().ReverseMap();
        CreateMap<Application, ApplicationDetailVm>().ReverseMap();
    }
}