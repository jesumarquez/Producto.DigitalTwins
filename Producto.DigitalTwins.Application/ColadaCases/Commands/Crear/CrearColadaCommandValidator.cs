using FluentValidation;

namespace Producto.DigitalTwins.Application.ColadaCases.Commands.Crear
{
    public class CrearColadaCommandValidator : AbstractValidator<CrearColadaCommand>
    {
        public CrearColadaCommandValidator()
        {
            RuleFor(x => x.Numero).GreaterThan(9999);
        }
    }
}
