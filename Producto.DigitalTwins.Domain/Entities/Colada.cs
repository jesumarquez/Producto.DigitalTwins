using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.DigitalTwins.Domain.Entities
{
    public class Colada
    {
        public Guid Id { get; } = Guid.NewGuid();
        public int Numero { get; init; }
        public DateTime FechaCreacion { get; } = DateTime.UtcNow;
    }
}
