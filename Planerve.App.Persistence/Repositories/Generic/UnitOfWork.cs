using Planerve.App.Core.Contracts.Persistence.Generic;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Persistence.Repositories.Generic;

public class UnitOfWork : IUnitOfWork
{
    private readonly PlanerveDbContext _context;

    private IAsyncRepository<Application> _applicationRepository;
    private IAsyncRepository<PermissionUser> _applicationUserRepository;
    private IAsyncRepository<FormTypeA> _formTypeARepository;
    private IAsyncRepository<FormTypeB> _formTypeBRepository;
    private IAsyncRepository<FormTypeC> _formTypeCRepository;
    private IAsyncRepository<FormTypeD> _formTypeDRepository;
    private IAsyncRepository<FormTypeE> _formTypeERepository;

    public UnitOfWork(PlanerveDbContext dbContext)
    {
        _context = dbContext;
    }

    public IAsyncRepository<Application> ApplicationRepository
    {
        get
        {
            return _applicationRepository ??= new BaseRepository<Application>(_context);
        }
    }

    public IAsyncRepository<PermissionUser> ApplicationUserRepository
    {
        get
        {
            return _applicationUserRepository ??= new BaseRepository<PermissionUser>(_context);
        }
    }

    public IAsyncRepository<FormTypeA> FormTypeARepository
    {
        get
        {
            return _formTypeARepository ??= new BaseRepository<FormTypeA>(_context);
        }
    }

    public IAsyncRepository<FormTypeB> FormTypeBRepository
    {
        get
        {
            return _formTypeBRepository ??= new BaseRepository<FormTypeB>(_context);
        }
    }

    public IAsyncRepository<FormTypeC> FormTypeCRepository
    {
        get
        {
            return _formTypeCRepository ??= new BaseRepository<FormTypeC>(_context);
        }
    }

    public IAsyncRepository<FormTypeD> FormTypeDRepository
    {
        get
        {
            return _formTypeDRepository ??= new BaseRepository<FormTypeD>(_context);
        }
    }

    public IAsyncRepository<FormTypeE> FormTypeERepository
    {
        get
        {
            return _formTypeERepository ??= new BaseRepository<FormTypeE>(_context);
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
