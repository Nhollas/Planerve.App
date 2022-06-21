using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories;

public class UserDataRepository : IUserDataRepository
{
    private readonly PlanerveIdentityDbContext _dbContext;
    
    public UserDataRepository(PlanerveIdentityDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<IQueryable<IdentityUser>> GetUserByEmailOrName(string query)
    {
        var matches = _dbContext.Users.Where(e => e.NormalizedEmail == query || e.UserName == query);

        return Task.FromResult(matches);
    }    
}