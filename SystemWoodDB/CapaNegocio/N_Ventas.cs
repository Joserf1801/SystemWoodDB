using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
   public class N_Ventas
    {
        D_Ventas ObjVentas = new D_Ventas();
        public int GetUltimaVentaRealizada()
        {
            return ObjVentas.GetUltimaVenta();
        }
        public void AgregarVenta (E_Ventas Ventas)
        {
            ObjVentas.InsertarVenta(Ventas);
        }

        public void AgregarDetalleVenta(E_DetallesVenta ED)
        {
            ObjVentas.InsertarDetalleVenta(ED);
        }

        public void RestarStock(int cantidad, int clavePro, string medidas)
        {
            ObjVentas.RestarStockAlProducto(cantidad, clavePro, medidas);
        }
        
        public DataTable TodasLasVentas()
        {
            return ObjVentas.TodasLasVentas();
        }

        public DataTable VentasDelDia(string Fecha)
        {
            return ObjVentas.VentasDelDia(Fecha);
        }

        public DataTable MostrarDetalleVenta(string NumVenta)
        {
            return ObjVentas.BuscarDetalleVenta(NumVenta);
        }

        public DataTable BuscarFechaPorRango(string FechaInicial, string FechaFinal)
        {
            return ObjVentas.BuscarVentaPorRango(FechaInicial, FechaFinal);
        }
        public DataTable BuscarVentaXCodigo(int numventa)
        {
            return ObjVentas.BuscarVentasXCodigo(numventa);
        }

        public DataTable ReporteDeVentasInfo(string F1, string F2)
        {
            return ObjVentas.ReporteDeVentasInfo(F1, F2);
        }

        public double TotalDeVentasAldía(string fecha)
        {
            return ObjVentas.TotalVentasAldia(fecha);
        }
        public int CantidadDeventasAldia(string fecha)
        {
            return ObjVentas.NumTotalVentasAldia(fecha);
        }

    }
}
