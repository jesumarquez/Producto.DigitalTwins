using Microsoft.Extensions.DependencyInjection;
using Producto.DigitalTwins.Application.Services.ColadaService;

namespace Producto.DigitalTwins.Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDigitalTwinsApplication(this IServiceCollection services)
        {
            services.AddScoped<IColadaService, ColadaService>();

            return services;
        }
    }
}
