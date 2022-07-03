using Microsoft.EntityFrameworkCore;
using Planerve.App.Persistence.Contexts;
using Planerve.App.UI.Interfaces;
using Planerve.App.UI.Services;
using System.Reflection;

namespace Planerve.App.UI;

public static class ClientServiceRegistration
{
    public static IServiceCollection AddClientServices(this IServiceCollection services)
    {
        services.AddScoped<IApplicationDataService, ApplicationDataService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddDbContext<PlanerveDbContext>(options => options.UseSqlServer("ApplicationPortalConnectionString"));
        services.AddHttpContextAccessor();

        return services;
    }
}