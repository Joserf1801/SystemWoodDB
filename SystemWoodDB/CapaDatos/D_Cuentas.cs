using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class D_Cuentas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);


        //METODO PARA SABER SI LA CUENTA EXISTE
        public int CuentaExiste(string usuario, string contra)
        {
            int existe = 0;
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_ExisteCuenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contra", contra);

            LeerFilas = cmd.ExecuteReader();            
            while (LeerFilas.Read())
            {
                existe = LeerFilas.GetInt32(0);
            }
            conexion.Close();
            LeerFilas.Close();
            return existe;
        }
        //METODO PARA OBTENER LA INFORMACIÓN DEL EMPLEADO QUE ACCEDIO
        public List<E_Empleados> ListaDeInformacionEmpleado(int numCuenta)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_InfomacionDeUsuarioPorCuenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@numCuenta", numCuenta);
            LeerFilas = cmd.ExecuteReader();

            List<E_Empleados> ListarEmpleado = new List<E_Empleados>();
            while (LeerFilas.Read())
            {
                ListarEmpleado.Add(new E_Empleados
                {
                    Clave_Empleado1 = LeerFilas.GetInt32(0),
                    Codigo_Empleado1 = LeerFilas.GetString(1),
                    Nombre_Empleado1 = LeerFilas.GetString(2),
                    Apellidos_Empleado1 = LeerFilas.GetString(3),
                    Calle_Empleado1 = LeerFilas.GetString(4),
                    Colonia_Empleado1 = LeerFilas.GetString(5),
                    Municipio_Empleado1 = LeerFilas.GetString(6),
                    CP_Empleado1 = LeerFilas.GetString(7),
                    Telefono_Empleado1 = LeerFilas.GetString(8),
                    Celular_Empleado1 = LeerFilas.GetString(9),
                    RFC_Empleado1 = LeerFilas.GetString(10),
                    Numero_Cuenta1 = LeerFilas.GetInt32(11)

                });
            }
            
            conexion.Close();
            LeerFilas.Close();

            return ListarEmpleado;
        }

        public void EditarCuenta(int numeroCuenta,string usuario, string contrasena)
        {
            SqlCommand cmd = new SqlCommand("SP_ModificarCuenta", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NumCuenta", numeroCuenta);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contra", contrasena);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CrearCuenta(string usuario, string contrasena)
        {
            SqlCommand cmd = new SqlCommand("SP_CrearCuenta", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@contra", contrasena);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public List<E_Cuentas> CuentaDeUsuario(int numCuenta)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarCuenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NumCuenta", numCuenta);
            LeerFilas = cmd.ExecuteReader();

            List<E_Cuentas> ListarCuenta = new List<E_Cuentas>();
            while (LeerFilas.Read())
            {
                ListarCuenta.Add(new E_Cuentas
                {
                    Numero_Cuenta1 = numCuenta,
                    Usuario1 = LeerFilas.GetString(1),
                    Password = LeerFilas.GetString(2)

                });
            }

            conexion.Close();
            LeerFilas.Close();

            return ListarCuenta;
        }

    }
}
