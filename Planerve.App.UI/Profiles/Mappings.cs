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
            CreateMap<Domain.Entities.ApplicationEntities.SiteApiData, SiteApiData>().ReverseMap();
            CreateMap<Domain.Entities.ApplicationEntities.SiteApiData.Result, Result>().ReverseMap();
            CreateMap<Domain.Entities.ApplicationEntities.SiteApiData.Codes, Codes>().ReverseMap();
            CreateMap<Domain.Entities.FormEntities.ApplicationTypeOne, ApplicationTypeOne>().ReverseMap();
            CreateMap<Domain.Entities.FormEntities.ApplicationTypeTwo, ApplicationTypeTwo>().ReverseMap();

            CreateMap<ApplicationDetailVm, ApplicationDetailViewModel>().ReverseMap();
            CreateMap<ApplicationListVm, ApplicationListViewModel>().ReverseMap();
        }
    }
}