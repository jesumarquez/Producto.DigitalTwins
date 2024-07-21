using ErrorOr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.DigitalTwins.Domain.Errors
{
    public static class Errors
    {
        public static class Colada
        {
            public static Error ColadaDuplicada =>
                Error.Conflict(code: "Colada.NumeroDuplicado",
                    description: "Existe una colada con el mismo número.");
        }
    }
}
