using ErrorOr;

namespace Producto.DigitalTwins.Application.Services.ColadaService
{
    public interface IColadaService
    {
        ErrorOr<ColadaCreadaResult> CrearColada(int numeroColada);
    }
}
