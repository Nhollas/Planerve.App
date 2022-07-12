using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Authorization.Requirements;
using Planerve.App.Core.Exceptions;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.Specification.ApplicationQueries;
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

            var applicationToGet = _repository.FindWithSpecificationPattern(specification).FirstOrDefault();

            if (applicationToGet == null)
            {
                throw new NotFoundException(nameof(Application), request.Id);
            }

            var result = await _authorizationService.AuthorizeAsync(user, applicationToGet.Users, ApplicationPolicies.ReadApplication);

            // If check fails this user doesn't have permissions to read this application, throw NotAuthorisedException.
            if (!result.Succeeded)
            {
                throw new NotAuthorisedException(nameof(Application), _userId);
            }

            var applicationDetailDto = _mapper.Map<ApplicationDetailVm>(applicationToGet);

            return applicationDetailDto;
        }
    }
}
