using System.Threading;
using System.Threading.Tasks;
using Planerve.App.Core.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationById;

public class GetApplicationDetailQueryHandler : IRequestHandler<GetApplicationDetailQuery, ApplicationDetailVm>
{
    private readonly IApplicationDataRepository _appDataRepository;
    private readonly IMapper _mapper;

    public GetApplicationDetailQueryHandler(IMapper mapper, IApplicationDataRepository appDataRepository)
    {
        _mapper = mapper;
        _appDataRepository = appDataRepository;
    }

    public async Task<ApplicationDetailVm> Handle(GetApplicationDetailQuery request,
        CancellationToken cancellationToken)
    {
        var applicationEntity = await _appDataRepository.GetApplicationById(request.Id);
        var applicationDetailDto = _mapper.Map<ApplicationDetailVm>(applicationEntity);
        
        return applicationDetailDto;
    }
}