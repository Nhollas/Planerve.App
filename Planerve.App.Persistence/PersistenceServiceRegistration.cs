using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Planerve.App.Persistence.Contexts;

namespace Planerve.App.Infrastructure;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.AddDbContext<PlanerveDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("PlanerveConnectionString")));

        services.AddDbContext<PlanerveIdentityDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("PlanerveIdentityConnectionString")));

        return services;
    }
}