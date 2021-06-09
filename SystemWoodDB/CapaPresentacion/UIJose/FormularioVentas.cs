using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;
using System.Drawing.Printing;

namespace CapaPresentacion
{
    public partial class FormularioVentas : Form
    {
        //Etiquetas
        private int NumArticulos = 0;        
        private double Total = 0.00;

         //Datos Producto
        private int Clave_De_Producto;       
        private bool stockDisponible;
       


        public FormularioVentas()
        {
            InitializeComponent();
            DiseñoData();
            LlenarAutocompletadoText(txt_Articulos);
            MoverMostrarPanelCantidad(false);
        }

        private void FormularioVentas_Load(object sender, EventArgs e)
        {
            lb_Nombre.Text = CacheUsuario.NombreEmpleado1 + " " + CacheUsuario.ApellidosEmpleado1;
            txt_Articulos.Focus();
        }

        #region Sección Datagridview
        public void DiseñoData()
        {
            dgv_Articulos.Font = new Font("Arial", 10, FontStyle.Regular);
            dgv_Articulos.Columns[0].Visible = false;
            dgv_Articulos.Columns[1].Width = 80;
            dgv_Articulos.Columns[2].Width = 200;
            dgv_Articulos.Columns[6].Width = 80;
        }

        public void AgregarDatos(string codigo, string medidas)
        {
            N_Productos NP = new N_Productos();
            List<E_Productos> ListaProducto = NP.GetDatosDelProducto(codigo);
            List<E_Medidas> ListaMedidas = NP.GetMedidasPrecioStockDelProducto(ListaProducto[0].Clave_Producto1);
            double Precio = NP.ObtenerPrecioDeProducto(Clave_De_Producto, medidas);
            string subtotal="0";
            bool repetido = false;
            int cantidad = 1;
            if (dgv_Articulos.RowCount == 0)
            {
                Console.Beep();
                dgv_Articulos.Rows.Add(ListaProducto[0].Clave_Producto1, ListaProducto[0].Codigo_Producto1, ListaProducto[0].Nombre_Producto1, medidas, cantidad, (Precio * cantidad));
            }
            else
            {
                for (int i = 0; i < dgv_Articulos.RowCount; i++)
                {
                    ProductoVenta.ClaveProducto = int.Parse(dgv_Articulos.Rows[i].Cells[0].Value.ToString());
                    ProductoVenta.CodigoProdo =   dgv_Articulos.Rows[i].Cells[1].Value.ToString();
                    ProductoVenta.NombreProducto = dgv_Articulos.Rows[i].Cells[2].Value.ToString();
                    ProductoVenta.MedidasProducto = dgv_Articulos.Rows[i].Cells[3].Value.ToString();
                    ProductoVenta.Cantidad = int.Parse(dgv_Articulos.Rows[i].Cells[4].Value.ToString());
                    ProductoVenta.Subtotal = double.Parse(dgv_Articulos.Rows[i].Cells[5].Value.ToString());
                    if (codigo==ProductoVenta.CodigoProdo && medidas == ProductoVenta.MedidasProducto)
                    {

                        cantidad = ProductoVenta.Cantidad + 1;
                        if (VerificarStock(ListaMedidas, ProductoVenta.ClaveProducto, ProductoVenta.MedidasProducto, cantidad))
                        {
                            subtotal = (cantidad * Precio).ToString();
                            dgv_Articulos.Rows[i].Cells[4].Value = cantidad;
                            dgv_Articulos.Rows[i].Cells[5].Value = subtotal;
                            txt_Articulos.Focus();
                            Console.Beep();
                        }
                        repetido = true;
                    }
                }
                if (repetido==false && VerificarStock(ListaMedidas, ProductoVenta.ClaveProducto, ProductoVenta.MedidasProducto, cantidad) && cantidad==1)
                
                {
                    dgv_Articulos.Rows.Add(ListaProducto[0].Clave_Producto1, ListaProducto[0].Codigo_Producto1, ListaProducto[0].Nombre_Producto1, medidas, cantidad, (Precio * cantidad));
                    Console.Beep();
                    txt_Articulos.Focus();
                }
            }           
            
        }

