using Planerve.App.Core.Interfaces.Services;
using System;

namespace Planerve.App.Core.Services;

public class DateTimeService : IDateTimeService
{
    public DateTime UtcNow => DateTime.UtcNow;
}

