﻿namespace DigitlaerApi.Models
{
    public class Clientes
    {
        public int Id { get; set; }            
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public Direcciones Direccion { get; set; }

    }
}
