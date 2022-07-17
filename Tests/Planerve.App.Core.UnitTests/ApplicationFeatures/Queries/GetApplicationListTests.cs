using AutoMapper;
using Moq;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationList;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.Profiles;
using Planerve.App.Core.UnitTests.Mocks;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Shouldly;

namespace Planerve.App.Core.UnitTests.ApplicationFeatures.Queries
{
    public class GetApplicationListTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Application>> _repository;
        private readonly Mock<IUserService> _userService;

        public GetApplicationListTests()
        {
            _repository = RepositoryMocks.AsyncApplicationRepository();
            var configurationProvider = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = configurationProvider.CreateMapper();
            _userService = RepositoryMocks.GetUserService();
        }

        [Fact]
        public async Task GetApplicationListQuery()
        {
            var handler = new GetApplicationListQueryHandler(_mapper, _repository.Object, _userService.Object);

            var result = await handler.Handle(new GetApplicationListQuery()
            {

            }, CancellationToken.None);
            // As the application data store only has 1 application that "TestUserId" owns only that application should be pulled through.
            result.Count.ShouldBe(1);
        }

        // TODO: Learn to configure a MOQ service of MediatR, so that we can create a new test that "TestUserId" has no applications and will assert an Exception message being thrown.
    }
}
