using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Commands.UpdateApplication
{
    public class UpdateApplicationCommandHandler : IRequestHandler<UpdateApplicationCommand>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly IMapper _mapper;
        private readonly ILoggedInUserService _loggedInUserService;

        public UpdateApplicationCommandHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService)
        {
            _mapper = mapper;
            _repository = repository;
            _loggedInUserService = loggedInUserService;
        }

        public async Task<Unit> Handle(UpdateApplicationCommand request, CancellationToken cancellationToken)
        {

            // Grab userId from API user service.
            var userId = _loggedInUserService.UserId;

            var specification = new GetApplicationByIdSpecification(request.Id, userId);

            var applicationToUpdate = _repository.FindWithSpecificationPattern(specification);

            if (!applicationToUpdate.Any())
            {
                throw new NotFoundException(nameof(Application), request.Id);
            }

            var selectedApplication = applicationToUpdate.First();

            if (!selectedApplication.AuthorisedUsers.Any(x => x.UserId == userId))
            {
                throw new NotAuthorisedException(nameof(Application), userId);
            }

            var validator = new UpdateApplicationCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, applicationToUpdate, typeof(UpdateApplicationCommand), typeof(Application));

            await _repository.UpdateAsync(selectedApplication);

            return Unit.Value;
        }
    }
}
