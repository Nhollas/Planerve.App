using Planerve.App.Core.Classes;
using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Core.Specification.ApplicationQueries;

public class GetApplicationListSpecification : BaseSpecification<Application>
{
    // Get any application that this user owns or they have a valid access to.
    public GetApplicationListSpecification(string userId) : base(x => x.Owner == userId)
    {
        AddInclude(x => x.Submission);
        AddOrderByDescending(x => x.CreatedDate);
    }
}
