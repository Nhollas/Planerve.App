using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Planerve.App.Core.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Planerve.App.Persistence.Repositories;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
    protected readonly PlanerveDbContext DbContext;

    public BaseRepository(PlanerveDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<T> AddAsync(T entity)
    {
        await DbContext.Set<T>().AddAsync(entity);
        await DbContext.SaveChangesAsync();

        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        DbContext.Set<T>().Remove(entity);
        await DbContext.SaveChangesAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await DbContext.Set<T>().FindAsync(id);
    }
}