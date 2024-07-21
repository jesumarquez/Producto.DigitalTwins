namespace Producto.DigitalTwins.Domain.Entities
{
    public class Colada
    {
        public Guid Id { get; } = Guid.NewGuid();
        public int Numero { get; init; }
        public DateTime FechaCreacion { get; } = DateTime.UtcNow;
    }
}
