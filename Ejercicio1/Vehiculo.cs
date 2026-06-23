using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartToll
{
    public class Vehiculo
    {
        private string _patente;
        private decimal _saldoEnCuenta;

        public string Patente
        {
            get { return (_patente); }
            set { if (!string.IsNullOrWhiteSpace(value))
                {
                    _patente = value;
                }
            }
        }
        public decimal SaldoEnCuenta
        {
            get { return (_saldoEnCuenta); }
            set { if (value >= 0) { 
                    _saldoEnCuenta = value; }
            }
        }


        public virtual string PagarPeaje(decimal tarifa)
        {
            if (_saldoEnCuenta >= tarifa)
            {
                _saldoEnCuenta -= tarifa;
                return $"Peaje pagado. Saldo restante: {_saldoEnCuenta}";
            }
            else
            {
                return "Saldo insuficiente.";
            }
        }
    }
}
