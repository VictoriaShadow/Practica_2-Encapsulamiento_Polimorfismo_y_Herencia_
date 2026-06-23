using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartToll
{
    public class Camion : Vehiculo
    {
        private int _ejes;

        public int Ejes { 
            get { return _ejes; } 
            set
            {
                if (value >= 2)
                {
                    _ejes = value;
                }
            }
        }

        public override string PagarPeaje(decimal tarifa)
        {
            tarifa = tarifa * Ejes;
            if (Ejes > 4)
            {
                tarifa = tarifa - ((tarifa * 10) / 100);
            }
            if (SaldoEnCuenta >= tarifa)
            {
                SaldoEnCuenta -= tarifa;
                return $"Peaje pagado. Saldo restante: {SaldoEnCuenta}";
            }
            else
            {
                return "Saldo insuficiente.";
            }
        }
    }
}
