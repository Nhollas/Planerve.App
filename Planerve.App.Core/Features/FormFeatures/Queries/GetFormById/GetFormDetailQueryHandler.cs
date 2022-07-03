using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Queries.GetFormById
{
    public class GetFormDetailQueryHandler : IRequestHandler<GetFormDetailQuery, FormDetailVM>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAuthorizationService _authorizationService;
        private readonly IUserService _userService;

        public GetFormDetailQueryHandler(
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

        public async Task<FormDetailVM> Handle(GetFormDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _userService.GetUser();

            PermissionUser authorisedUsers = await _unitOfWork.ApplicationUserRepository.GetByIdAsync(request.Id);

            if (authorisedUsers == null)
            {
                throw new NotFoundException(nameof(PermissionUser), request.Id);
            }

            var authorisedResult = await _authorizationService.AuthorizeAsync(user, authorisedUsers, FormPolicies.ReadForm);

            if (!authorisedResult.Succeeded)
            {
                throw new NotAuthorisedException("sus", "sus");
            }

            object form = await GetForm(request);

            if (form == null)
            {
                throw new NotFoundException(nameof(form), request.Id);
            }

            return new FormDetailVM { Data = form, Type = request.Type };
        }

        private async Task<object> GetForm(GetFormDetailQuery request)
        {
            object form;

            switch (request.Type)
            {
                case 1:
                    form = await _unitOfWork.FormTypeARepository.GetByIdAsync(request.Id);
                    return form;
                case 2:
                    form = await _unitOfWork.FormTypeBRepository.GetByIdAsync(request.Id);
                    return form;
                case 3:
                    form = await _unitOfWork.FormTypeCRepository.GetByIdAsync(request.Id);
                    return form;
                case 4:
                    form = await _unitOfWork.FormTypeDRepository.GetByIdAsync(request.Id);
                    return form;
                case 5:
                    form = await _unitOfWork.FormTypeERepository.GetByIdAsync(request.Id);
                    return form;
                default:
                    return null;
            }
        }
    }
}
