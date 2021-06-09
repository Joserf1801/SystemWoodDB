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
    public partial class LoginForm : Form
    {
        private bool ContraVisible;
        
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            ContraVisible = false;
            lb_Mensaje.Visible = false;

            
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_VerContra_Click(object sender, EventArgs e)
        {
            if (ContraVisible==false)
            {
                textBox2.UseSystemPasswordChar = false;
                ContraVisible = true;
            }else
            {
                textBox2.UseSystemPasswordChar = true;
                ContraVisible = false;
            }   
        }

        private void btn_Logearse_Click(object sender, EventArgs e)
        {
            lb_Mensaje.Visible = false;

            
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El campo Usuario se encuentra vacio, favor de llenarlo", "Usuario Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(String.IsNullOrEmpty(textBox2.Text)){

                MessageBox.Show("El campo Contraseña se encuentra vacio, favor de llenarlo", "Contraseña Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {                
               VerficarCuenta(textBox1.Text, textBox2.Text);
                //MessageBox.Show(CacheUsuario.NombreEmpleado1 + CacheUsuario.ApellidosEmpleado1 + CacheUsuario.Calle_Empleado1 + CacheUsuario.Colonia_Empleado1 + CacheUsuario.Municipio_Empleado1 +
                //    CacheUsuario.CP_Empleado1 + CacheUsuario.TelefonoCasa_Empleado1 + CacheUsuario.Celular_Empleado1 + CacheUsuario.RFC_Empleado1);
            }
            
        }

        public void VerficarCuenta(string usuario, string contra)
        {
            N_Cuentas objNegocio = new N_Cuentas();
            CacheUsuario.NumCuenta = objNegocio.CuentaExistente(usuario, contra).ToString();
            if(CacheUsuario.NumCuenta == "0")
            {                
                limpiar();
                lb_Mensaje.Visible = true;
            }else
            {
                
                limpiar();
                GuardarDatos(int.Parse(CacheUsuario.NumCuenta));
                this.Hide();
                FormProgreso P = new FormProgreso();
                P.Show();
                
            }
        }

        public void GuardarDatos(int num)
        {
            N_Cuentas c = new N_Cuentas();
            if (c.BuscarEmpleadoPorCuenta(num) != null)
            {
                dataGridView1.DataSource = c.BuscarEmpleadoPorCuenta(num);
                CacheUsuario.ClaveEmpleado = dataGridView1.Rows[0].Cells[0].Value.ToString();
                CacheUsuario.CodigoEmpleado1 = dataGridView1.Rows[0].Cells[1].Value.ToString();
                CacheUsuario.NombreEmpleado1 = dataGridView1.Rows[0].Cells[2].Value.ToString();
                CacheUsuario.ApellidosEmpleado1 = dataGridView1.Rows[0].Cells[3].Value.ToString();
                CacheUsuario.Calle_Empleado1 = dataGridView1.Rows[0].Cells[4].Value.ToString();
                CacheUsuario.Colonia_Empleado1 = dataGridView1.Rows[0].Cells[5].Value.ToString();
                CacheUsuario.Municipio_Empleado1 = dataGridView1.Rows[0].Cells[6].Value.ToString();
                CacheUsuario.CP_Empleado1 = dataGridView1.Rows[0].Cells[7].Value.ToString();
                CacheUsuario.TelefonoCasa_Empleado1 = dataGridView1.Rows[0].Cells[8].Value.ToString();
                CacheUsuario.Celular_Empleado1 = dataGridView1.Rows[0].Cells[9].Value.ToString();
                CacheUsuario.RFC_Empleado1 = dataGridView1.Rows[0].Cells[10].Value.ToString();

                List<E_Cuentas> ListCuenta = c.BuscarCuentaUsuario(num);
                CacheUsuario.Usuario_Empleado1 = ListCuenta[0].Usuario1;
                CacheUsuario.Contra_Empleado = ListCuenta[0].Password;

            }
            
        }

        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            lb_Mensaje.Visible = false;
            textBox1.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                lb_Mensaje.Visible = false;


                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("El campo Usuario se encuentra vacio, favor de llenarlo", "Usuario Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (String.IsNullOrEmpty(textBox2.Text))
                {

                    MessageBox.Show("El campo Contraseña se encuentra vacio, favor de llenarlo", "Contraseña Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    VerficarCuenta(textBox1.Text, textBox2.Text);
                }
            }
        }
    }
}
