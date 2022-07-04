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

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeA;
public class UpdateFormTypeACommandHandler : IRequestHandler<UpdateFormTypeACommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IAuthorizationService _authorizationService;
    private readonly IUserService _userService;

    public UpdateFormTypeACommandHandler(
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
        // Validate command.
        var validator = new UpdateFormTypeACommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
            throw new ValidationException(validationResult);

        var user = await _userService.GetUser();

        ApplicationPermission authorisedUsers = await _unitOfWork.ApplicationUserRepository.GetByIdAsync(request.Id);

        var authorisedResult = await _authorizationService.AuthorizeAsync(user, authorisedUsers, FormPolicies.UpdateForm);

        // If check fails this user doesn't have permissions to update this form, throw NotAuthorisedException.
        if (!authorisedResult.Succeeded)
        {
            throw new NotAuthorisedException((nameof(FormTypeA)), user.Identity.Name);
        }

        await _unitOfWork.FormTypeARepository.UpdateAsync(_mapper.Map<FormTypeA>(request));

        return Unit.Value;
    }
}
