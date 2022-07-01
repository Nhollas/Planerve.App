using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Commands.UpdateForm
{
    internal class UpdateFormCommandHandler : IRequestHandler<UpdateFormCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;
        private readonly IAuthorizationService _authorizationService;
        private readonly string _userId;

        public UpdateFormCommandHandler(
            IUnitOfWork unitOfWork, 
            IUserService userService, 
            IAuthorizationService authorizationService)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
            _authorizationService = authorizationService;
            _userId = _userService.UserId();
        }

        public async Task<Unit> Handle(UpdateFormCommand request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUser();

            ApplicationUser authorisedUsers = await _unitOfWork.ApplicationUserRepository.GetByIdAsync(request.Id);

            if (authorisedUsers == null)
            {
                throw new NotFoundException(nameof(ApplicationUser), request.Id);
            }

            var authorisedResult = await _authorizationService.AuthorizeAsync(user, authorisedUsers, FormPolicies.UpdateForm);

            if (!authorisedResult.Succeeded)
            {
                throw new NotAuthorisedException("sus", "sus");
            }

            await UpdateForm(request);

            return Unit.Value;
        }


        private async Task<object> UpdateForm(UpdateFormCommand request)
        {
            object form;
        }
    }
}
