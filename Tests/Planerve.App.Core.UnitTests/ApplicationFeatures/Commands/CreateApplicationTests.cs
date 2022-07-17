using AutoMapper;
using Moq;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.Create;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Profiles;
using Planerve.App.Core.UnitTests.Mocks;
using Shouldly;

namespace Planerve.App.Core.UnitTests.ApplicationFeatures.Commands
{
    public class CreateApplicationTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUnitOfWork> _unitOfWork;

        public CreateApplicationTests()
        {
            _unitOfWork = RepositoryMocks.GetApplicationRepository();
            var configurationProvider = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task HandleCreateApplication()
        {
            var handler = new CreateApplicationCommandHandler(_unitOfWork.Object, _mapper);

            await handler.Handle(new CreateApplicationCommand()
            {
                ApplicationName = "Test Application",
                ApplicationType = 1,
                ApplicationCategory = 1
            }, CancellationToken.None);

            var allApplications = await _unitOfWork.Object.ApplicationRepository.ListAllAsync();

            allApplications.Count.ShouldBe(4);
        }

        // TODO: Learn to configure a MOQ service of MediatR, so that we can create a new test that will fail on the validation check. And assert a ValidationException is thrown.
    }
}
