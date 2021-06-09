using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Medidas
    {
        private int Clave_Producto;
        private string Medida_Producto;
        private double Precio_Producto;
        private int Stock_Producto;

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

        public string Medida_Producto1
        {
            get
            {
                return Medida_Producto;
            }

            set
            {
                Medida_Producto = value;
            }
        }

        public double Precio_Producto1
        {
            get
            {
                return Precio_Producto;
            }

            set
            {
                Precio_Producto = value;
            }
        }

        public int Stock_Producto1
        {
            get
            {
                return Stock_Producto;
            }

            set
            {
                Stock_Producto = value;
            }
        }
    }
}
