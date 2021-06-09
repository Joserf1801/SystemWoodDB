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

namespace CapaPresentacion
{
    public partial class FormReporteVentas : Form
    {
        Point inicial;
        public double ventasDelDía = 5000.00;
       

        public FormReporteVentas()
        {
            InitializeComponent();
            MostrarTodasLasVentas();
            InitializeComponent2();
            MostrarNumerototalVentas();
        }
        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            DisenoDelDGV_Ventas();
            timerVentasDia.Start();
        }
        public void InitializeComponent2()
        {
            inicial = new Point(btn_Buscar.Location.X, btn_Buscar.Location.Y);
            RB_NumVenta.Checked = true;
            RB_Fecha.Checked = false;         

        }

        public void DisenoDelDGV_Ventas()
        {

            dgv_Ventas.Columns[2].Visible = false;

            dgv_Ventas.Columns[0].Width = 80;
            dgv_Ventas.Columns[1].Width = 80;
            dgv_Ventas.Columns[3].Width = 100;
            dgv_Ventas.Columns[4].Width = 80;
            dgv_Ventas.Columns[5].Width = 90 ;
            dgv_Ventas.Columns[6].Width = 90;
            dgv_Ventas.Columns[7].Width = 200;

            dgv_Ventas.Columns[0].DisplayIndex = 7;
        }
        public void DisenoDelDGV_Detalles()
        {
            dgv_Detalle.Columns[0].Width = 80;
            dgv_Detalle.Columns[1].Width = 100;
            dgv_Detalle.Columns[2].Width = 200;
            dgv_Detalle.Columns[3].Width = 90;
            dgv_Detalle.Columns[4].Width = 100;
            dgv_Detalle.Columns[5].Width = 100;

        }

        public void MostrarTodasLasVentas()
        {
            N_Ventas NV = new N_Ventas();
            dgv_Ventas.DataSource = NV.VentasDelDia(FechaYHora.Fecha);
        }

        public void Instanciar()
        {
            FormularioVentas FVentas = new FormularioVentas();
            FVentas.ShowDialog();
            
        }

        #region Radio Buttons
        public void ActivarBusquedaPorNumero(bool estado)
        {
            if (estado)
            {
                lb_Buscar.Text = "Buscar:";
                txt_Buscar.Visible = estado;
            }
            else
            {
                txt_Buscar.Visible = estado;
            }
            
        }
        public void ActivarBusquedaPorFecha(bool estado)
        {
            
            lb_Buscar.Text = "   De:";
            if (estado)
            {
                DTP_Inicio.Visible = true;
                DTP_Destino.Visible = true;
                label_A.Visible = true;

                DTP_Inicio.Location = txt_Buscar.Location;
                label_A.Location = new Point(DTP_Inicio.Location.X + 150, DTP_Inicio.Location.Y+4);
                DTP_Destino.Location = new Point(label_A.Location.X + 30, DTP_Inicio.Location.Y);
                btn_Buscar.Location = new Point(DTP_Destino.Location.X + 150, btn_Buscar.Location.Y);
            }
            else
            {
                DTP_Inicio.Visible = false;
                DTP_Destino.Visible = false;
                label_A.Visible = false;
                btn_Buscar.Location = inicial;
            }
        }       
        private void RB_NumVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_NumVenta.Checked)
            {
                RB_Fecha.Checked = false;
                ActivarBusquedaPorNumero(true);
                ActivarBusquedaPorFecha(false);
            }
        }
        private void RB_Fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Fecha.Checked)
            {
                RB_NumVenta.Checked = false;
                ActivarBusquedaPorNumero(false);
                ActivarBusquedaPorFecha(true);
            }
        }

        #endregion

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Limpiar();
           
            if (RB_Fecha.Checked)
            {
                string FechaI = DTP_Inicio.Text;
                string FechaD = DTP_Destino.Text;
                N_Ventas NV = new N_Ventas();
                dgv_Ventas.DataSource = NV.BuscarFechaPorRango(FechaI, FechaD);
            }else if (RB_NumVenta.Checked && txt_Buscar.Text!="")
            {
                int cod = int.Parse(txt_Buscar.Text);
                N_Ventas NV = new N_Ventas();
                dgv_Ventas.DataSource = NV.BuscarVentaXCodigo(cod);
            }else if (RB_NumVenta.Checked && txt_Buscar.Text == "")
            {
                N_Ventas NV = new N_Ventas();
                dgv_Ventas.DataSource = NV.VentasDelDia(FechaYHora.Fecha);
            }
        }

        #region DataGridView Ventas del dia
        private void dgv_Ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Ventas.Rows[e.RowIndex].Cells["VerDetalle"].Selected)
            {
                N_Ventas NV = new N_Ventas();
                string numventa= dgv_Ventas.Rows[e.RowIndex].Cells[1].Value.ToString();
                dgv_Detalle.DataSource = NV.MostrarDetalleVenta(numventa);
                DisenoDelDGV_Detalles();
            }
        }

        #endregion

        #region BarraDeProgreso

        private void timerVentasDia_Tick(object sender, EventArgs e)
        {
            N_Ventas NV = new N_Ventas();
            if (NV.CantidadDeventasAldia(FechaYHora.Fecha) != 0)
            {
                double total = (NV.TotalDeVentasAldía(FechaYHora.Fecha) * 100) / ventasDelDía;
                lb_Meta.Text = "$" + NV.TotalDeVentasAldía(FechaYHora.Fecha).ToString() + " de $" + ventasDelDía.ToString();


                if (BarraDeProgresoVentasDelDía.Value < total)
                {
                    if (BarraDeProgresoVentasDelDía.Value < 100)
                    {
                        BarraDeProgresoVentasDelDía.Value += 1;
                    }

                }
            }else
            {
                lb_Meta.Text = "$0.00 de $" + ventasDelDía.ToString();
            }
           
        }

        private void MostrarNumerototalVentas()
        {
            N_Ventas NV = new N_Ventas();
            lb_totalVentas.Text = NV.CantidadDeventasAldia(FechaYHora.Fecha).ToString();
        }
        #endregion

        private void btn_ReporteVentas_Click(object sender, EventArgs e)
        {   
            FormReporteVentas2 Reporte2 = new FormReporteVentas2();
            Reporte2.ShowDialog();
        }

        public void Limpiar()
        {
          
            if (RB_Fecha.Checked )
            {
                DTP_Inicio.Focus();

            }else if (RB_NumVenta.Checked)
            {
                txt_Buscar.Focus();
            }            

        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
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

            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Limpiar();
                if (RB_Fecha.Checked)
                {
                    string FechaI = DTP_Inicio.Text;
                    string FechaD = DTP_Destino.Text;
                    N_Ventas NV = new N_Ventas();
                    dgv_Ventas.DataSource = NV.BuscarFechaPorRango(FechaI, FechaD);
                }
                else if (RB_NumVenta.Checked && txt_Buscar.Text != "")
                {
                    int cod = int.Parse(txt_Buscar.Text);
                    N_Ventas NV = new N_Ventas();
                    dgv_Ventas.DataSource = NV.BuscarVentaXCodigo(cod);
                }
                else if (RB_NumVenta.Checked && txt_Buscar.Text == "")
                {
                    N_Ventas NV = new N_Ventas();
                    dgv_Ventas.DataSource = NV.VentasDelDia(FechaYHora.Fecha);
                }
            }
        }
    }
}
