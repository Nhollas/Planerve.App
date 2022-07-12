using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Planerve.App.Core.Interfaces.Persistence.Generic;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
    Expression<Func<T, object>> OrderBy { get; }
    Expression<Func<T, object>> OrderByDescending { get; }
}
