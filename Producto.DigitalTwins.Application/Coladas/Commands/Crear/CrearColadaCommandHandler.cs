using ErrorOr;
using MediatR;
using Producto.DigitalTwins.Application.Coladas.Common;
using Producto.DigitalTwins.Application.Repositories;
using Producto.DigitalTwins.Domain.Entities;
using Producto.DigitalTwins.Domain.Errors;
using Producto.DigitalTwins.Domain.ValueObjects;

namespace Producto.DigitalTwins.Application.Coladas.Commands.Crear
{
    public class CrearColadaCommandHandler : IRequestHandler<CrearColadaCommand, ErrorOr<ColadaCreadaResult>>
    {
        private readonly IColadaRepository _coladaRepository;
        private readonly IMediator _mediator;

        public CrearColadaCommandHandler(IColadaRepository coladaRepository, IMediator mediator)
        {
            _coladaRepository = coladaRepository;
            _mediator = mediator;
        }

        public async Task<ErrorOr<ColadaCreadaResult>> Handle(CrearColadaCommand request, CancellationToken cancellationToken)
        {
            var numeroColadaResult = NumeroColada.Crear(request.Numero);

            if (numeroColadaResult.IsError)
            {
                return Errors.Colada.NumeroColadaInvalido;
            }

            if (_coladaRepository.GetByNumeroColada(request.Numero) is not null)
            {
                return Errors.Colada.ColadaDuplicada;
            }

            var nuevaColada = Colada.CrearColada(request.Numero);

            _coladaRepository.Add(nuevaColada);

            //TODO: tal vez sea mejor hacer esto en el repositorio
            foreach (var domainEvent in nuevaColada.DomainEvents)
            {
                await _mediator.Publish(domainEvent);
            }

            return new ColadaCreadaResult(nuevaColada.Id, nuevaColada.Numero, nuevaColada.FechaCreacion);
        }
    }
}
