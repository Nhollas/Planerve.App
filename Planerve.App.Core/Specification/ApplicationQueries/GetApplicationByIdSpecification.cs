using Planerve.App.Core.Classes;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Linq;

namespace Planerve.App.Core.Specification.ApplicationQueries;

public class GetApplicationByIdSpecification : BaseSpecification<Application>
{
    // Get an application by id that this user owns or they have a valid access to.
    public GetApplicationByIdSpecification(Guid Id, string userId) : base(x => x.CreatedBy == userId && x.Id == Id || x.Users.AuthorisedUsers.Any(x => x.UserId == userId && x.IsValid) && x.Id == Id)
    {
        AddInclude(x => x.Users);
        AddInclude(x => x.Type);
        AddInclude(x => x.Document);
        AddInclude(x => x.Progress);
    }
}
