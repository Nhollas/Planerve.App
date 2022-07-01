using System;

namespace Planerve.App.Core.Services
{
    public interface IDateTimeService
    {
        DateTime UtcNow { get; }
    }
}
