using Microsoft.Extensions.DependencyInjection;

namespace Producto.DigitalTwins.Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDigitalTwinsApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjections).Assembly);
            });

            return services;
        }
    }
}
