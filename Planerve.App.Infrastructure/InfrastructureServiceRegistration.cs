using Microsoft.Extensions.DependencyInjection;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Persistence.Generic;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Services;
using Planerve.App.Infrastructure.Repositories;
using Planerve.App.Infrastructure.Repositories.Generic;
using Planerve.App.Infrastructure.Services;

namespace Planerve.App.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services)
    {
        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IDateTimeService, DateTimeService>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}