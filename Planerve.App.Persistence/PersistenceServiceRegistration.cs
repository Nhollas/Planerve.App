using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Persistence.Generic;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Domain.Entities.AuthEntities;
using Planerve.App.Persistence.Contexts;
using Planerve.App.Persistence.Repositories;
using Planerve.App.Persistence.Repositories.Generic;

namespace Planerve.App.Infrastructure;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.AddDbContext<PlanerveDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("PlanerveConnectionString")));

        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<PlanerveDbContext>()
        .AddDefaultTokenProviders();

        return services;
    }
}