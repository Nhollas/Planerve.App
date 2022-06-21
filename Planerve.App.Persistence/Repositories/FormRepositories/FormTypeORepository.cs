using Planerve.App.Core.Contracts.Persistence.FormInterfaces;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.FormRepositories
{
    public class FormTypeORepository : BaseRepository<FormTypeO>, IFormTypeORepository
    {
        public FormTypeORepository(PlanerveDbContext dbContext) : base(dbContext)
        {

        }
    }
}
