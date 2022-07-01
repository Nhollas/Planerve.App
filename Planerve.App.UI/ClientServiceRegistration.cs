using Microsoft.EntityFrameworkCore;
using Planerve.App.Persistence.Contexts;
using Planerve.App.UI.Contracts;
using Planerve.App.UI.Services;
using Planerve.App.UI.Services.Base;
using System.Reflection;

namespace Planerve.App.UI;

public static class ClientServiceRegistration
{
    public static IServiceCollection AddClientServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthenticationService>();
        services.AddScoped<IApplicationDataService, ApplicationDataService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddDbContext<PlanerveDbContext>(options => options.UseSqlServer("ApplicationPortalConnectionString"));
        services.AddHttpContextAccessor();
        services.AddTransient<BearerTokenHandler>();

        return services;
    }
}