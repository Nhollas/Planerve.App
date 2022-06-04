using AutoMapper;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.DataHelpers;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationList;
using Planerve.App.Core.Features.FormFeatures.Queries.GetFormById;
using Planerve.App.Domain.Entities.ApplicationEntities;
using static Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication.PostcodeDataDto;

namespace Planerve.App.Core.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // ApplicationType Maps
        CreateMap<ApplicationType, ApplicationTypeHelper.ApplicationType>().ReverseMap();
        CreateMap<ApplicationType.ApplicationCategory, ApplicationTypeHelper.ApplicationCategory>().ReverseMap();

        // Form Maps
        CreateMap<ApplicationForm, ApplicationFormHelper.ApplicationForm>().ReverseMap();
        CreateMap<ApplicationForm.FormSection, ApplicationFormHelper.FormSection>().ReverseMap();
        CreateMap<ApplicationForm.FormField, ApplicationFormHelper.FormField>().ReverseMap();

        // Checklist Maps
        CreateMap<ApplicationDocument, ApplicationDocumentHelper.ApplicationDocument>().ReverseMap();
        CreateMap<ApplicationDocument.DocumentRequirement, ApplicationDocumentHelper.DocumentRequirement>().ReverseMap();

        // Application Data Maps
        CreateMap<Application, CreateApplicationCommand>().ReverseMap();
        CreateMap<Application, ApplicationDetailVm>().ReverseMap();
        CreateMap<Application, ApplicationListVm>().ReverseMap();
        CreateMap<ApplicationAddress, Result>().ReverseMap();

        // Form Data Maps
        CreateMap<ApplicationForm, FormDetailVm>().ReverseMap();
        CreateMap<ApplicationForm.FormField, FormDetailVm.FormField>().ReverseMap();
        CreateMap<ApplicationForm.FormSection, FormDetailVm.FormSection>().ReverseMap();
    }
}