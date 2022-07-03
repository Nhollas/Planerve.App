using Planerve.App.Domain.Entities.AuthEntities;

namespace Planerve.App.Core.Contracts.Persistence;

public interface IUserRepository
{
    public bool EmailExists(string email);
    public bool UserExists(string username);
    public ApplicationUser Register(ApplicationUser user);
    public ApplicationUser GetUser(string username);
}