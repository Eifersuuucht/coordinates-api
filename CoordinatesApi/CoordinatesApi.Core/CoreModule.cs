using CoordinatesApi.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoordinatesApi.Core;

public static class CoreModule
{
    public static IServiceCollection AddCoreModule(this IServiceCollection services)
    {
        services.AddScoped<IRectangleService, RectangleService>();

        return services;
    }
}