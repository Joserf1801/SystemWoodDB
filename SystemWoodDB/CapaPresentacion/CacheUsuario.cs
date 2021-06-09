using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public static class CacheUsuario
    {
        
        static string claveEmpleado;
        static string CodigoEmpleado;
        static string NombreEmpleado;
        static string ApellidosEmpleado;
        static string Calle_Empleado;
        static string Colonia_Empleado;
        static string Municipio_Empleado;
        static string CP_Empleado;
        static string TelefonoCasa_Empleado;
        static string Celular_Empleado;
        static string RFC_Empleado;

        static string numCuenta;
        static string Usuario_Empleado;
        static string contra_Empleado;



        static string PIN_Empleado;

        public static string ClaveEmpleado
        {
            get
            {
                return claveEmpleado;
            }

            set
            {
                claveEmpleado = value;
            }
        }

        public static string CodigoEmpleado1
        {
            get
            {
                return CodigoEmpleado;
            }

            set
            {
                CodigoEmpleado = value;
            }
        }

        public static string NombreEmpleado1
        {
            get
            {
                return NombreEmpleado;
            }

            set
            {
                NombreEmpleado = value;
            }
        }

        public static string ApellidosEmpleado1
        {
            get
            {
                return ApellidosEmpleado;
            }

            set
            {
                ApellidosEmpleado = value;
            }
        }

        public static string Calle_Empleado1
        {
            get
            {
                return Calle_Empleado;
            }

            set
            {
                Calle_Empleado = value;
            }
        }

        public static string Colonia_Empleado1
        {
            get
            {
                return Colonia_Empleado;
            }

            set
            {
                Colonia_Empleado = value;
            }
        }

        public static string Municipio_Empleado1
        {
            get
            {
                return Municipio_Empleado;
            }

            set
            {
                Municipio_Empleado = value;
            }
        }

        public static string CP_Empleado1
        {
            get
            {
                return CP_Empleado;
            }

            set
            {
                CP_Empleado = value;
            }
        }

        public static string TelefonoCasa_Empleado1
        {
            get
            {
                return TelefonoCasa_Empleado;
            }

            set
            {
                TelefonoCasa_Empleado = value;
            }
        }

        public static string Celular_Empleado1
        {
            get
            {
                return Celular_Empleado;
            }

            set
            {
                Celular_Empleado = value;
            }
        }

        public static string RFC_Empleado1
        {
            get
            {
                return RFC_Empleado;
            }

            set
            {
                RFC_Empleado = value;
            }
        }

        public static string NumCuenta
        {
            get
            {
                return numCuenta;
            }

            set
            {
                numCuenta = value;
            }
        }

        public static string Usuario_Empleado1
        {
            get
            {
                return Usuario_Empleado;
            }

            set
            {
                Usuario_Empleado = value;
            }
        }

        public static string Contra_Empleado
        {
            get
            {
                return contra_Empleado;
            }

            set
            {
                contra_Empleado = value;
            }
        }

        public static string PIN_Empleado1
        {
            get
            {
                return PIN_Empleado;
            }

            set
            {
                PIN_Empleado = value;
            }
        }

        public static void LimpiarAtributos()
        {
            claveEmpleado = null;
            CodigoEmpleado = null;
            NombreEmpleado = null;
            ApellidosEmpleado = null;
            Calle_Empleado = null;
            Colonia_Empleado = null;
            Municipio_Empleado = null;
            CP_Empleado = null;
            TelefonoCasa_Empleado = null;
            Celular_Empleado = null;
            RFC_Empleado = null;
            numCuenta = null;
            Usuario_Empleado = null;
            contra_Empleado = null;
        }

    }

    public static class FechaYHora
    {
        static string Hora;
        static string fecha;

        public static string Hora1
        {
            get
            {
                return Hora;
            }

            set
            {
                Hora = value;
            }
        }

        public static string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }
    }

    public static class ProductoVenta
    {
        private static int claveProducto;
        private static string codigoProdo;
        private static string nombreProducto;
        private static string medidasProducto;
        private static double subtotal;
        private static int cantidad;
        private static int IndiceCelda;

        public static int ClaveProducto
        {
            get
            {
                return claveProducto;
            }

            set
            {
                claveProducto = value;
            }
        }

        public static string CodigoProdo
        {
            get
            {
                return codigoProdo;
            }

            set
            {
                codigoProdo = value;
            }
        }

        public static string NombreProducto
        {
            get
            {
                return nombreProducto;
            }

            set
            {
                nombreProducto = value;
            }
        }

        public static string MedidasProducto
        {
            get
            {
                return medidasProducto;
            }

            set
            {
                medidasProducto = value;
            }
        }

        public static double Subtotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                subtotal = value;
            }
        }

        public static int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public static int IndiceCelda1
        {
            get
            {
                return IndiceCelda;
            }

            set
            {
                IndiceCelda = value;
            }
        }
    }
}
