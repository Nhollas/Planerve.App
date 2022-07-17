using AutoMapper;
using Moq;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.Profiles;
using Planerve.App.Core.UnitTests.Mocks;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Shouldly;

namespace Planerve.App.Core.UnitTests.ApplicationFeatures.Queries
{
    public class GetApplicationByIdTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Application>> _repository;
        private readonly Mock<IUserService> _userService;

        public GetApplicationByIdTests()
        {
            _repository = RepositoryMocks.AsyncApplicationRepository();
            var configurationProvider = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = configurationProvider.CreateMapper();
            _userService = RepositoryMocks.GetUserService();
        }

        [Fact]
        public async Task GetApplicationByIdQuery()
        {
            var handler = new GetApplicationDetailQueryHandler(_mapper, _repository.Object, _userService.Object);

            Guid applicationIdTest = Guid.Parse("1ecbe7b0-1c82-450b-a186-ad916dd6614c");

            var result = await handler.Handle(new GetApplicationDetailQuery()
            {
                // As the application data store only has 1 application that "TestUserId" owns, I've pulled the ID guid from that.
                Id = applicationIdTest

            }, CancellationToken.None);

            result.ShouldBeOfType<ApplicationDetailVm>();
            result.AppId.ShouldBeEquivalentTo(applicationIdTest);
        }

        // TODO: Learn to configure a MOQ service of MediatR, so that we can create a new test that has an incorrect Id and will assert a NotFoundException is thrown.
    }
}
