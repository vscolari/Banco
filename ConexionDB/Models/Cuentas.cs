using System;

namespace ConexionDB
{
    public class Cuentas
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string NroCuenta { get; set; }
        public DateTime FechaAlta { get; set; }
        public string TipoCuenta { get; set; }
        public decimal Saldo { get; set; }
        public string NroContrato { get; set; }
        public decimal CostoMantenimiento { get; set; }
        public string PromedioAcreditacion { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
    }
}
