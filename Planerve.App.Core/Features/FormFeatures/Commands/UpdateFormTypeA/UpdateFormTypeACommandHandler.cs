using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeA;
public class UpdateFormCommandHandler : IRequestHandler<UpdateFormTypeACommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IAuthorizationService _authorizationService;
    private readonly IUserService _userService;

    public UpdateFormCommandHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        IAuthorizationService authorizationService,
        IUserService userService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _authorizationService = authorizationService;
        _userService = userService;
    }

    public async Task<Unit> Handle(UpdateFormTypeACommand request, CancellationToken cancellationToken)
    {
        var user = _userService.GetUser().Result;

        var form = await _unitOfWork.FormTypeARepository.GetByIdAsync(request.Id);
        ApplicationUser authorisedUsers = await _unitOfWork.ApplicationUserRepository.GetByIdAsync(request.Id);

        var authorisedResult = await _authorizationService.AuthorizeAsync(user, authorisedUsers, FormPolicies.UpdateForm);

        if (!authorisedResult.Succeeded)
        {
            throw new NotAuthorisedException(nameof(form), "sus");
        }

        await _unitOfWork.FormTypeARepository.UpdateAsync(_mapper.Map<FormTypeA>(request));

        return Unit.Value;
    }
}
