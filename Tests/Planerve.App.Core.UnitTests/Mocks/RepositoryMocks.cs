using Moq;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.UnitTests.DataStores;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;

namespace Planerve.App.Core.UnitTests.Mocks
{
    public class RepositoryMocks
    {
        private static readonly List<Application> applications = ApplicationDataStore.Applications;
        private static readonly List<FormTypeA> formTypeAs = FormDataStore.FormTypeA;
        private static readonly List<FormTypeB> formTypeBs = FormDataStore.FormTypeB;
        private static readonly List<FormTypeC> formTypeCs = FormDataStore.FormTypeC;
        private static readonly List<FormTypeD> formTypeDs = FormDataStore.FormTypeD;
        private static readonly List<FormTypeE> formTypeEs = FormDataStore.FormTypeE;

        public static Mock<IUnitOfWork> GetApplicationRepository()
        {
            var mockApplicationRepository = new Mock<IUnitOfWork>();

            mockApplicationRepository.Setup(repo => repo.FormTypeARepository.AddAsync(It.IsAny<FormTypeA>()));
            mockApplicationRepository.Setup(repo => repo.FormTypeBRepository.AddAsync(It.IsAny<FormTypeB>()));
            mockApplicationRepository.Setup(repo => repo.FormTypeCRepository.AddAsync(It.IsAny<FormTypeC>()));
            mockApplicationRepository.Setup(repo => repo.FormTypeDRepository.AddAsync(It.IsAny<FormTypeD>()));
            mockApplicationRepository.Setup(repo => repo.FormTypeERepository.AddAsync(It.IsAny<FormTypeE>()));

            mockApplicationRepository.Setup(repo => repo.FormTypeARepository.FindWithSpecificationPattern(It.IsAny<ISpecification<FormTypeA>>()))
                .Returns((ISpecification<FormTypeA> specification) =>
                {
                    var criteria = specification.Criteria;

                    var queryableList = formTypeAs.AsQueryable();

                    var result = queryableList.Where(criteria).ToList();

                    return result;
                });

            mockApplicationRepository.Setup(repo => repo.ApplicationRepository.ListAllAsync()).ReturnsAsync(applications);

            mockApplicationRepository.Setup(repo => repo.ApplicationRepository.AddAsync(It.IsAny<Application>())).ReturnsAsync((Application application) =>
            {
                applications.Add(application);
                return application;
            });

            mockApplicationRepository.Setup(
                repo => repo.ApplicationRepository.FindWithSpecificationPattern(It.IsAny<ISpecification<Application>>()))
                .Returns((ISpecification<Application> specification) =>
                {
                    var criteria = specification.Criteria;

                    var queryableList = applications.AsQueryable();

                    var result = queryableList.Where(criteria).ToList();

                    return result;
                });

            return mockApplicationRepository;
        }

        public static Mock<IAsyncRepository<Application>> AsyncApplicationRepository()
        {
            var mockApplicationRepository = new Mock<IAsyncRepository<Application>>();

            mockApplicationRepository.Setup(
                repo => repo.FindWithSpecificationPattern(It.IsAny<ISpecification<Application>>()))
                .Returns((ISpecification<Application> specification) =>
                {
                    var criteria = specification.Criteria;

                    var queryableList = applications.AsQueryable();

                    var result = queryableList.Where(criteria).ToList();

                    return result;
                });

            return mockApplicationRepository;
        }

        public static Mock<IUserService> GetUserService()
        {
            var mockUserService = new Mock<IUserService>();

            mockUserService.Setup(repo => repo.UserId()).Returns("TestUserId");

            return mockUserService;
        }
    }
}
