﻿using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormData.Queries.GetFormById;

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

    public Task<FormDetailVm> Handle(GetFormDetailQuery request,
        CancellationToken cancellationToken)
    {
        // Grab userId from API user service.
        var userId = _loggedInUserService.UserId;

        var specification = new GetApplicationByIdSpecification(request.Id, userId);

        var applicationEntity = _repository.FindWithSpecificationPattern(specification);

        if (!applicationEntity.Any())
        {
            throw new NotFoundException(nameof(Form), request.Id);
        }

        var selectedApplication = applicationEntity.First();

        if (!selectedApplication.AuthorisedUsers.Any(x => x.UserId == userId))
        {
            throw new NotAuthorisedException(nameof(Form), userId);
        }

        if (selectedApplication.FormData is null)
        {
            throw new NotFoundException("This application has no form data", request.Id);
        }

        var formDetailDto = _mapper.Map<FormDetailVm>(selectedApplication.FormData);

        formDetailDto.ApplicationType = selectedApplication.ApplicationType;

        return Task.FromResult(formDetailDto);
    }
}