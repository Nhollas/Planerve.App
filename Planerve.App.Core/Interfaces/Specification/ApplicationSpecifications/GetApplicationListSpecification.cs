using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;

namespace Planerve.App.Core.Contracts.Specification.ApplicationSpecifications;

public class GetApplicationListSpecification : BaseSpecification<Application>
{
    // Get any application that this user owns or they have a valid access to.
    public GetApplicationListSpecification(string userId) : base(x => x.CreatedBy == userId || x.Users.AuthorisedUsers.Any(x => x.UserId == userId && x.IsValid))
    {
        AddInclude(x => x.Users);
        AddInclude(x => x.Type);
        AddInclude(x => x.Document);
        AddInclude(x => x.Progress);
        AddOrderByDescending(x => x.CreatedDate);
    }
}
