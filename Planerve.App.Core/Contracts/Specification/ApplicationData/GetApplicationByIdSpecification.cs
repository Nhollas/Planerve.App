using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Linq;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData;

public class GetApplicationByIdSpecification : BaseSpecification<Application>
{
    // Get an application by id that this user owns or they have a valid access token to.
    public GetApplicationByIdSpecification(Guid Id, string userId) : base(x => x.OwnerId == userId && x.Id == Id || x.AuthorisedUsers.Any(x => x.UserId == userId && x.IsValid == true) && x.Id == Id)
    {
        AddInclude(x => x.Address);
        AddInclude(x => x.FormData);
        AddInclude(x => x.FormData.FormTypeOneData);
        AddInclude(x => x.FormData.FormTypeTwoData);
        AddInclude(x => x.ChecklistData);
        AddInclude(x => x.AuthorisedUsers);
    }
}
