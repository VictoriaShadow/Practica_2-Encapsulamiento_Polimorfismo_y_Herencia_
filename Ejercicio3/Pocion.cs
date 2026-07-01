using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCraft
{
    public class Pocion : ItemMercado
    {
        public override string CotizarVenta(int cantidad)
        {
            decimal total;
            if (cantidad > Stock)
            {
                total = Stock * PrecioBase;
                return $"No hay suficiente stock, el precio total del stock actual ({Stock}) es {total}";
            } else
            {
                total = cantidad * PrecioBase;
                return $"El total de la compra es {total}";
            }
        }
    }
}