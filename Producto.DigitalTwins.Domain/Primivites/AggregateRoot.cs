using System.Collections.ObjectModel;

namespace Producto.DigitalTwins.Domain.Primivites
{
    public abstract class AggregateRoot : Entity
    {
        private readonly List<IDomainEvent> _domainEvents = new();

        public ReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
        
        protected AggregateRoot(Guid id) : base(id)
        {
        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}
