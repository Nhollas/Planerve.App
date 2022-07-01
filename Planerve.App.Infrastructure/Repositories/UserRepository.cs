using Microsoft.AspNetCore.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly PlanerveIdentityDbContext _dbContext;

    public UserRepository(PlanerveIdentityDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<IQueryable<IdentityUser>> GetUserByEmailOrName(string query)
    {
        var matches = _dbContext.Users.Where(e => e.Email == query || e.UserName == query);

        return Task.FromResult(matches);
    }
}