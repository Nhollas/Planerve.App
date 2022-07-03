using System;

namespace Planerve.App.Core.Interfaces.Services
{
    public interface IDateTimeService
    {
        DateTime UtcNow { get; }
    }
}
