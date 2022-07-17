using Planerve.App.Core.Classes;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Linq;

namespace Planerve.App.Core.Specification.ApplicationQueries;

public class GetApplicationByIdSpecification : BaseSpecification<Application>
{
    // Get an application by id that this user owns or they have a valid access to.
    public GetApplicationByIdSpecification(Guid queryId, string userId) : base(x => x.Owner == userId && x.AppId == queryId)
    {
        AddInclude(x => x.Submission);
    }
}
