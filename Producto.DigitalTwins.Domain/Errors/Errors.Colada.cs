using ErrorOr;

namespace Producto.DigitalTwins.Domain.Errors
{
    public static class Errors
    {
        public static class Colada
        {
            public static Error ColadaDuplicada =>
                Error.Conflict(code: "Colada.NumeroDuplicado",
                    description: "Existe una colada con el mismo número.");
        }
    }
}
