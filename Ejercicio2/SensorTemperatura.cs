using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAlert
{
    public class SensorTemperatura : Sensor
    {
        public double LimiteCritico {
            get { return 80; }
        }

        public override string EvaluarLectura(double valor)
        {
            string Mensaje = "";
            if (valor > LimiteCritico)
            {
                Estado = "Peligro";
            }
            else
            {
                Estado = "Ok";
            }
                Mensaje = $"Estado del Sensor {Id}: {Estado}";
            if (Estado == "Peligro")
            {
                return Mensaje.ToUpper();
            }
            else
            {
                return Mensaje;
            }
        }
    }
}
