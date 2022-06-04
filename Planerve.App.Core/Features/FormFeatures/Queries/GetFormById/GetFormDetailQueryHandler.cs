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

namespace Planerve.App.Core.Features.FormFeatures.Queries.GetFormById;

public class GetFormDetailQueryHandler : IRequestHandler<GetFormDetailQuery, FormDetailVm>
{
    private readonly IAsyncRepository<Application> _repository;
    private readonly IMapper _mapper;
    private readonly ILoggedInUserService _loggedInUserService;
    public GetFormDetailQueryHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService)
    {
        _mapper = mapper;
        _repository = repository;
        _loggedInUserService = loggedInUserService;
    }

    public async Task<FormDetailVm> Handle(GetFormDetailQuery request,
        CancellationToken cancellationToken)
    {
        // Grab userId from API user service.
        var userId = await _loggedInUserService.UserId();

        var specification = new GetApplicationByIdSpecification(request.Id, userId);

        var applicationEntity = _repository.FindWithSpecificationPattern(specification);

        if (!applicationEntity.Any())
        {
            throw new NotFoundException(nameof(ApplicationForm), request.Id);
        }

        var selectedApplication = applicationEntity.First();

        if (selectedApplication.Data.Form is null)
        {
            throw new NotFoundException("This application has no form data", request.Id);
        }

        var formDetailDto = _mapper.Map<FormDetailVm>(selectedApplication.Data.Form);

        return formDetailDto;
    }
}