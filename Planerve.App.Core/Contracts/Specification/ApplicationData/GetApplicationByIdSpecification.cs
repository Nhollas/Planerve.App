using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Linq;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData;

public class GetApplicationByIdSpecification : BaseSpecification<Application>
{
    // Get an application by id that this user owns or they have a valid access token to.
    public GetApplicationByIdSpecification(Guid Id, string userId) : base(x => x.OwnerId == userId && x.Id == Id || x.Data.Users.Any(x => x.UserId == userId && x.IsValid == true) && x.Id == Id)
    {
        AddInclude(x => x.Data);
        AddInclude(x => x.Data.Progress);
        AddInclude(x => x.Data.Users);
        AddInclude(x => x.Data.Type);
        AddInclude(x => x.Data.Address);
        AddInclude(x => x.Data.Document);
    }
}
