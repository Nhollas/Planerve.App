using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Identity.Data;
using Planerve.App.Identity.Models;
using Planerve.App.Identity.Services;

namespace Planerve.App.Identity
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            const string connectionString = "Server=localhost;Database=PlanerveIdentity;Trusted_Connection=True;";

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.AddTransient<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
