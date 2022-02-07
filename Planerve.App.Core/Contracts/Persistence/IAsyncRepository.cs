using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planerve.App.Core.Contracts.Persistence;

public interface IAsyncRepository<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task DeleteAsync(T entity);
}