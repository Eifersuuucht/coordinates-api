using CoordinatesApi.Data.Contexts;
using CoordinatesApi.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoordinatesApi.Data;

public static class DataModule
{
    public static IServiceCollection AddDataModule(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IRectangleRepository, RectangleRepository>();

        return services;
    }
}