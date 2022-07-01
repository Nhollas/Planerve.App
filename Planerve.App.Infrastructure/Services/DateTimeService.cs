using Planerve.App.Core.Services;

namespace Planerve.App.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
