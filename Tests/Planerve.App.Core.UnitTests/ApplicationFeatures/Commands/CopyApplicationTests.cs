using AutoMapper;
using Moq;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.Copy;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.Profiles;
using Planerve.App.Core.UnitTests.Mocks;
using Shouldly;

namespace Planerve.App.Core.UnitTests.ApplicationFeatures.Commands
{
    public class CopyApplicationTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IUserService> _userService;
        private readonly Mock<IUnitOfWork> _unitOfWork;

        public CopyApplicationTests()
        {
            _unitOfWork = RepositoryMocks.GetApplicationRepository();
            var configurationProvider = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = configurationProvider.CreateMapper();
            _userService = RepositoryMocks.GetUserService();
        }


        [Fact]
        public async Task HandleCorrectCopyApplication()
        {
            var handler = new CopyApplicationCommandHandler(_userService.Object, _unitOfWork.Object, _mapper);

            await handler.Handle(new CopyApplicationCommand()
            {
                // This Id is mentioned in the first item in the ApplicationDataStore list.
                ApplicationId = Guid.Parse("1ecbe7b0-1c82-450b-a186-ad916dd6614c"),
                ApplicationName = "Copied Application",
                AgentDetails = true,
                ApplicantDetails = true,
                SiteDetails = true
            }, CancellationToken.None);

            var allApplications = await _unitOfWork.Object.ApplicationRepository.ListAllAsync();
            allApplications.Count.ShouldBe(4);
        }

        // TODO: Learn to configure a MOQ service of MediatR, so that we can create a new test that will fail as the application to copy doesn't exist and will assert a NotFoundException is thrown.
    }
}
