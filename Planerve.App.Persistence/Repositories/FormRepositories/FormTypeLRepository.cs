using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.FormRepositories
{
    public class FormTypeLRepository : BaseRepository<FormTypeL>, IFormTypeLRepository
    {
        public FormTypeLRepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }
    }
}
