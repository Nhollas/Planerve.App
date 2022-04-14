using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Commands.ShareApplication
{
    public class ShareApplicationCommandHandler : IRequestHandler<ShareApplicationCommand>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IAuthorizationService _authorizationService;

        public ShareApplicationCommandHandler(IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService, IAuthorizationService authorizationService)
        {
            _repository = repository;
            _loggedInUserService = loggedInUserService;
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





            return Unit.Value;
        }

    }
}