        public bool VerificarStock(List<E_Medidas> listaMedidas, int clave, string medidas, int cantidad)
        {
            stockDisponible = true;
            for (int i = 0; i < listaMedidas.Count; i++)
            {
                if(listaMedidas[i].Clave_Producto1==clave && listaMedidas[i].Medida_Producto1 == medidas)
                {
                    if (listaMedidas[i].Stock_Producto1 >= cantidad)
                    {
                        stockDisponible = true;
                    }else if(listaMedidas[i].Stock_Producto1 < cantidad)
                    {
                        stockDisponible = false;
                        MessageBox.Show("ERROR: Sobrepaso de la cantidad de existente, este producto solo cuenta con " + listaMedidas[i].Stock_Producto1 + " Unidades", "Cantidad mayor al stock disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }
            }
            return stockDisponible;
        }
        private void dgv_Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Articulos.Rows[e.RowIndex].Cells["Remover"].Selected)
            {
                QuitarProducto(e.RowIndex);
            }
            else if (dgv_Articulos.Rows[e.RowIndex].Cells["Cantidad"].Selected)
            {
                ProductoVenta.IndiceCelda1 = e.RowIndex;
                dgv_Articulos.Enabled = false;
                MoverMostrarPanelCantidad(true);
                txt_Cantidad.Text = dgv_Articulos.Rows[e.RowIndex].Cells[4].Value.ToString();
               

            }
        }
        public void QuitarProducto( int i)
        {
            N_Productos objPro = new N_Productos();            
            int cantidad = 0;
            ProductoVenta.ClaveProducto = int.Parse(dgv_Articulos.Rows[i].Cells[0].Value.ToString());
            ProductoVenta.CodigoProdo = dgv_Articulos.Rows[i].Cells[1].Value.ToString();
            ProductoVenta.NombreProducto = dgv_Articulos.Rows[i].Cells[2].Value.ToString();
            ProductoVenta.MedidasProducto = dgv_Articulos.Rows[i].Cells[3].Value.ToString();
            ProductoVenta.Cantidad = int.Parse(dgv_Articulos.Rows[i].Cells[4].Value.ToString());
            ProductoVenta.Subtotal = double.Parse(dgv_Articulos.Rows[i].Cells[5].Value.ToString());
            cantidad = ProductoVenta.Cantidad;
            double precio = objPro.ObtenerPrecioDeProducto(ProductoVenta.ClaveProducto, ProductoVenta.MedidasProducto);
            if (cantidad > 1)
            {
                cantidad--;
                double subtotal = precio * cantidad;
                dgv_Articulos.Rows[i].Cells[4].Value = cantidad;
                dgv_Articulos.Rows[i].Cells[5].Value = subtotal.ToString();
            }else if (cantidad == 1)
            {
                dgv_Articulos.Rows.RemoveAt(i);
            }
            CalcularTotal();
            CalcularNumeroArticulos();

        }
        #endregion

        #region Panel Cantidad
        public void MoverMostrarPanelCantidad(bool estado)
        {
            if (estado)
            {
                PanelCantidad.Visible = true;
                PanelCantidad.Location = new Point(282, 154);
                txt_Cantidad.Focus();
            }else
            {
                PanelCantidad.Visible = false;
            }
        }

        public void ModificarCantidad(int i, int cantidadNueva)
        {
            N_Productos objPro = new N_Productos();            
            int cantidad = 0;
            ProductoVenta.ClaveProducto = int.Parse(dgv_Articulos.Rows[i].Cells[0].Value.ToString());
            ProductoVenta.CodigoProdo = dgv_Articulos.Rows[i].Cells[1].Value.ToString();
            ProductoVenta.NombreProducto = dgv_Articulos.Rows[i].Cells[2].Value.ToString();
            ProductoVenta.MedidasProducto = dgv_Articulos.Rows[i].Cells[3].Value.ToString();
            ProductoVenta.Cantidad = int.Parse(dgv_Articulos.Rows[i].Cells[4].Value.ToString());
            ProductoVenta.Subtotal = double.Parse(dgv_Articulos.Rows[i].Cells[5].Value.ToString());
            cantidad = cantidadNueva;

            double precio = objPro.ObtenerPrecioDeProducto(ProductoVenta.ClaveProducto, ProductoVenta.MedidasProducto);
            List<E_Medidas> ListaMedidas = objPro.GetMedidasPrecioStockDelProducto(ProductoVenta.ClaveProducto);

            stockDisponible = VerificarStock(ListaMedidas, ProductoVenta.ClaveProducto,ProductoVenta.MedidasProducto, cantidad);
            if (cantidad > 0 && stockDisponible)
            {
                double sub = precio * cantidad;
                dgv_Articulos.Rows[i].Cells[4].Value = cantidad;
                dgv_Articulos.Rows[i].Cells[5].Value = sub.ToString();

            } else if(cantidad < 0)
            {
                MessageBox.Show("ERROR: Cantidad inexistente, No se aceptan numeros negativos", "Cantidad inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Cantidad.Text = "";
                txt_Cantidad.Focus();
            }else if (cantidad == 0)
            {
                dgv_Articulos.Rows.RemoveAt(i);
            }

            CalcularTotal();
            CalcularNumeroArticulos();
           

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (txt_Cantidad.Text.Equals(""))
            {
                MessageBox.Show("No se puede ejecutar la acción porque la casilla de cantidad se encuentra vacía", "Cantidad vacía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Cantidad.Focus();
            }
            else
            {
                ModificarCantidad(ProductoVenta.IndiceCelda1, int.Parse(txt_Cantidad.Text));
                MoverMostrarPanelCantidad(false);
                txt_Cantidad.Text = "0";
                dgv_Articulos.Enabled = true;
            }
        }
        #endregion

        #region Sección Combobox
        public void LlenarAutocompletadoText(TextBox txt)
        {
            N_Productos objPro = new N_Productos();
            List<string> Listainfo = objPro.GetClavesDeProductos();
            AutoCompleteStringCollection Coleccion = new AutoCompleteStringCollection();
            for (int i = 0; i < Listainfo.Count; i++)
            {
                Coleccion.Add(Listainfo[i]);
            }
            txt.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt.AutoCompleteCustomSource = Coleccion;
        }
        public void LlenarComboMedidas(ComboBox cmb, int clave)
        {
            N_Productos objPro = new N_Productos();
            List<string> Listainfo = objPro.GetMedidasProdocto(clave);
            cmb.Items.Clear();
            for (int i = 0; i < Listainfo.Count; i++)
            {
                cmb.Items.Add(Listainfo[i]);
            }
        }
        private void cmb_Articulo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string text = txt_Articulos.Text.ToUpper();
            if (BuscarArticulo(text, cmb_Medidas.Text))
            {
                
                AgregarDatos(text, cmb_Medidas.Text);
                LimpiarArticuloYMedidas();             
                CalcularTotal();
                CalcularNumeroArticulos();
            }else
            {
                MessageBox.Show("ERROR: Los datos ingresados no son correctos verifique que el codigo del producto esta bien escrito o las medidas sean seleccionadas correctamente", "Datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_Medidas.Items.Clear();
                cmb_Medidas.Text = "Seleccione Medidas";
                txt_Articulos.Text = "";
                txt_Articulos.Focus();
            }
            

        }
        private bool BuscarArticulo(string codigo, string medidas)
        {
            bool encontrado = false;
            
            N_Productos NP = new N_Productos();          
            int cod=NP.GetClaveProductoXCodigo(codigo);
            List<string> lista = NP.GetMedidasProdocto(cod);

            if (cod!=0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (medidas == lista[i])
                    {
                        encontrado = true;
                        break;
                    }
                }
            }

            return encontrado;
        }
        private void CalcularTotal()
        {
            Total = 0.00;
            for (int i = 0; i < dgv_Articulos.RowCount; i++)
            {
                int canti = int.Parse(dgv_Articulos.Rows[i].Cells[4].Value.ToString());
                Total += double.Parse(dgv_Articulos.Rows[i].Cells[5].Value.ToString());
            }
            lb_Total.Text = "$ " + Total.ToString();

        }
        private void CalcularNumeroArticulos()
        {
            NumArticulos = 0;
            for (int i = 0; i < dgv_Articulos.RowCount; i++)
            {
                int canti = int.Parse(dgv_Articulos.Rows[i].Cells[4].Value.ToString());
                NumArticulos = NumArticulos + canti;
            }
           lb_Articulos.Text = NumArticulos.ToString() + " Articulo(s)";
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            MoverMostrarPanelCantidad(false);
            txt_Cantidad.Text = "0";
            dgv_Articulos.Enabled = true;
        }
        private void txt_Articulos_TextChanged(object sender, EventArgs e)
        {
            N_Productos NP = new N_Productos();
            string text = txt_Articulos.Text.ToUpper();
            Clave_De_Producto = NP.GetClaveProductoXCodigo(text);            
            if (Clave_De_Producto != 0)
            {
                LlenarComboMedidas(cmb_Medidas, Clave_De_Producto);
                cmb_Medidas.Text = "Seleccione Medidas";
            }
        }
        private void txt_Articulos_Enter(object sender, EventArgs e)
        {
            if(txt_Articulos.Text.Equals("Ingrese codigo de producto"))
            {
                txt_Articulos.Text = "";
                txt_Articulos.ForeColor = Color.Black;
            }
        }
        private void txt_Articulos_Leave(object sender, EventArgs e)
        {
            if (txt_Articulos.Text.Equals(""))
            {
                txt_Articulos.Text = "Ingrese codigo de producto";
                txt_Articulos.ForeColor = Color.DarkGray;
            }
        }
        private void LimpiarArticuloYMedidas()
        {
            txt_Articulos.Text = "";
            cmb_Medidas.Items.Clear();
            cmb_Medidas.Text = "Seleccione Medidas";
            txt_Articulos.Focus();
        }
        private void cmb_Medidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #region botón Realizar Venta       

        private void btn_RealizarVenta_Click(object sender, EventArgs e)
        {
            if (dgv_Articulos.RowCount > 0)
            {
                DialogResult RealizarVenta = MessageBox.Show("Todo listo para realizar la venta ¿Esta seguro de realizar esta acción?", "¿Realizar Venta?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (RealizarVenta == DialogResult.Yes)
                {
                    N_Ventas NV = new N_Ventas();
                    RealizarVentas(NV);
                    RealizarDetalleVenta(NV);
                    MessageBox.Show("Venta realizada correctamente\nImprimiendo ticket......", "Venta Realizada correctamente", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    Imprimir();
                    MessageBox.Show("¡Listo!","Ticket Imprimido", MessageBoxButtons.OK);
                    LimpiarTodo();

                }else
                {
                    MessageBox.Show("No se ha colocado ningun producto en lista", "Imposible realizar venta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    LimpiarArticuloYMedidas();
                }
            }
        }
        private void  RealizarVentas(N_Ventas nv)
        {
            E_Ventas objVentas = new E_Ventas();
            objVentas.Clave_Empleado1 = int.Parse(CacheUsuario.ClaveEmpleado);
            objVentas.Total_Venta1 = Total;            
            objVentas.Hora_Venta1 = FechaYHora.Hora1;
            objVentas.Fecha_Venta = FechaYHora.Fecha;
            nv.AgregarVenta(objVentas);
        }

        private void RealizarDetalleVenta(N_Ventas nv)
        {
            E_DetallesVenta ED = new E_DetallesVenta();
            int NumVenta = nv.GetUltimaVentaRealizada();
            for (int i = 0; i < dgv_Articulos.RowCount; i++)
            {
                ED.Numero_Venta1 = NumVenta;
                ED.Clave_Producto1 =int.Parse(dgv_Articulos.Rows[i].Cells[0].Value.ToString());               
                ED.Medidas_Venta1 = dgv_Articulos.Rows[i].Cells[3].Value.ToString();
                ED.Cantidad_Venta1 = int.Parse(dgv_Articulos.Rows[i].Cells[4].Value.ToString());
                ED.Subtotal_Venta1= dgv_Articulos.Rows[i].Cells[5].Value.ToString();
                nv.RestarStock(ED.Cantidad_Venta1, ED.Clave_Producto1, ED.Medidas_Venta1);
                nv.AgregarDetalleVenta(ED);
            }
           
            
        }

        #endregion
        private void LimpiarTodo()
        {
            dgv_Articulos.Rows.Clear();
            CalcularTotal();
            CalcularNumeroArticulos();
            LimpiarArticuloYMedidas();
        }

        #region Ticket
        private void Imprimir()
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();

            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += ticket;
            printDocument1.Print();
        }
        private void ticket(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int width = 500;
            int y = 20;
            e.Graphics.DrawString("========MADERERIA ATLIXCO=========",font,Brushes.Black, new RectangleF(0,y+=20,width,20));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Usted Compro:\n", font, Brushes.Black, new RectangleF(0, y+=20, width, 20));

            for (int i = 0; i < dgv_Articulos.RowCount; i++)
            {
                string nombre= dgv_Articulos.Rows[i].Cells[2].Value.ToString();
                string cantidad= dgv_Articulos.Rows[i].Cells[4].Value.ToString();
                string subtotal= dgv_Articulos.Rows[i].Cells[5].Value.ToString();
                e.Graphics.DrawString(cantidad + " " + nombre + "................$" + subtotal , font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            }
            e.Graphics.DrawString("---------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("TOTAL: $" + Total, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));

            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("Lo atendio: " + CacheUsuario.NombreEmpleado1 + " " + CacheUsuario.ApellidosEmpleado1, font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString(" ", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));
            e.Graphics.DrawString("        ¡GRACIAS POR SU COMPRA! ", font, Brushes.Black, new RectangleF(0, y += 20, width, 20));

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
        #endregion
        private void btn_CancelarVenta_Click(object sender, EventArgs e)
        {
            if(dgv_Articulos.RowCount > 0)
            {
                DialogResult CancelarVenta = MessageBox.Show("¿Esta seguro de cancelar la venta?", "Cancelar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (CancelarVenta == DialogResult.Yes)
                {
                    LimpiarTodo();
                }
            }
        }

        private void cmb_Medidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string text = txt_Articulos.Text.ToUpper();
                if (BuscarArticulo(text, cmb_Medidas.Text))
                {

                    AgregarDatos(text, cmb_Medidas.Text);
                    LimpiarArticuloYMedidas();
                    CalcularTotal();
                    CalcularNumeroArticulos();
                }
                else
                {
                    MessageBox.Show("ERROR: Los datos ingresados no son correctos verifique que el codigo del producto esta bien escrito o las medidas sean seleccionadas correctamente", "Datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_Medidas.Items.Clear();
                    cmb_Medidas.Text = "Seleccione Medidas";
                    txt_Articulos.Text = "";
                    txt_Articulos.Focus();
                }
            }
        }

        private void btn_Agregar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string text = txt_Articulos.Text.ToUpper();
                if (BuscarArticulo(text, cmb_Medidas.Text))
                {

                    AgregarDatos(text, cmb_Medidas.Text);
                    LimpiarArticuloYMedidas();
                    CalcularTotal();
                    CalcularNumeroArticulos();
                }
                else
                {
                    MessageBox.Show("ERROR: Los datos ingresados no son correctos verifique que el codigo del producto esta bien escrito o las medidas sean seleccionadas correctamente", "Datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_Medidas.Items.Clear();
                    cmb_Medidas.Text = "Seleccione Medidas";
                    txt_Articulos.Text = "";
                    txt_Articulos.Focus();
                }
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txt_Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_VentasDelDia_Click(object sender, EventArgs e)
        {
           
            FormularioPrincipal FP = new FormularioPrincipal();
            FP.Close();           
            FP.Show();
            FP.AbrirFormularioHijo(new FormReporteVentas());
            

        }
    }
}
