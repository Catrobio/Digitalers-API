using Microsoft.AspNetCore.Mvc;
using DigitlaerApi.Services;

//Todos los endpoint de Operaciones 
namespace DigitlaerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : Controller
    {
        //Instancio la clase OperacionesServices para poder acceder a todos sus metdos (Dependiendo del nivel de acceso)
        OperacionesServices _operacionesServices = new OperacionesServices();

        [HttpGet("Matematicas/{operacion}")]
        public decimal GetOperacionMatematica([FromQuery] decimal a, [FromQuery] decimal b, string operacion)
        {
            return _operacionesServices.OpercionMatematica(a,b,operacion);
        }

        [HttpGet("Sueldos/Operarios")]
        public decimal[] GetSueldosOperarios()
        {
            return _operacionesServices.GetSueldosOperarios();
        }
    }
}
