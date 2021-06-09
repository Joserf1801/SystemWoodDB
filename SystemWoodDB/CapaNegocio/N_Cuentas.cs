using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Cuentas
    {
        D_Cuentas objCuentas = new D_Cuentas();

        public int CuentaExistente(string usuario, string contra)
        {
            return objCuentas.CuentaExiste(usuario, contra);
        }

        public List<E_Empleados>BuscarEmpleadoPorCuenta(int numCuenta)
        {
            return objCuentas.ListaDeInformacionEmpleado(numCuenta);
        }

        public void CrearCuenta(string usuario, string contrasena)
        {
            objCuentas.CrearCuenta(usuario, contrasena);
        }

        public void EditarCuenta(int numeroCuenta,string usuario,string contrasena)
        {
            objCuentas.EditarCuenta(numeroCuenta,usuario, contrasena);
        }

        public List<E_Cuentas> BuscarCuentaUsuario(int numcuenta)
        {
            return objCuentas.CuentaDeUsuario(numcuenta);
        }
    }
}
