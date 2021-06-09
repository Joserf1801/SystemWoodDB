using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Ventas
    {
        private int Numero_Venta;
        private int Clave_Empleado;
        private double Total_Venta;
        private string fecha_Venta;
        private string Hora_Venta;
        

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

        public int Clave_Empleado1
        {
            get
            {
                return Clave_Empleado;
            }

            set
            {
                Clave_Empleado = value;
            }
        }

        public double Total_Venta1
        {
            get
            {
                return Total_Venta;
            }

            set
            {
                Total_Venta = value;
            }
        }

        public string Fecha_Venta
        {
            get
            {
                return fecha_Venta;
            }

            set
            {
                fecha_Venta = value;
            }
        }

        public string Hora_Venta1
        {
            get
            {
                return Hora_Venta;
            }

            set
            {
                Hora_Venta = value;
            }
        }
    }
}
