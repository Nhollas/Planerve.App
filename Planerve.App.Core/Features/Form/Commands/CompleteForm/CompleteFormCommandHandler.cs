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

namespace Planerve.App.Core.Features.FormData.Commands.CompleteForm;

public class CompleteFormCommandHandler : IRequestHandler<CompleteFormCommand>
{
    private readonly IMapper _mapper;
    private readonly IAsyncRepository<Application> _repository;
    private readonly ILoggedInUserService _loggedInUserService;

    public CompleteFormCommandHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService)
    {
        _mapper = mapper;
        _repository = repository;
        _loggedInUserService = loggedInUserService;
    }

    public async Task<Unit> Handle(CompleteFormCommand request, CancellationToken cancellationToken)
    {
        // Grab userId from API user service.
        var userId = _loggedInUserService.UserId().Result;

        // Get application by id and check that current user is the owner.
        var specification = new GetApplicationByIdSpecification(request.Id, userId);

        var applicationToUpdate = _repository.FindWithSpecificationPattern(specification);

        if (!applicationToUpdate.Any())
        {
            throw new NotFoundException(nameof(Form), request.Id);
        }

        var selectedApplication = applicationToUpdate.First();

        if (!selectedApplication.AuthorisedUsers.Any(x => x.UserId == userId))
        {
            throw new NotAuthorisedException(nameof(Application), userId);
        }

        switch (selectedApplication.ApplicationType.Value)
        {
            case 1:
                var validatorOne = new CompleteFormOneCommandValidator();
                var validationResultOne = await validatorOne.ValidateAsync(request.FormTypeOneData, cancellationToken);

                if (validationResultOne.Errors.Count > 0)
                    throw new ValidationException(validationResultOne);
                selectedApplication.Checklist.FormSections = true;

                break;
            case 2:
                var validatorTwo = new CompleteFormOneCommandValidator();
                var validationResultTwo = await validatorTwo.ValidateAsync(request.FormTypeOneData, cancellationToken);

                if (validationResultTwo.Errors.Count > 0)
                    throw new ValidationException(validationResultTwo);
                selectedApplication.Checklist.FormSections = true;

                break;
        }

        _mapper.Map(request, selectedApplication, typeof(CompleteFormCommand), typeof(Form));

        await _repository.UpdateAsync(selectedApplication);

        return Unit.Value;
    }
}