using Microsoft.AspNetCore.Mvc;
using DigitlaerApi.Services;
using DigitlaerApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitlaerApi.Controllers
{
    //Decorado
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private ClientesServices clienteServices = new ClientesServices();
        // GET: api/<ClientesController>
        [HttpGet]
        public Clientes Get()
        {            
            var clienteResult = clienteServices.GetClientes();
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
            return clienteServices.SetClientes(parametro);
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
