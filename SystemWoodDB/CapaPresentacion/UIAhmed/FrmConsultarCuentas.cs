using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmConsultarCuentas : Form
    {

        public FrmConsultarCuentas()
        {
            InitializeComponent();
        }

        private void tablaCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultarCuentas_Load(object sender, EventArgs e)
        {
            Mostrar("");
        }

        public void Mostrar(string buscar)
        {
            N_Empleado n_Empleado = new N_Empleado();
            tablaCuentas.DataSource = n_Empleado.ListarEmpleado(buscar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Mostrar(TxtBuscar.Text);
        }

        private void btNuevoEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
