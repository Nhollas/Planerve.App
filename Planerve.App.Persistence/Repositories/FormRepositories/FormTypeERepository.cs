using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.FormRepositories
{
    public class FormTypeERepository : BaseRepository<FormTypeE>, IFormTypeERepository
    {
        public FormTypeERepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }
    }
}
