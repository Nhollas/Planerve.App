using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Planerve.App.Core.Authorization.Handlers;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Core.Interfaces.Services.Authentication;
using Planerve.App.Core.Services;
using System.Reflection;

namespace Planerve.App.Core;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddScoped<IAuthorizationHandler, ApplicationAuthorizationHandler>();
        services.AddScoped<IAuthorizationHandler, FormAuthorizationHandler>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IDateTimeService, DateTimeService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        return services;
    }
}