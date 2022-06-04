using System;
using MediatR;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.ShareApplication
{
    public class ShareApplicationCommandHandler : IRequestHandler<ShareApplicationCommand>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IUserDataRepository _userDataRepository;

        public ShareApplicationCommandHandler(IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService, IUserDataRepository userDataRepository)
        {
            _repository = repository;
            _loggedInUserService = loggedInUserService;
            _userDataRepository = userDataRepository;
        }


        public async Task<Unit> Handle(ShareApplicationCommand request, CancellationToken cancellationToken)
        {
            var userId = await _loggedInUserService.UserId();

            var specification = new GetApplicationByIdSpecification(request.ApplicationId, userId);

            var application = _repository.FindWithSpecificationPattern(specification);

            var selectedApplication = application.First();

            if (selectedApplication.OwnerId != userId)
            {
                throw new NotAuthorisedException(nameof(Application), userId);
            }

            var matches = await _userDataRepository.GetUserByEmailOrName(request.UsernameOrEmail);

            var selectedMatch = matches.First();
            
            // TODO: Let recipient know they have been given access to application via email.

            ApplicationUser blankUser = new()
            {
                UserId = selectedMatch.Id,
                AccessLevel = "Contributor",
                IsValid = true,
                ExpiryDate = DateTime.Now.AddDays(30),
                Id = request.ApplicationId,
                ReadApplication = true,
                ReadForm = true,
                CopyApplication = false,
                EditForm = true,
                DownloadForm = true
            };

            selectedApplication.Data.Users.Add(blankUser);

            await _repository.UpdateAsync(selectedApplication);

            return Unit.Value;
        }

    }
}
