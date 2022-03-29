using System.Threading;
using System.Threading.Tasks;
using Planerve.App.Core.Contracts.Persistence;
using AutoMapper;
using MediatR;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using System.Linq;
using Planerve.App.Core.Contracts.Identity;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationById;

public class GetApplicationDetailQueryHandler : IRequestHandler<GetApplicationDetailQuery, ApplicationDetailVm>
{
    private readonly IAsyncRepository<Application> _repository;
    private readonly IMapper _mapper;
    private readonly ILoggedInUserService _loggedInUserService;

    public GetApplicationDetailQueryHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService)
    {
        _mapper = mapper;
        _repository = repository;
        _loggedInUserService = loggedInUserService;
    }

    // Get an application by Id,  method will specifiy the query, null and authorise check and finally map and return the item.
    public Task<ApplicationDetailVm> Handle(GetApplicationDetailQuery request,
        CancellationToken cancellationToken)
    {
        // Grab userId from API user service.
        var userId = _loggedInUserService.UserId;

        // Get application by id and check that current user is the owner.
        var specification = new GetApplicationByIdSpecification(request.Id, userId);

        var applicationEntity = _repository.FindWithSpecificationPattern(specification);

        if (!applicationEntity.Any())
        {
            throw new NotFoundException(nameof(Application), request.Id);
        }

        var selectedApplication = applicationEntity.First();

        if (!selectedApplication.AuthorisedUsers.Any(x => x.UserId == userId))
        {
            throw new NotAuthorisedException(nameof(Application), userId);
        }

        var applicationDetailDto = _mapper.Map<ApplicationDetailVm>(applicationEntity.First());

        return Task.FromResult(applicationDetailDto);
    }
}

// TODO: use tokenRepository to get all tokens that are valid , then cross match this with what application they are trying to get.