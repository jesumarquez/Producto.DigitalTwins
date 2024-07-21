using Producto.DigitalTwins.Application;
using Producto.DigitalTwins.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddDigitalTwinsApplication();
    builder.Services.AddDigitalTwinsInfrastructure();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
