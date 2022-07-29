namespace DigitlaerApi.Models
{
    //Clase telefonos
    public class Telefonos
    {
        //Aca indicamos las distintas formas de aplicar un gtter y setter
        public int Id { get; set; }
        private string codigoArea;
        private string numero;

        public string CodigoArea { get => codigoArea; set => codigoArea = value; }
        public string Numero
        {
            get { return "El numero de telefono es:"+ numero; }
            set { numero = value; }
        }
    }
}
