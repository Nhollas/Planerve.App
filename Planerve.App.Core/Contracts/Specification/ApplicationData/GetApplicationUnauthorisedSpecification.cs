using Planerve.App.Domain.Entities.ApplicationEntities;
using System;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData
{
    public class GetApplicationUnauthorisedSpecification : BaseSpecification<Application>
    {
        // This search bypasses the check for a userId.
        public GetApplicationUnauthorisedSpecification(Guid Id) : base(x => x.Id == Id)
        {
            AddInclude(x => x.Data.Users);
        }
    }
}
