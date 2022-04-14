using MediatR;
using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationList
{
    public class GetApplicationListQuery : IRequest<List<ApplicationListVm>>
    {
    }
}
