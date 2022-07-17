using AutoMapper;
using MediatR;
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
        private readonly string _userId;

        public GetApplicationDetailQueryHandler(
            IMapper mapper,
            IAsyncRepository<Application> repository,
            IUserService userService)
        {
            _mapper = mapper;
            _repository = repository;
            _userService = userService;
            _userId = _userService.UserId();
        }

        public Task<ApplicationDetailVm> Handle(GetApplicationDetailQuery request,
            CancellationToken cancellationToken)
        {
            var specification = new GetApplicationByIdSpecification(request.Id, _userId);

            var applicationToGet = _repository.FindWithSpecificationPattern(specification).FirstOrDefault();

            if (applicationToGet == null)
            {
                throw new NotFoundException(nameof(Application), request.Id);
            }

            var applicationDetailDto = _mapper.Map<ApplicationDetailVm>(applicationToGet);

            return Task.FromResult(applicationDetailDto);
        }
    }
}
