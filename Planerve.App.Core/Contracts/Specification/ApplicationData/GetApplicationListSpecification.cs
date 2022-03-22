using Planerve.App.Domain.Entities.ApplicationEntities;
using System;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData;

public class GetApplicationListSpecification : BaseSpecification<Application>
{
    public GetApplicationListSpecification(string userId) : base(x => x.OwnerId == userId)
    {
        AddInclude(x => x.Address);
        AddInclude(x => x.ChecklistData);
        AddInclude(x => x.AuthorisedUsers);
        AddOrderByDescending(x => x.CreatedDate);
    }
}
