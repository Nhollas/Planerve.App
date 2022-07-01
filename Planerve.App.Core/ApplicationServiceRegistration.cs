using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Planerve.App.Core.Authorization.Handlers;
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

        return services;
    }
}