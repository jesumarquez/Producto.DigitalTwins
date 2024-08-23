using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.DigitalTwins.Application.Coladas.Common
{
    public record ObtenerColadaResult(Guid Id,
        int Numero,
        DateTime FechaCreacion);
}
