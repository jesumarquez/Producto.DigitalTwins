using Producto.DigitalTwins.Domain.Primivites;

namespace Producto.DigitalTwins.Domain.DomainEvents
{
    public sealed record ColadaCreadaDomainEvent(Guid ColadaId, int NumeroColada) : IDomainEvent
    {
    }
}
