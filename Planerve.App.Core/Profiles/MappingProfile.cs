using AutoMapper;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.DataHelpers;
using Planerve.App.Core.Features.ApplicationFeatures.Dtos;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationList;
using Planerve.App.Core.Features.FormFeatures.Queries.GetFormById;
using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Core.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // ApplicationType Maps
        CreateMap<ApplicationType, ApplicationTypeHelper.ApplicationType>().ReverseMap();

        // Form Maps

        // Checklist Maps
        CreateMap<ApplicationDocument, ApplicationDocumentHelper.ApplicationDocument>().ReverseMap();
        CreateMap<ApplicationDocument.DocumentRequirement, ApplicationDocumentHelper.DocumentRequirement>().ReverseMap();

        // Application Data Maps
        CreateMap<Application, CreateApplicationCommand>().ReverseMap();
        CreateMap<Application, ApplicationDetailVm>().ReverseMap();
        CreateMap<Application, ApplicationListVm>().ReverseMap();
        CreateMap<ApplicationData, ApplicationDataDto>().ReverseMap();
        CreateMap<ApplicationAddress, PostcodeDataDto.Result>().ReverseMap();
    }
}