using Producto.DigitalTwins.Domain.Entities;

namespace Producto.DigitalTwins.Application.Repositories
{
    public interface IColadaRepository
    {
        Colada? GetByNumeroColada(int numeroColada);
        void Add(Colada colada);
        Colada? GetById(Guid coladaId);
    }
}
