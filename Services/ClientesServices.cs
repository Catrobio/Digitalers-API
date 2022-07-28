using DigitlaerApi.Models;

namespace DigitlaerApi.Services
{
    public class ClientesServices
    {
        public Clientes GetClientes()
        {
            var direccion = new Direcciones
            {
                Id = 1,
                Ciudad = "Buenos Aires",
                Barrio = "Floresta",
                Calle = "Carrasco",
                Numero = 100,
                Piso = 1,
                Dpto = "D",
                Pais = "Argentina"                
            };

            var cliente = new Clientes
            {
                Id = 1,
                Nombre = "Ignacio",
                Apellido = "Pacheco",
                Documento = "123456",
                Direccion = direccion
            };

            return cliente;
        }

        public Clientes SetClientes(Clientes cliente)
        {
            var direccionResult = new Direcciones();
            direccionResult = cliente.Direccion;
            direccionResult.Id = 1;

            var clienteResult = new Clientes();
            clienteResult = cliente;

            clienteResult.Id = 1;
            clienteResult.Direccion = direccionResult;

            return clienteResult;
        }
    }
}
