using ErrorOr;
using MediatR;
using Producto.DigitalTwins.Application.Coladas.Common;

namespace Producto.DigitalTwins.Application.Coladas.Commands.Crear
{
    public record CrearColadaCommand(int Numero) : IRequest<ErrorOr<ColadaCreadaResult>>;
}
