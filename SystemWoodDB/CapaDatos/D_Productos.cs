using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
   public  class D_Productos
   {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<string> ListarCodigosDeProductos()
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_TodosCodigosProductos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            LeerFilas = cmd.ExecuteReader();

            List<string> ListaCodigos = new List<string>();
            while (LeerFilas.Read())
            {
                ListaCodigos.Add(LeerFilas.GetString(0));
            }

            conexion.Close();
            LeerFilas.Close();

            return ListaCodigos;
        }

        public List<string> ListarMedidasDeProductos(int clave)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_MedidasXClaveProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Clave", clave);            
            LeerFilas = cmd.ExecuteReader();

            List<string> ListaCodigos = new List<string>();
            while (LeerFilas.Read())
            {
                ListaCodigos.Add(LeerFilas.GetString(0));
            }

            conexion.Close();
            LeerFilas.Close();

            return ListaCodigos;
        }

        public int GetClaveXCodigo(string codigo)
        {
            int clave=0;
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_ObtenerClaveXCodigo",conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@codigo", codigo);
            LeerFilas = cmd.ExecuteReader();

            while (LeerFilas.Read())
            {
                clave = LeerFilas.GetInt32(0);
            }
            conexion.Close();
            LeerFilas.Close();

            return clave;
        }

        public double GetPrecioProducto(int clave, string medida)
        {
            double precio=0.00;
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_PrecioXMedidas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@clave", clave);
            cmd.Parameters.AddWithValue("@medidas", medida);
            LeerFilas = cmd.ExecuteReader();

            
            while (LeerFilas.Read())
            {
                precio = double.Parse(LeerFilas.GetDecimal(0).ToString());
            }
            conexion.Close();
            LeerFilas.Close();

            return precio;
        }

        public List<E_Productos> buscarProducto(string codigo)
        {
            
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", codigo);
            LeerFilas = cmd.ExecuteReader();
            List<E_Productos> ListaDeProductos = new List<E_Productos>();

            while (LeerFilas.Read())
            {
                ListaDeProductos.Add(new E_Productos
                {
                    Clave_Producto1 = LeerFilas.GetInt32(0),
                    Codigo_Producto1 = codigo,
                    Nombre_Producto1 = LeerFilas.GetString(2),
                    Descripcion_Producto1 = LeerFilas.GetString(3)

                });
            }
            conexion.Close();
            LeerFilas.Close();

            return ListaDeProductos;
        }

        public List<E_Medidas> MedidasPrecioCantidadProducto(int clave)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BuscarMedidas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@claveProducto", clave);
            LeerFilas = cmd.ExecuteReader();
            List<E_Medidas> ListaDeMedidas = new List<E_Medidas>();

            while (LeerFilas.Read())
            {
                ListaDeMedidas.Add(new E_Medidas
                {
                    Clave_Producto1 = LeerFilas.GetInt32(0),
                    Medida_Producto1 = LeerFilas.GetString(1),
                    Precio_Producto1 = double.Parse(LeerFilas.GetDecimal(2).ToString()),
                    Stock_Producto1 = LeerFilas.GetInt32(3)     

                });
            }
            conexion.Close();
            LeerFilas.Close();

            return ListaDeMedidas;
        }

    }
}
