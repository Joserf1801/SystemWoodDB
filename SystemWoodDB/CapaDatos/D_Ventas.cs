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
    public class D_Ventas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public int GetUltimaVenta()
        {
            int ultimaVenta = 0;
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_GetNumeroDeVentaFinal", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            LeerFilas = cmd.ExecuteReader();
            while (LeerFilas.Read())
            {
                ultimaVenta = LeerFilas.GetInt32(0);
            }
            conexion.Close();
            LeerFilas.Close();
            return ultimaVenta;
        }

        public void InsertarVenta(E_Ventas objVentas)
        {
            SqlCommand cmd = new SqlCommand("SP_AgregarVenta",conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Clave_Empleado", objVentas.Clave_Empleado1);
            cmd.Parameters.AddWithValue("@Total",objVentas.Total_Venta1);
            cmd.Parameters.AddWithValue("@Fecha",objVentas.Fecha_Venta);
            cmd.Parameters.AddWithValue("@Hora", objVentas.Hora_Venta1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void InsertarDetalleVenta(E_DetallesVenta objED)
        {
            SqlCommand cmd = new SqlCommand("SP_AgregarDetallesVenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NumVenta", objED.Numero_Venta1);
            cmd.Parameters.AddWithValue("@clavePro", objED.Clave_Producto1);
            cmd.Parameters.AddWithValue("@Cantidad", objED.Cantidad_Venta1);
            cmd.Parameters.AddWithValue("@Medidas", objED.Medidas_Venta1);
            cmd.Parameters.AddWithValue("@Subtotal", objED.Subtotal_Venta1);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void RestarStockAlProducto(int cantidad, int clavePro, string Medidas)
        {
            SqlCommand cmd = new SqlCommand("SP_RestarStock", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@ClavePro",clavePro);
            cmd.Parameters.AddWithValue("@Medidas",Medidas);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable TodasLasVentas()
        {
            DataTable Tabla = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_BuscarVenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            Tabla.Load(readRows);

            readRows.Close();
            conexion.Close();
            return Tabla;
        }

        public DataTable VentasDelDia(string Fecha)
        {
            DataTable Tabla = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_BuscarVentaPorFecha", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Fecha",Fecha);
            
            readRows = cmd.ExecuteReader();
            Tabla.Load(readRows);    
            

            readRows.Close();
            conexion.Close();
            return Tabla;
        }

        public DataTable BuscarDetalleVenta(string NumVenta)
        {
            DataTable Tabla = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_BuscarDetalleVenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", NumVenta);

            readRows = cmd.ExecuteReader();
            Tabla.Load(readRows);


            readRows.Close();
            conexion.Close();
            return Tabla;
        }

        public DataTable BuscarVentaPorRango(string FechaI,string FechaF)
        {
            DataTable Tabla = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_BuscarFechaPorRango", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@FechaInicio", FechaI);
            cmd.Parameters.AddWithValue("@FechaFinal", FechaF);

            readRows = cmd.ExecuteReader();
            Tabla.Load(readRows);


            readRows.Close();
            conexion.Close();
            return Tabla;
        }

        public DataTable BuscarVentasXCodigo(int NumVenta)
        {
            DataTable Tabla = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_BuscarVenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Buscar", NumVenta);
            

            readRows = cmd.ExecuteReader();
            Tabla.Load(readRows);


            readRows.Close();
            conexion.Close();
            return Tabla;
        }

        public double TotalVentasAldia(string fecha)
        {
            double total = 0.00;
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_TOTALDEVENTASDELDIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Fecha", fecha);
            LeerFilas = cmd.ExecuteReader();
            while (LeerFilas.Read())
            {   
                    total = double.Parse(LeerFilas.GetDecimal(0).ToString());               
                
            }
            conexion.Close();
            LeerFilas.Close();
            return total;
        }

        public int NumTotalVentasAldia(string fecha)
        {
            int total = 0;
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_NUMDEVENTASDELDIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Fecha", fecha);
            LeerFilas = cmd.ExecuteReader();
            while (LeerFilas.Read())
            {
                total = LeerFilas.GetInt32(0);
            }
            conexion.Close();
            LeerFilas.Close();
            return total;
        }

        public DataTable ReporteDeVentasInfo(string fechaI, string fechaF)
        {
            DataTable Tabla = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_ReporteVenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@FechaI", fechaI);
            cmd.Parameters.AddWithValue("@FechaF", fechaF);


            readRows = cmd.ExecuteReader();
            Tabla.Load(readRows);


            readRows.Close();
            conexion.Close();
            return Tabla;
        }
    }
}
