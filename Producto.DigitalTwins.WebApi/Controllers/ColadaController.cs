using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Producto.DigitalTwins.Application.Coladas.Commands.Crear;
using Producto.DigitalTwins.Application.Coladas.Common;
using Producto.DigitalTwins.Application.Coladas.Queries.GetById;
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

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("hello");
        }

        [HttpGet("{coladaId:guid}")]
        public async Task<IActionResult> ObtenerColadaById(Guid coladaId)
        {
            var query = new ObtenerColadaByIdQuery(coladaId);

            ErrorOr<ObtenerColadaResult> result = await _mediator.Send(query);

            return result.Match(
                obtenerColadaByIdResult => Ok(obtenerColadaByIdResult),
                errors => Problem(errors));
        }
    }
}
