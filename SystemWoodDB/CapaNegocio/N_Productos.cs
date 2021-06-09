using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
   public class N_Productos
    {
        D_Productos objProducto = new D_Productos();


        public List<string> GetClavesDeProductos()
        {
            return objProducto.ListarCodigosDeProductos();
        }

        public List<string> GetMedidasProdocto(int clave)
        {
            return objProducto.ListarMedidasDeProductos(clave);
        }

        public int GetClaveProductoXCodigo(string codigo)
        {
            return objProducto.GetClaveXCodigo(codigo);
        }

        public double ObtenerPrecioDeProducto(int clave, string medida)
        {
            return objProducto.GetPrecioProducto(clave, medida);
        }

        public List<E_Productos> GetDatosDelProducto(string codigo)
        {
            return objProducto.buscarProducto(codigo);
        }

        public List<E_Medidas> GetMedidasPrecioStockDelProducto(int clave)
        {
            return objProducto.MedidasPrecioCantidadProducto(clave);
        }
        
    }
}
