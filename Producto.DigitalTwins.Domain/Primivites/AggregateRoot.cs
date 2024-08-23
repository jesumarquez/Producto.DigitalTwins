namespace Producto.DigitalTwins.Domain.Primivites
{
    public abstract class AggregateRoot : Entity
    {
        protected AggregateRoot(Guid id) : base(id)
        {
        }
    }
}
