using System;

namespace ConexionDB
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Calificacion { get; set; }
        public string Estado { get; set; }
    }
}
