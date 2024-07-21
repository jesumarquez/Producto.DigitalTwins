using Microsoft.Extensions.DependencyInjection;
using Producto.DigitalTwins.Application.Services.Colada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
