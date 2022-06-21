using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.FormRepositories
{
    public class FormTypeMRepository : BaseRepository<FormTypeM>, IFormTypeMRepository
    {
        public FormTypeMRepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }
    }
}
