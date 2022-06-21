using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.FormRepositories
{
    public class FormTypeFRepository : BaseRepository<FormTypeF>, IFormTypeFRepository
    {
        public FormTypeFRepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }
    }
}
