using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Contracts.Authorization;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using Planerve.App.Core.Exceptions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById
{
    public class GetApplicationDetailQueryHandler : IRequestHandler<GetApplicationDetailQuery, ApplicationDetailVm>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly IMapper _mapper;
        private readonly ILoggedInUserService _loggedInUserService;
        private readonly IAuthorizationService _authorizationService;

        public GetApplicationDetailQueryHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService, IAuthorizationService authorizationService)
        {
            _mapper = mapper;
            _repository = repository;
            _loggedInUserService = loggedInUserService;
            _authorizationService = authorizationService;
        }

        // Get an application by Id,  method will specifiy the query, null and authorise check and finally map and return the item.
        public async Task<ApplicationDetailVm> Handle(GetApplicationDetailQuery request,
            CancellationToken cancellationToken)
        {
            // Grab userId from API user service.
            var userId = await _loggedInUserService.UserId();
            var user = await _loggedInUserService.GetUser();

            // Get application by id and check that current user is the owner.
            var specification = new GetApplicationByIdSpecification(request.Id, userId);

            var applicationEntity = _repository.FindWithSpecificationPattern(specification);

            if (!applicationEntity.Any())
            {
                throw new NotFoundException(nameof(Application), request.Id);
            }

            var selectedApplication = applicationEntity.First();

            var result = await _authorizationService.AuthorizeAsync(user, selectedApplication, ApplicationPolicies.ReadApplication.Requirements);

            if (!result.Succeeded)
            {
                throw new NotAuthorisedException(nameof(Application), userId);
            }

            var applicationDetailDto = _mapper.Map<ApplicationDetailVm>(selectedApplication);

            return applicationDetailDto;


        }
    }
}
