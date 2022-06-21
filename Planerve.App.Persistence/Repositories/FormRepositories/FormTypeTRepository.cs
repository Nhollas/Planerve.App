using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.FormRepositories
{
    public class FormTypeTRepository : BaseRepository<FormTypeT>, IFormTypeTRepository
    {
        public FormTypeTRepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }
    }
}
