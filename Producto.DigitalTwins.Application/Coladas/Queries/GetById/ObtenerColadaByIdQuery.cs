using ErrorOr;
using MediatR;
using Producto.DigitalTwins.Application.Coladas.Common;

namespace Producto.DigitalTwins.Application.Coladas.Queries.GetById
{
    public record ObtenerColadaByIdQuery(Guid ColadaId) : IRequest<ErrorOr<ObtenerColadaResult>>;
}
