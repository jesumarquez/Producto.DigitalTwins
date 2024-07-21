using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Producto.DigitalTwins.Contract.Colada;

namespace Producto.DigitalTwins.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColadaController : ControllerBase
    {
        [HttpPost("crear")]
        public IActionResult CrearColada(CrearColadaRequest crearColadaRequest)
        {
            return Ok(crearColadaRequest);
        }
    }
}
