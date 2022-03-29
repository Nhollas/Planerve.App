using Microsoft.Extensions.DependencyInjection;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Persistence.Repositories;

namespace Planerve.App.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

        services.AddScoped<IApplicationDataRepository, ApplicationDataRepository>();
        services.AddScoped<IAccessTokenRepository, AccessTokenRepository>();

        return services;
    }
}