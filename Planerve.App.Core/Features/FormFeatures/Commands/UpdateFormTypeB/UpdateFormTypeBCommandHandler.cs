using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeB;
public class UpdateFormTypeBCommandHandler : IRequestHandler<UpdateFormTypeBCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IAuthorizationService _authorizationService;
    private readonly IUserService _userService;

    public UpdateFormTypeBCommandHandler(
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

    public async Task<Unit> Handle(UpdateFormTypeBCommand request, CancellationToken cancellationToken)
    {
        var user = _userService.GetUser().Result;

        PermissionUser authorisedUsers = await _unitOfWork.ApplicationUserRepository.GetByIdAsync(request.Id);

        if (authorisedUsers == null)
        {
            throw new NotFoundException(nameof(FormTypeB), request.Id);
        }

        var authorisedResult = await _authorizationService.AuthorizeAsync(user, authorisedUsers, FormPolicies.UpdateForm);

        if (!authorisedResult.Succeeded)
        {
            throw new NotAuthorisedException("sus", "sus");
        }

        await _unitOfWork.FormTypeBRepository.UpdateAsync(_mapper.Map<FormTypeB>(request));

        return Unit.Value;
    }
}

