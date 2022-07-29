using DigitalersLib.Operaciones;

namespace DigitlaerApi.Services
{
    public class OperacionesServices : Operarios
    {
        public decimal OpercionMatematica(decimal a, decimal b, string operacion)
        {
            var resultado = 0m;

            switch (operacion.ToUpper())
            {
                case "SUMA":
                    resultado = a + b;
                    break;
                case "RESTA":
                    resultado = a - b;
                    break;
                case "MULTIPLICA":
                    resultado = a * b;
                    break;
                default:
                    resultado = 0;
                    break;
            }

            return resultado;
        }

        public decimal[] GetSueldosOperarios()
        {            
            return sueldos;
        }
    }
}
