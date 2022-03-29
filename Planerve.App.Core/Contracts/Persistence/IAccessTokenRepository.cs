using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Core.Contracts.Persistence
{
    public interface IAccessTokenRepository : IAsyncRepository<AccessToken>
    {
    }
}
