using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartToll
{
    public class Particular : Vehiculo
    {
        public override string PagarPeaje(decimal tarifa)
        {
            if (SaldoEnCuenta >= tarifa)
            {
                SaldoEnCuenta -= tarifa;
                return $"Peaje pagado. Saldo restante: {SaldoEnCuenta}";
            }
            else
            {
                return "Paso denegado";
            }
        }
    }
}
