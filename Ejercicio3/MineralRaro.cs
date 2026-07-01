using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MarketCraft
{
    public class MineralRaro : ItemMercado
    {
        private int _factorEscasez;

        public int FactorEscasez
        {
            get
            {
                return _factorEscasez;
            }
            set
            {
                if (value > 1)
                {
                    _factorEscasez = value;
                }
            }
        }
        public override string CotizarVenta(int cantidad)
        {
            decimal total;
            if (Stock < 5)
            {
                total = cantidad * PrecioBase;
                total = total * FactorEscasez;
                return $"¡Precio inflado por alta demanda! El total es {total}";
            } else
            {
                total = cantidad * PrecioBase;
                return $"El precio total es {total}";
            }
        }
    }
}