using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Domain.Entities.ApplicationEntities;

namespace Planerve.App.Persistence.Repositories
{
    public class AccessTokenRepository : BaseRepository<AccessToken>, IAccessTokenRepository
    {
        public AccessTokenRepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }
    }
}
