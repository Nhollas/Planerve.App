using MediatR;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.Delete
{
    public class DeleteApplicationCommandHandler : IRequestHandler<DeleteApplicationCommand>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly IUserService _userService;
        private readonly string _userId;

        public DeleteApplicationCommandHandler(
            IAsyncRepository<Application> repository,
            IUserService userService)
        {
            _repository = repository;
            _userService = userService;
            _userId = _userService.UserId();
        }

        public async Task<Unit> Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
        {
            var applicationToDelete = await _repository.GetByIdAsync(request.Id);

            if (applicationToDelete == null)
            {
                throw new NotFoundException(nameof(Application), request.Id);
            }

            if (applicationToDelete.Owner != _userId)
            {
                throw new NotAuthorisedException(nameof(Application), _userId);
            }

            await _repository.DeleteAsync(applicationToDelete);

            return Unit.Value;
        }
    }
}
