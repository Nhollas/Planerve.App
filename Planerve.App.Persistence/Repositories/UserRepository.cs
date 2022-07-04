using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Domain.Entities.AuthEntities;
using Planerve.App.Persistence.Contexts;
using Planerve.App.Persistence.Repositories.Generic;
using System.Linq;

namespace Planerve.App.Persistence.Repositories;

public class UserRepository : BaseRepository<ApplicationUser>, IUserRepository 
{
    public UserRepository(PlanerveDbContext repositoryContext)
    : base(repositoryContext)
    {
    }

    public ApplicationUser Register(ApplicationUser user)
    {
        var result = _dbContext.Users.Add(user);
        _dbContext.SaveChanges();

        return result.Entity;
    }

    public bool EmailExists(string email)
    {
        bool result = _dbContext.Users.Any(e => e.Email == email);

        return result;
    }

    public bool UserExists(string username)
    {
        bool result = _dbContext.Users.Any(e => e.UserName == username);

        return result;
    }

    public ApplicationUser QueriedUser(string query)
    {
        var result = _dbContext.Users.Where(e => e.UserName == query || e.Email == query).FirstOrDefault();

        return result;
    }

    public ApplicationUser GetUser(string username)
    {
        var result = _dbContext.Users.Where(x => x.UserName == username).FirstOrDefault();

        return result;
    }
}