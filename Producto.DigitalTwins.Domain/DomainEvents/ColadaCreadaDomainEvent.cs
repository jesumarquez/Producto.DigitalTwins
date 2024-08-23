using Producto.DigitalTwins.Domain.Primivites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto.DigitalTwins.Domain.DomainEvents
{
    public sealed record ColadaCreadaDomainEvent(Guid ColadaId, int NumeroColada) : IDomainEvent
    {
    }
}
