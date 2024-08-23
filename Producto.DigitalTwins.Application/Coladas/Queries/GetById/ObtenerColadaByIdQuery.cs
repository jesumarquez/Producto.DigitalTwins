using ErrorOr;
using MediatR;
using Producto.DigitalTwins.Application.Coladas.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.DigitalTwins.Application.Coladas.Queries.GetById
{
    public record ObtenerColadaByIdQuery(Guid ColadaId) : IRequest<ErrorOr<ObtenerColadaResult>>;
}
