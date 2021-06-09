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
    public partial class FormProgreso : Form
    {
        public FormProgreso()
        {
            InitializeComponent();
        }

        private void timer1_Mostrar_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            bunifuCircleProgressbar1.Value+=1;
            if (bunifuCircleProgressbar1.Value <50)
            {
                lb_Mensaje.Text = "Estamos preparando todo un momento";
            }else if (bunifuCircleProgressbar1.Value < 75)
            {
                lb_Mensaje.Text = "Cargando Componentes...";
            }
            else if (bunifuCircleProgressbar1.Value < 90)
            {
                lb_Mensaje.Text = "Iniciando...";
            }
            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1_Mostrar.Stop();
                timer_Desvanecer.Start();
            }
        }

        private void timer_Desvanecer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer_Desvanecer.Stop();
                this.Hide();
                FormularioPrincipal FP = new FormularioPrincipal();
                FP.Show();

            }
        }

        private void FormProgreso_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1_Mostrar.Start();
            lb_usuario.Text = CacheUsuario.NombreEmpleado1 + " " + CacheUsuario.ApellidosEmpleado1;
        }
    }
}
