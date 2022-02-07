using System.Reflection;
using DinkToPdf;
using DinkToPdf.Contracts;
using Kevsoft.PDFtk;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Planerve.App.Core;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddSingleton<IPDFtk, PDFtk>();
        services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

        return services;
    }
}