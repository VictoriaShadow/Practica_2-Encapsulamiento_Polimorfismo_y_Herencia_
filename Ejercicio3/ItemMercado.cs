using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketCraft
{
    public class ItemMercado
    {
        private string _nombre;
        private decimal _precioBase;
        private int _stock;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nombre = value;
                }
            }
        }
        public decimal PrecioBase
        {
            get {return _precioBase;}
            set
            {
                if (value >= 0)
                {
                    _precioBase = value;
                }
            }
        }
        public int Stock
        {
            get {return _stock;}
            set
            {
                if (value >= 0)
                {
                    _stock = value;
                }
            }
        }

        public virtual string CotizarVenta(int cantidad)
        {
            return $"De {Nombre} hay {Stock} y su precio base es {PrecioBase}";
        }
    }
}