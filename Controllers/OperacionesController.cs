using Microsoft.AspNetCore.Mvc;
using DigitlaerApi.Services;

namespace DigitlaerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : Controller
    {
        OperacionesServices _operacionesServices = new OperacionesServices();

        [HttpGet("Matematicas/{operacion}")]
        public decimal GetOperacionMatematica([FromQuery] decimal a, [FromQuery] decimal b, string operacion)
        {
            return _operacionesServices.OpercionMatematica(a,b,operacion);
        }
    }
}
