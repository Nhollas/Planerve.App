using AutoMapper;
using Planerve.App.UI.Services.Base;
using Planerve.App.UI.ViewModels.ApplicationVMs;

namespace Planerve.App.UI.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {

            // ApplicationDetailViewModel = View, CreateApplicationCommand = Dto
            CreateMap<ApplicationDetailViewModel, CreateApplicationCommand>().ReverseMap();
            CreateMap<Domain.Entities.FormEntities.FormTypeOne, FormTypeOne>().ReverseMap();
            CreateMap<Domain.Entities.FormEntities.FormTypeTwo, FormTypeTwo>().ReverseMap();

            CreateMap<ApplicationDetailVm, ApplicationDetailViewModel>().ReverseMap();
            CreateMap<ApplicationListVm, ApplicationListViewModel>().ReverseMap();
        }
    }
}