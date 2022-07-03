using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Contracts.Persistence.Generic;
using Planerve.App.Core.Contracts.Specification.ApplicationSpecifications;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById
{
    public class GetApplicationDetailQueryHandler : IRequestHandler<GetApplicationDetailQuery, ApplicationDetailVm>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IAuthorizationService _authorizationService;
        private readonly string _userId;

        public GetApplicationDetailQueryHandler(IMapper mapper, IAsyncRepository<Application> repository, IUserService userService, IAuthorizationService authorizationService)
        {
            _mapper = mapper;
            _repository = repository;
            _userService = userService;
            _authorizationService = authorizationService;
            _userId = _userService.UserId();
        }

        public async Task<ApplicationDetailVm> Handle(GetApplicationDetailQuery request,
            CancellationToken cancellationToken)
        {
            var user = await _userService.GetUser();

            var specification = new GetApplicationByIdSpecification(request.Id, _userId);

            var applicationEntity = _repository.FindWithSpecificationPattern(specification);

            if (!applicationEntity.Any())
            {
                throw new NotFoundException(nameof(Application), request.Id);
            }

            var selectedApplication = applicationEntity.First();

            var result = await _authorizationService.AuthorizeAsync(user, selectedApplication.Users, ApplicationPolicies.ReadApplication);

            if (!result.Succeeded)
            {
                throw new NotAuthorisedException(nameof(Application), _userId);
            }

            var applicationDetailDto = _mapper.Map<ApplicationDetailVm>(selectedApplication);

            return applicationDetailDto;
        }
    }
}
