using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Producto.DigitalTwins.Application.Behaviors;
using System.Reflection;

namespace Producto.DigitalTwins.Application
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDigitalTwinsApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(DependencyInjections).Assembly);
            });

            // MediatR ValidationBehavior
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            // FluentValidation
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
