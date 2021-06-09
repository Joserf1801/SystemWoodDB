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
    public  partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            InicializarBotones();
            AbrirFormularioHijo(new FormularioVentas());
        }

        public void PantallaCompleta()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

       
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            PantallaCompleta();
            btn_Ventas.Normalcolor = Color.IndianRed;
        }

        #region botenes del menú;
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void InicializarBotones()
        {
            panelSubMenu1.Visible = false;
            btn_MiCuenta.Text = CacheUsuario.NombreEmpleado1 + " " + CacheUsuario.ApellidosEmpleado1;
        }

        private void EsconderSubMenu()
        {
            if (panelSubMenu1.Visible == true)
            {
                panelSubMenu1.Visible = false;
            }
            if (panelSubMenu2.Visible == true)
            {
                panelSubMenu2.Visible = false;
            }
                
        }

        private void MostrarSubMenu( Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }  
        }

        private void btn_MiCuenta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu1);
        }

        #endregion;

        private void HoraYFecha_Tick(object sender, EventArgs e)
        {
            FechaYHora.Hora1= DateTime.Now.ToShortTimeString();
            FechaYHora.Fecha= DateTime.Now.ToShortDateString();

            lbHora.Text = FechaYHora.Hora1;
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_MiCuenta_Load(object sender, EventArgs e)
        {
            EnclarecerFormulario.ShowAsyc(this);
        }

        public void AbrirFormularioHijo(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu2);
        }


        private void CambioDeColores(Bunifu.Framework.UI.BunifuFlatButton btn)
        {
            if(btn.Normalcolor == Color.IndianRed)
            {
                btn.Normalcolor = Color.Brown;
            }else if(btn.Normalcolor == Color.Brown)
            {
                btn.Normalcolor = Color.IndianRed;
            }
        }

        private void btn_VerPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmEditarPerfil());

        }

        private void btn_ConsultarCuentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmConsultarCuentas());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormularioVentas());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormReporteVentas());
        }
    }
}
