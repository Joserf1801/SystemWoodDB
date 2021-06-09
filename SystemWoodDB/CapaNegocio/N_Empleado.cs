using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;


namespace CapaNegocio
{
    public class N_Empleado
    {
        D_Empleados obDato = new D_Empleados();

        public void InsertarEmpleado(string nombre, string apellidos, string calle, string colonia, string municipio, string CP, string telefono, string celular, string RFC, int numeroCuenta)
        {
            obDato.InsertarEmpleado(nombre,apellidos,calle,colonia,municipio,CP,telefono,celular,RFC,numeroCuenta);
        }

        public void EditarEmpleado(string clave,string nombre, string apellidos, string calle, string colonia, string municipio, string CP, string telefono, string celular, string RFC, int numeroCuenta)
        {
            obDato.EditarEmpleado(clave, nombre, apellidos, calle, colonia, municipio, CP, telefono, celular, RFC, numeroCuenta);
        }

        public void EliminarEmpleadoYCuenta(E_Cuentas cuenta)
        {
            obDato.EliminarEmpleadoYCuenta(cuenta);
        }

        public int ObtenerNumeroCuenta()
        {
            return obDato.ObtenerUltimaCuenta();
        }

        public List<E_Empleados> ListarEmpleado (string buscar)
        {
            return obDato.ListarEmpleados(buscar);
        }

        public void PinJefe(int claveEmp, string pin)
        {
            obDato.PinJefe(claveEmp,pin);
        }

        public void PinEmpleado(int claveEmp, string pin)
        {
            obDato.PinEmpleado(claveEmp, pin);
        }

        public int ObtenerClaveEmpleado()
        {
            return obDato.ObtenerUltimaClaveEmpleado();
        } 
    }
}
