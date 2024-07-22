using ErrorOr;
using MediatR;
using Producto.DigitalTwins.Application.ColadaCases.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.DigitalTwins.Application.ColadaCases.Commands.Crear
{
    public record CrearColadaCommand(int Numero) : IRequest<ErrorOr<ColadaCreadaResult>>;
}
