using AutoMapper;
using Planerve.App.UI.Services.Base;
using Planerve.App.UI.ViewModels.ApplicationVMs;

namespace Planerve.App.UI.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<ApplicationDetailViewModel, CreateApplicationCommand>().ReverseMap();

            CreateMap<ApplicationDetailVm, ApplicationDetailViewModel>().ReverseMap();
            CreateMap<ApplicationListVm, ApplicationListViewModel>().ReverseMap();

            CreateMap<FormDetailVm, FormDetailViewModel>().ReverseMap();
            CreateMap<FormDetailVm_FormSection, FormDetailViewModel.FormSection>().ReverseMap();
            CreateMap<FormDetailVm_FormField, FormDetailViewModel.FormField>().ReverseMap();
            CreateMap<FormDetailVm_Option, FormDetailViewModel.Option>().ReverseMap();
        }
    }
}