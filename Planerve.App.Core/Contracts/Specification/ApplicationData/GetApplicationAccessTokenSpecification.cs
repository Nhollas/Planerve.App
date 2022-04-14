using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData
{
    public class GetApplicationAccessTokenSpecification : BaseSpecification<AccessToken>
    {
        // Get access token that is equal to string.
        public GetApplicationAccessTokenSpecification(string accessToken) : base(x => x.TokenRef == accessToken)
        {
        }
    }
}
