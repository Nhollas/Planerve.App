using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Persistence.Generic;
using Planerve.App.Core.Contracts.Specification.ApplicationSpecifications;
using Planerve.App.Core.Services;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationList
{
    public class GetApplicationListQueryHandler : IRequestHandler<GetApplicationListQuery, List<ApplicationListVm>>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly string _userId;

        public GetApplicationListQueryHandler(IMapper mapper, IAsyncRepository<Application> repository, IUserService userService)
        {
            _mapper = mapper;
            _repository = repository;
            _userService = userService;
            _userId = _userService.UserId();
        }

        public Task<List<ApplicationListVm>> Handle(GetApplicationListQuery request,
            CancellationToken cancellationToken)
        {
            var specification = new GetApplicationListSpecification(_userId);

            var applicationList = _repository.FindWithSpecificationPattern(specification);

            var applicationListDto = _mapper.Map<List<ApplicationListVm>>(applicationList);

            return Task.FromResult(applicationListDto);
        }
    }
}
