using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData
{
    public class IsAccessTokenUniqueSpecification : BaseSpecification<AccessToken>
    {
        public IsAccessTokenUniqueSpecification(string accessToken) : base(x => x.Token == accessToken)
        {
        }
    }
}
