using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAlert
{
    public class SensorPresion : Sensor
    {
        public List<double> HistorialLecturas { get; set; } = new List<double>();

        public override string EvaluarLectura(double valor)
        {
            HistorialLecturas.Add(valor);

            if (HistorialLecturas.Count >= 3)
            {
                double lectura1 = HistorialLecturas[HistorialLecturas.Count - 3];
                double lectura2 = HistorialLecturas[HistorialLecturas.Count - 2];
                double lectura3 = HistorialLecturas[HistorialLecturas.Count - 1];

                if (lectura1 < lectura2 && lectura2 < lectura3)
                {
                    Estado = "Alerta";
                    return $"Sensor {Id}: Tendencia inestable";
                }
            }

            Estado = "Ok";
            return $"Sensor {Id}: Estado normal";
        }
    }
}