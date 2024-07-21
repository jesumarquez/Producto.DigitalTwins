namespace Producto.DigitalTwins.Application.Services.Colada
{
    public class ColadaService : IColadaService
    {
        public ColadaCreadaResult CrearColada(int numeroColada)
        {
            return new ColadaCreadaResult(Guid.NewGuid(), numeroColada, DateTime.UtcNow);
        }
    }
}
