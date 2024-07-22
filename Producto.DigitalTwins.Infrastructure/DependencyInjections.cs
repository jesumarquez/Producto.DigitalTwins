using Microsoft.Extensions.DependencyInjection;
using Producto.DigitalTwins.Application.Repositories;
using Producto.DigitalTwins.Infrastructure.Repositories;

namespace Producto.DigitalTwins.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDigitalTwinsInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IColadaRepository, ColadaRepository>();

            return services;
        }
    }
}
