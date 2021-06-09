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
    public class D_Empleados
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void InsertarEmpleado(string nombre, string apellidos, string calle, string colonia, string municipio, string CP, string telefono, string celular, string RFC, int numeroCuenta)
        {
            SqlCommand cmd = new SqlCommand("SP_AgregarEmpleado", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre",nombre);
            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
            cmd.Parameters.AddWithValue("@Calle", calle);
            cmd.Parameters.AddWithValue("@Colonia", colonia);
            cmd.Parameters.AddWithValue("@Municipio", municipio);
            cmd.Parameters.AddWithValue("@CP", CP);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@Celular", celular);
            cmd.Parameters.AddWithValue("@RFC", RFC);
            cmd.Parameters.AddWithValue("@NumCuenta", numeroCuenta);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void EditarEmpleado(string clave, string nombre, string apellidos, string calle, string colonia, string municipio, string CP, string telefono, string celular, string RFC, int numeroCuenta)
        {
            SqlCommand cmd = new SqlCommand("SP_ModificarEmpleado", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ClaveEmpleado", clave);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellidos", apellidos);
            cmd.Parameters.AddWithValue("@Calle", calle);
            cmd.Parameters.AddWithValue("@Colonia", colonia);
            cmd.Parameters.AddWithValue("@Municipio", municipio);
            cmd.Parameters.AddWithValue("@CP", CP);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@Celular", celular);
            cmd.Parameters.AddWithValue("@RFC", RFC);
            cmd.Parameters.AddWithValue("@NumCuenta", numeroCuenta);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarEmpleadoYCuenta(E_Cuentas cuenta)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarCuentaYEmpleado", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@numCuenta", cuenta.Numero_Cuenta1);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public int ObtenerUltimaCuenta()
        {
            int numeroCuenta = 0;
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_GetUltimaCuenta", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();         
            LeerFilas = cmd.ExecuteReader();

            while (LeerFilas.Read())
            {
                numeroCuenta = LeerFilas.GetInt32(0);
            }

            LeerFilas.Close();
            cmd.ExecuteNonQuery();          
            conexion.Close();

            return numeroCuenta;
        }

        public int ObtenerUltimaClaveEmpleado()
        {
            int claveEmpleado = 0;
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_ObtenerUltimaClaveEmpleado", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            LeerFilas = cmd.ExecuteReader();

            while (LeerFilas.Read())
            {
                claveEmpleado = LeerFilas.GetInt32(0);
            }

            LeerFilas.Close();
            cmd.ExecuteNonQuery();
            conexion.Close();

            return claveEmpleado;
        }

        public List<E_Empleados> ListarEmpleados (string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_MostrarEmpleados", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            LeerFilas = cmd.ExecuteReader();

            List<E_Empleados> Listar = new List<E_Empleados>();

            while (LeerFilas.Read())
            {
                Listar.Add(new E_Empleados
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

            return Listar;
        }
        
        public void PinEmpleado(int claveEmp, string pin)
        {
            SqlCommand cmd = new SqlCommand("SP_AsignarPuestoTrabajador", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("PIN", claveEmp);
            cmd.Parameters.AddWithValue("@ClaveEmp", pin);
            

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void PinJefe(int claveEmp, string pin)
        {
            SqlCommand cmd = new SqlCommand("SP_AsignarPuestoJefe", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ClaveEmp", pin);
            cmd.Parameters.AddWithValue("PIN", claveEmp);
            

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
