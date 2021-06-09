using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCosultarProductos : Form
    {
        public FrmCosultarProductos()
        {
            InitializeComponent();
        }

        private void BontonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        public void SeleccionandoBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            sender.selected = true;
        }
            public void seguirBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            Flecha.Top = sender.Top;

        }

        private void BtnBuscarPorCodigo_Click(object sender, EventArgs e)
        {
       
            seguirBoton((Bunifu.Framework.UI.BunifuFlatButton )sender);

            AbrirFormularioHijo(new FrmConsultaPorCodigo());

        }

        private void BtnBuscarPorClasificacion_Click(object sender, EventArgs e)
        {
            seguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);


            AbrirFormularioHijo(new FrmCategoriaProductos());
        }

        private void BtnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            seguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            
            AbrirFormularioHijo(new FrmConsultarPorNombre());

        }

      
        private void AbrirFormularioHijo(object formHijo)
        {
            if (this.Wraper.Controls.Count > 0)
                this.Wraper.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Wraper.Controls.Add(fh);
            this.Wraper.Tag = fh;
            fh.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            AbrirFormularioHijo(new FrmNuevosProductos());

        }
    }
}
