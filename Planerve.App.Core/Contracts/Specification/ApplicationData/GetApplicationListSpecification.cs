using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData;

public class GetApplicationListSpecification : BaseSpecification<Application>
{
    // Get any applications that this user owns or any application this user has a valid access token.
    public GetApplicationListSpecification(string userId) : base(x => x.OwnerId == userId || x.AuthorisedUsers.Any(x => x.UserId == userId && x.IsValid == true))
    {
        AddInclude(x => x.Address);
        AddInclude(x => x.ChecklistData);
        AddInclude(x => x.AuthorisedUsers);
        AddOrderByDescending(x => x.CreatedDate);
    }
}
