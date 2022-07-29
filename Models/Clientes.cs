using DigitalersLib.Enums;

namespace DigitlaerApi.Models
{    
    //La clase clientes donde tenemos cada uno de los atributos
    public class Clientes
    {
        public int Id { get; set; }            
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        //Uno de sus atributos es una clase. Esto para definir que un cliente Tienen una direccion
        public Direcciones Direccion { get; set; }
        //Tambien se compone de una lista de otra clase. Esta Lista indica que un cliente tienen varios telefonos
        public List<Telefonos> Telefonos { get; set; }        
        public string TipoCliente { get; set; }
        //Un atributo Enum indica que el el valor de este atributo se compone con uno de los de los enumerados.
        //Es propio de C# 
        public EnumCliente EnumClie { get; set; }
    }
}
