using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormReporteVentas2 : Form
    {
        public string Fecha1;
        public string Fecha2;
        public FormReporteVentas2()
        {
            InitializeComponent();
            InicialiarTiempo();
            
            
        }

        private void FormReporteVentas2_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(dateTimePicker1.Text + " " + dateTimePicker2.Text);
            MostrarVentas(dateTimePicker1.Text, dateTimePicker2.Text);
            DisenoData();
        }

        public void DisenoData()
        {
            dgv_Detalle.Columns[0].Width = 60;
            dgv_Detalle.Columns[1].Width = 80;
            dgv_Detalle.Columns[2].Width = 90;
            dgv_Detalle.Columns[3].Width = 90;
            dgv_Detalle.Columns[4].Width = 200;
            dgv_Detalle.Columns[5].Width = 90;
            dgv_Detalle.Columns[6].Width = 90;
            dgv_Detalle.Columns[7].Width = 90;
            dgv_Detalle.Columns[8].Width = 90;
        }

        public void InicialiarTiempo()
        {
            double fechaInicial = -30;
            dateTimePicker1.Value = DateTime.Today.AddDays(fechaInicial);
        }

        public void MostrarVentas( string fecha1, string fecha2)
        {
            N_Ventas NV = new N_Ventas();
            dgv_Detalle.DataSource = NV.ReporteDeVentasInfo(fecha1,fecha2);            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MostrarVentas(dateTimePicker1.Text, dateTimePicker2.Text);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MostrarVentas(dateTimePicker2.Text, dateTimePicker1.Text);
        }

        public void InvertirDiaYMes()
        {

        }

        private void btn_ReporteVentas_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets[1];
            worksheet.Name = "Reporte de ventas";
            MessageBox.Show("Espere unos segundos se esta generando el archivo Excel ...", "Creando Excel", MessageBoxButtons.OK);
            //Cabecera
            for (int i = 1; i < dgv_Detalle.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv_Detalle.Columns[i - 1].HeaderText;
            }

            //Celdas
            for (int i = 0; i < dgv_Detalle.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_Detalle.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv_Detalle.Rows[i].Cells[j].Value.ToString();
                }
            }

            app.Visible = true;
        }
    }
}
