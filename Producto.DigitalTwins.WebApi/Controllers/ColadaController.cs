using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Producto.DigitalTwins.Application.ColadaCases.Commands.Crear;
using Producto.DigitalTwins.Application.ColadaCases.Common;
using Producto.DigitalTwins.Contract.Colada;

namespace Producto.DigitalTwins.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ColadaController : DigitalTwinsController
    {
        private readonly IMediator _mediator;

        public ColadaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearColada(CrearColadaRequest crearColadaRequest)
        {
            var command = new CrearColadaCommand(crearColadaRequest.Numero);

            ErrorOr<ColadaCreadaResult> result = await _mediator.Send(command);

            return result.Match(
                coladaCreadaResult => Ok(MapColadaCreadaResult(coladaCreadaResult)),
                errors => Problem(errors));
        }

        private ColadaCreadaResponse MapColadaCreadaResult(ColadaCreadaResult coladaCreadaResult)
        {
            return new ColadaCreadaResponse(coladaCreadaResult.Id, coladaCreadaResult.Numero, coladaCreadaResult.FechaCreacion);
        }
    }
}
