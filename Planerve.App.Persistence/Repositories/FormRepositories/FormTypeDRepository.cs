using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.FormRepositories
{
    public class FormTypeDRepository : BaseRepository<FormTypeD>, IFormTypeDRepository
    {
        public FormTypeDRepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }
    }
}
