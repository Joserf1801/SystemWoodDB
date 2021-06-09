using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
  public  class E_DetallesVenta
    {
        private int Numero_Venta;
        private int Clave_Producto;
        private int Cantidad_Venta;
        private string Medidas_Venta;
        private string Subtotal_Venta;

        public string Medidas_Venta1
        {
            get
            {
                return Medidas_Venta;
            }

            set
            {
                Medidas_Venta = value;
            }
        }

        public string Subtotal_Venta1
        {
            get
            {
                return Subtotal_Venta;
            }

            set
            {
                Subtotal_Venta = value;
            }
        }
        public int Numero_Venta1
        {
            get
            {
                return Numero_Venta;
            }

            set
            {
                Numero_Venta = value;
            }
        }

        public int Clave_Producto1
        {
            get
            {
                return Clave_Producto;
            }

            set
            {
                Clave_Producto = value;
            }
        }

        public int Cantidad_Venta1
        {
            get
            {
                return Cantidad_Venta;
            }

            set
            {
                Cantidad_Venta = value;
            }
        }
    }
}
