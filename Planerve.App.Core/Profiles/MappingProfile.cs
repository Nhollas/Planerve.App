using AutoMapper;
using Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication;
using Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationById;
using Planerve.App.Core.Features.FormData.Commands.CompleteForm;
using Planerve.App.Core.Features.FormData.Commands.UpdateForm;
using Planerve.App.Core.Features.FormData.Queries.GetFormById;
using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Core.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        // Appllication Data Maps
        CreateMap<Application, CreateApplicationCommand>().ReverseMap();
        CreateMap<Application, ApplicationDetailVm>().ReverseMap();

        // Form Data Maps
        CreateMap<Form, FormCompletedVm>().ReverseMap();
        CreateMap<Form, FormDetailVm>().ReverseMap();
        CreateMap<Form, CompleteFormCommand>().ReverseMap();
        CreateMap<Form, UpdateFormCommand>().ReverseMap();
    }
}