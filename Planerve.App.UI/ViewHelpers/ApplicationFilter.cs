using Planerve.App.UI.Interfaces;
using Planerve.App.UI.Models;
using Planerve.App.UI.ViewModels.ApplicationVMs;

namespace Planerve.App.UI.ViewHelpers
{
    public class ApplicationFilter
    {
        private readonly IApplicationDataService _applicationService;

        public ApplicationFilter(IApplicationDataService applicationService)
        {
            _applicationService = applicationService;
        }

        public IQueryable<ApplicationListViewModel> FilterApplication(ApplicationFilterModel applicationFilterModel)
        {
            var applications = _applicationService.GetApplicationList();

            var queriedApplications = applications.Result.AsQueryable();

            if (applicationFilterModel != null)
            {
                if (applicationFilterModel.SearchQuery != null)
                    queriedApplications = queriedApplications.Where(x => x.ApplicationReference == applicationFilterModel.SearchQuery || x.ApplicationName == applicationFilterModel.SearchQuery);

                if (applicationFilterModel.VersionNumber != null)
                    queriedApplications = queriedApplications.Where(x => x.VersionNumber == applicationFilterModel.VersionNumber);

                if (applicationFilterModel.ApplicationTypes != null)
                    queriedApplications = queriedApplications.Where(x => applicationFilterModel.ApplicationTypes.Select(x => x.Value).Contains(x.Type.Value));

                if (applicationFilterModel.FromDate != null && applicationFilterModel.ToDate != null)
                    queriedApplications = queriedApplications.Where(x => x.CreatedDate >= applicationFilterModel.FromDate && x.CreatedDate <= applicationFilterModel.ToDate);

                if (applicationFilterModel.FromDate != null)
                    queriedApplications = queriedApplications.Where(x => x.CreatedDate >= applicationFilterModel.FromDate);

                if (applicationFilterModel.ToDate != null)
                    queriedApplications = queriedApplications.Where(x => x.CreatedDate <= applicationFilterModel.ToDate);
            }
            return queriedApplications;
        }
    }
}
