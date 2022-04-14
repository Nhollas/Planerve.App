using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Core.Contracts.Specification.ApplicationData
{
    public class IsAccessTokenUniqueSpecification : BaseSpecification<AccessToken>
    {
        // Try and find any other access tokens with the same unique ref.
        public IsAccessTokenUniqueSpecification(string accessToken) : base(x => x.TokenRef == accessToken)
        {
        }
    }
}
