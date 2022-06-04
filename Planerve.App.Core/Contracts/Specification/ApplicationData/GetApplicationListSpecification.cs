using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Linq;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData;

public class GetApplicationListSpecification : BaseSpecification<Application>
{
    // Get any applications that this user owns or any application this user has a valid access token.
    public GetApplicationListSpecification(string userId) : base(x => x.OwnerId == userId || x.Data.Users.Any(x => x.UserId == userId && x.IsValid == true))
    {
        AddInclude(x => x.Data);
        AddInclude(x => x.Data.Form);
        AddInclude(x => x.Data.Progress);
        AddInclude(x => x.Data.Users);
        AddInclude(x => x.Data.Type);
        AddInclude(x => x.Data.Address);
        AddInclude(x => x.Data.Document);
        AddOrderByDescending(x => x.CreatedDate);
    }
}
