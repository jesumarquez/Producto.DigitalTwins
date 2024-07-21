using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Producto.DigitalTwins.Application.Services.ColadaService;
using Producto.DigitalTwins.Contract.Colada;

namespace Producto.DigitalTwins.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColadaController : ControllerBase
    {
        private readonly IColadaService _coladaService;

        public ColadaController(IColadaService coladaService)
        {
            _coladaService = coladaService;
        }

        [HttpPost("crear")]
        public IActionResult CrearColada(CrearColadaRequest crearColadaRequest)
        {
            ColadaCreadaResult result = _coladaService.CrearColada(crearColadaRequest.Numero);

            var response = new ColadaCreadaResponse(result.Id, result.Numero, result.FechaCreacion);

            return Ok(response);
        }
    }
}
