using Microsoft.AspNetCore.Mvc;
using DigitlaerApi.Services;
using DigitlaerApi.Models;

//Todos los endpoint de clientes 

namespace DigitlaerApi.Controllers
{
    //Decorado
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        //Instancio la clase ClientesDatosServices para poder acceder a todos sus metdos (Dependiendo del nivel de acceso)

        private ClientesDatosServices clienteDatosServices = new ClientesDatosServices();

        // GET: api/<ClientesController>
        [HttpGet]
        public Clientes Get()
        {            
            var clienteResult = clienteDatosServices.GetClientes();
            return clienteResult;
        }

        // GET api/<Clientes>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Clientes>
        [HttpPost]
        public Clientes Post([FromBody] Clientes parametro)
        {
            return clienteDatosServices.SetClientes(parametro);
        }

        [HttpGet("ClienteYTelefono")]
        public Clientes PostClienteYTelefono(Telefonos telefono)
        {
            return clienteDatosServices.setClientesDatos(telefono);
        }

        [HttpGet("consultas")]
        public string[] Getconsultas()
        {
            return clienteDatosServices.getConsultas();
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
