using Planerve.App.Domain.Entities.ApplicationEntities;
using System;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData;

public class GetApplicationByIdSpecification : BaseSpecification<Application>
{
    public GetApplicationByIdSpecification(Guid Id, string userId) : base(x => x.OwnerId == userId && x.Id == Id)
    {
        AddInclude(x => x.Address);
        AddInclude(x => x.FormData);
        AddInclude(x => x.FormData.FormTypeOneData);
        AddInclude(x => x.FormData.FormTypeTwoData);
        AddInclude(x => x.ChecklistData);
        AddInclude(x => x.AuthorisedUsers);
    }
}
