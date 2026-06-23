using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAlert
{
    public class Sensor
    {
        private int _id;
        private string _estado;

        public int Id { 
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }
        public string Estado
        {
            get { return _estado; }
            set
            {
                if (value == "Ok" || value == "Alerta" || value == "Peligro")
                {
                    _estado = value;
                }
            }
        }

        public virtual string EvaluarLectura(double valor)
        {
            return $"Sensor {Id} evaluando lectura...";
        }
    }
}
