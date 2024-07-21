using ErrorOr;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Producto.DigitalTwins.Application.Services.ColadaService;
using Producto.DigitalTwins.Contract.Colada;

namespace Producto.DigitalTwins.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ColadaController : DigitalTwinsController
    {
        private readonly IColadaService _coladaService;

        public ColadaController(IColadaService coladaService)
        {
            _coladaService = coladaService;
        }

        [HttpPost("crear")]
        public IActionResult CrearColada(CrearColadaRequest crearColadaRequest)
        {
            ErrorOr<ColadaCreadaResult> result = _coladaService.CrearColada(crearColadaRequest.Numero);

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
