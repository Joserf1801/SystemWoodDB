using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmEmpleado : Form
    {
        private bool _contraVisible = false;

        private E_Empleados _obEntidad = new E_Empleados();
        private E_Cuentas _obEntidadCuenta = new E_Cuentas();

        private N_Empleado _obNegocio = new N_Empleado();
        private N_Cuentas _obNegocioCuenta = new N_Cuentas();

        public FrmEmpleado()
        {
            InitializeComponent();
            rdbEmpleado.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            FormularioPrincipal formularioPrincipal = new FormularioPrincipal();
            formularioPrincipal.Show();
            this.Close();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (VerificarCuadrosBlanco())
            {
                MessageBox.Show("Ingrese la informacion faltante en los cuadros faltantes");
            }
            else
            {
                if (validarContrasena(TxtContrasenaConfirmar.Text, TxtContrasena.Text))
                {
                        RegistrarEmpleado();
                }
                else
                {
                    MessageBox.Show("La contrasena no coincide, Verifique que la contrasena coincida", "Error de contrasena");
                }
            }             
        }

        public void RegistrarEmpleado()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("CREAR CUENTA", "Quiere crear su cuenta?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                //Primero la creacion de la cuenta
                string usuario = TxtUsuario.Text;
                string contrasena = TxtContrasena.Text;

                 //Metodo Crear cuenta
                 _obNegocioCuenta.CrearCuenta(usuario, contrasena);

                    //Obtiene el numero de cuenta para el respectivo empleado
                    int numeroCuenta = _obNegocio.ObtenerNumeroCuenta();
                    if (numeroCuenta != 0)
                    {
                        //Segundo el registro de los datos del empleado
                        string nombre = TxtNombre.Text;
                        string apellidos = TxtApellidos.Text;
                        string calle = TxtCalle.Text;
                        string colonia = TxtColonia.Text;
                        string municipio = TxtMunicipio.Text;
                        string CP = TxtCP.Text;
                        string telefono = TxtTelefono.Text;
                        string celular = TxtCelular.Text;
                        string RFC = TxtRFC.Text.ToUpper();

                        _obNegocio.InsertarEmpleado(nombre, apellidos, calle, colonia, municipio, CP, telefono, celular, RFC, numeroCuenta);
                        MessageBox.Show("Se guardo el registro correctamente");
                        LimpiarTxtBox();
                    }

                    int claveEmp = _obNegocio.ObtenerClaveEmpleado();
                    if (claveEmp != 0)
                    {
                        if (rdbJefe.Checked)
                        {
                            _obNegocio.PinJefe(claveEmp, "45678");
                        }
                        if (rdbEmpleado.Checked)
                        {
                            _obNegocio.PinEmpleado(claveEmp, "34789");
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void LimpiarTxtBox()
        {
            TxtNombre.Clear();
            TxtApellidos.Clear();
            TxtCalle.Clear();
            TxtColonia.Clear();
            TxtMunicipio.Clear();
            TxtCP.Clear();
            TxtTelefono.Clear();
            TxtCelular.Clear();
            TxtRFC.Clear();
            TxtUsuario.Clear();
            TxtContrasena.Clear();
            TxtContrasenaConfirmar.Clear();
        }

        public bool VerificarCuadrosBlanco()
        {
            if(TxtNombre.Text.Equals("") || TxtApellidos.Text.Equals("") || TxtCalle.Text.Equals("") || TxtColonia.Text.Equals("") || TxtMunicipio.Text.Equals("")
                || TxtCP.Text.Equals("") || TxtTelefono.Text.Equals("") || TxtCelular.Text.Equals("") || TxtContrasena.Text.Equals("") || TxtContrasena.Text.Equals(""))
            {               
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validarContrasena(string confirmarContra,string contrasena)
        {
            if (confirmarContra.Equals(contrasena))
            {
                return true;
            }
            else
            {            
                return false;
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            TxtUsuario.Text = "SWE" + TxtNombre.Text;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (_contraVisible)
            {
                TxtContrasena.UseSystemPasswordChar = false;
                TxtContrasenaConfirmar.UseSystemPasswordChar = false;
                _contraVisible = false;
            }
            else
            {
                TxtContrasena.UseSystemPasswordChar = true;
                TxtContrasenaConfirmar.UseSystemPasswordChar = true;
                _contraVisible = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void TxtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtNumeroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
