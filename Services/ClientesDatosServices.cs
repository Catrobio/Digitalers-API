using DigitlaerApi.Models;
using DigitalersLib.Contans;

namespace DigitlaerApi.Services
{
    //Servicio de clientes donde estan cada una de los metodos para operar con la clase clientes y sus referencias
    public class ClientesDatosServices : ClientesServices // De esta manera decimos que esta clase hereda de la clase ClienteServices
    {
        public Clientes setClientesDatos(Telefonos telefono)
        {
            var clienteGuardado = GetClientes();

            /*string[] arry = new string[5];
            arry[0] = "string1";
            arry[1] = "string2";*/
            //Instanciamos una lista de la clase Telefonos para poder trabajar con las list
            var listTelefonos = new List<Telefonos>();                                  

            var telefonoResult = new Telefonos
            {
                Id = 1,
                Numero = "33314",
                CodigoArea = "23"
            };
            //Con el metodo Add agregamos el objeto telefonoResult a la lista de Telefonos ListTelefonos
            listTelefonos.Add(telefonoResult);
            //Con el metodo Add agregamos otro objeto esta vez telefono que entra por parametro
            listTelefonos.Add(telefono);

            clienteGuardado.Telefonos = listTelefonos;

            return clienteGuardado;
        }

        public string[] getConsultas()
        {
            var consultas = new Consultas();
            string[] result = new string[2];
            
            result[0] = consultas.consulta2;            

            return result;
        }
    }
}
