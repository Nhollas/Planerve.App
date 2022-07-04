using Planerve.App.Core.Contracts.Persistence.Generic;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;

namespace Planerve.App.Core.Interfaces.Persistence.Generic;

public interface IUnitOfWork
{
    IAsyncRepository<Application> ApplicationRepository { get; }
    IAsyncRepository<ApplicationPermission> ApplicationUserRepository { get; }
    IAsyncRepository<FormTypeA> FormTypeARepository { get; }
    IAsyncRepository<FormTypeB> FormTypeBRepository { get; }
    IAsyncRepository<FormTypeC> FormTypeCRepository { get; }
    IAsyncRepository<FormTypeD> FormTypeDRepository { get; }
    IAsyncRepository<FormTypeE> FormTypeERepository { get; }
    void Save();
    void Dispose();
}
