using AutoMapper;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.DataHelpers;
using Planerve.App.Core.Features.ApplicationFeatures.Dtos;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationList;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeA;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeB;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeC;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeD;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeE;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;

namespace Planerve.App.Core.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Type Helper Maps
        CreateMap<ApplicationType, ApplicationTypeHelper.ApplicationType>().ReverseMap();
        CreateMap<ApplicationDocument, ApplicationDocumentHelper.ApplicationDocument>().ReverseMap();
        CreateMap<ApplicationDocument.DocumentRequirement, ApplicationDocumentHelper.DocumentRequirement>().ReverseMap();

        // Application Data Maps
        CreateMap<Application, CreateApplicationCommand>().ReverseMap();
        CreateMap<Application, ApplicationDetailVm>().ReverseMap();
        CreateMap<Application, ApplicationListVm>().ReverseMap();
        CreateMap<ApplicationType, ApplicationTypeDto>().ReverseMap();
        CreateMap<ApplicationDocument, ApplicationDocumentDto>().ReverseMap();
        CreateMap<ApplicationDocument.DocumentRequirement, DocumentRequirementDto>().ReverseMap();
        CreateMap<ApplicationProgress, ApplicationProgressDto>().ReverseMap();

        // Form Data Maps
        CreateMap<FormTypeA, UpdateFormTypeACommand>().ReverseMap();
        CreateMap<FormTypeB, UpdateFormTypeBCommand>().ReverseMap();
        CreateMap<FormTypeC, UpdateFormTypeCCommand>().ReverseMap();
        CreateMap<FormTypeD, UpdateFormTypeDCommand>().ReverseMap();
        CreateMap<FormTypeE, UpdateFormTypeECommand>().ReverseMap();

    }
}