using Producto.DigitalTwins.Application.Repositories;
using Producto.DigitalTwins.Domain.Entities;

namespace Producto.DigitalTwins.Application.Services.ColadaService
{
    public class ColadaService : IColadaService
    {
        private readonly IColadaRepository _coladaRepository;

        public ColadaService(IColadaRepository coladaRepository)
        {
            _coladaRepository = coladaRepository;
        }

        public ColadaCreadaResult CrearColada(int numeroColada)
        {
            if(_coladaRepository.GetByNumeroColada(numeroColada) is not null)
            {
                throw new Exception("Existe una colada con el mismo numero.");
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
