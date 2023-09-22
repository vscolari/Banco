using System;

namespace ConexionDB
{
    public class Movimientos
    {
        public int IdMovimiento { get; set; }
        public int IdCuenta { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal SaldoActual { get; set; }
        public decimal MontoMovimiento { get; set; }
        public decimal CuentaOrigen { get; set; }
        public decimal CuentaDestino { get; set; }
        public decimal Canal { get; set; }
    }
}
