using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationList
{
    public class GetApplicationListQueryHandler : IRequestHandler<GetApplicationListQuery, List<Application>>
    {
        private readonly IApplicationDataRepository _appDataRepository;
        private readonly IMapper _mapper;

        public GetApplicationListQueryHandler(IMapper mapper, IApplicationDataRepository appDataRepository)
        {
            _mapper = mapper;
            _appDataRepository = appDataRepository;
        }

        public async Task<List<Application>> Handle(GetApplicationListQuery request,
            CancellationToken cancellationToken)
        {
            var allApps = await _appDataRepository.GetApplicationList(request.UserId);
            return _mapper.Map<List<Application>>(allApps);
        }
    }
}
