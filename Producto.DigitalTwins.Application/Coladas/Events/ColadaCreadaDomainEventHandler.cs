using MediatR;
using Microsoft.Extensions.Logging;
using Producto.DigitalTwins.Domain.DomainEvents;

namespace Producto.DigitalTwins.Application.Coladas.Events
{
    public sealed class ColadaCreadaDomainEventHandler : INotificationHandler<ColadaCreadaDomainEvent>
    {
        private readonly ILogger<ColadaCreadaDomainEventHandler> _logger;

        public ColadaCreadaDomainEventHandler(ILogger<ColadaCreadaDomainEventHandler> logger)
        {
            _logger = logger;
        }
        public Task Handle(ColadaCreadaDomainEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("La colada fué creada.");

            return Task.CompletedTask;
        }
    }
}
