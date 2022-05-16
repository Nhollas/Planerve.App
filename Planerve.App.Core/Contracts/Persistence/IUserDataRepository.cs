using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Planerve.App.Core.Contracts.Persistence;

public interface IUserDataRepository
{
    Task<IQueryable<IdentityUser>> GetUserByEmailOrName(string query);
}