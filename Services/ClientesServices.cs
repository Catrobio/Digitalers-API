using DigitalersLib.Enums;
using DigitlaerApi.Models;

namespace DigitlaerApi.Services
{
    //Servicio de clientes donde estan cada una de los metodos para operar con la clase clientes y sus referencias
    public class ClientesServices
    {
        public Clientes GetClientes()
        {
            // Asignamos los atributos a la clase direcciones
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
            //Asignamos los atributos a la clase Clients
            var cliente = new Clientes
            {
                Id = 1,
                Nombre = "Ignacio",
                Apellido = "Pacheco",
                Documento = "123456",
                Direccion = direccion,
                TipoCliente = EnumCliente.Alto.ToString()
            };
            
            return cliente;
        }

        public Clientes SetClientes(Clientes cliente)
        {
            //Instanciamos Direcciones
            var direccionResult = new Direcciones();
            // Asignamos los valores que estan el en el paramtro cliente.Direccion a la instancia de la clase Direciones
            direccionResult = cliente.Direccion;
            //Reaccignamos el valor a 1 en el Id
            direccionResult.Id = 1;
            //Instanciamos Cliente
            var clienteResult = new Clientes();
            // Asignamos el valor de clienteResult a cliente (lo que entra en el metodo por parametro)
            clienteResult = cliente;
            
            //Creamos un switch del enum de cliente para dar un Id a clienteResult dependiendo de lo que entra por parametros, siendo el atributo tambien un enum
            switch (cliente.EnumClie)
            {
                case EnumCliente.Bajo:
                    clienteResult.Id = 1;
                    break;
                case EnumCliente.Medio:
                    clienteResult.Id = 2;
                    break;
                case EnumCliente.Alto:
                    clienteResult.Id = 3;
                    break;
                default:
                    break;
            }            
            //Asignamos el valor de clienteResult.Direcciones igual a direcionResult
            clienteResult.Direccion = direccionResult;         
            return clienteResult;
        }

        public Telefonos SetNumeroTelefono()
        {
            var telefono = new Telefonos
            {
                Id = 1,
                Numero = "11322647",
                CodigoArea = "11",
            };

            var tel = telefono.Numero;
            var id = telefono.Id;
            var area = telefono.CodigoArea;

            telefono.Numero = "11322647";
            telefono.CodigoArea = "11";
            telefono.Id = 3;
            return telefono;
            
        }
    }
}
