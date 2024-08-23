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

            public static Error NotFound => 
                Error.NotFound(code: "Colada.NotFound",
                    description: "La colada no existe.");

            public static Error NumeroColadaInvalido =>
                Error.Validation(code: "Colada.NumeroInvalido",
                    description: "Numero de colada Invalido.");
        }
    }
}
