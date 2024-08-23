using ErrorOr;
using MediatR;
using Producto.DigitalTwins.Application.Coladas.Common;
using Producto.DigitalTwins.Application.Repositories;
using Producto.DigitalTwins.Domain.Entities;
using Producto.DigitalTwins.Domain.Errors;

namespace Producto.DigitalTwins.Application.Coladas.Queries.GetById
{
    public class ObtenerColadaByIdQueryHandler : IRequestHandler<ObtenerColadaByIdQuery, ErrorOr<ObtenerColadaResult>>
    {
        private readonly IColadaRepository _coladaRepository;

        public ObtenerColadaByIdQueryHandler(IColadaRepository coladaRepository)
        {
            _coladaRepository = coladaRepository;
        }

        public async Task<ErrorOr<ObtenerColadaResult>> Handle(ObtenerColadaByIdQuery request, CancellationToken cancellationToken)
        {
            Colada? colada = _coladaRepository.GetById(request.ColadaId);

            if (colada is null)
            {
                return Errors.Colada.NotFound;
            }

            return new ObtenerColadaResult(
                colada.Id,
                colada.Numero,
                colada.FechaCreacion);
        }
    }
}
