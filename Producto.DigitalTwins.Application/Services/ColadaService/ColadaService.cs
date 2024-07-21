using ErrorOr;
using Producto.DigitalTwins.Application.Repositories;
using Producto.DigitalTwins.Domain.Entities;
using Producto.DigitalTwins.Domain.Errors;

namespace Producto.DigitalTwins.Application.Services.ColadaService
{
    public class ColadaService : IColadaService
    {
        private readonly IColadaRepository _coladaRepository;

        public ColadaService(IColadaRepository coladaRepository)
        {
            _coladaRepository = coladaRepository;
        }

        public ErrorOr<ColadaCreadaResult> CrearColada(int numeroColada)
        {
            if(_coladaRepository.GetByNumeroColada(numeroColada) is not null)
            {
                return Errors.Colada.ColadaDuplicada;
            }

            var nuevaColada = new Colada()
            {
                Numero = numeroColada
            };

            _coladaRepository.Add(nuevaColada);

            return new ColadaCreadaResult(nuevaColada.Id, numeroColada, nuevaColada.FechaCreacion);
        }
    }
}
