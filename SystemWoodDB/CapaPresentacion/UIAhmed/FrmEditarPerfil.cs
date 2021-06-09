using CapaEntidades;
using CapaNegocio;
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
    public partial class FrmEditarPerfil : Form
    {

        private bool _contraVisible = false;

        N_Empleado _N_Empleado = new N_Empleado();
        N_Cuentas _N_Cuenta = new N_Cuentas();

        E_Empleados _obEntidad = new E_Empleados();

        public FrmEditarPerfil()
        {
            InitializeComponent();
            checkBoxEditarPerfil.Checked = false;
            checkBoxUsuario.Checked = false;
            EditarDatosUsuario();
            EditarDatosPersonales();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            if (_contraVisible)
            {
                TxtContrasena.UseSystemPasswordChar = false;
                TxtConfirmarContra.UseSystemPasswordChar = false;
                TxtNuevaContra.UseSystemPasswordChar = false;
                _contraVisible = false;
            }
            else
            {
                TxtContrasena.UseSystemPasswordChar = true;
                TxtConfirmarContra.UseSystemPasswordChar = true;
                TxtNuevaContra.UseSystemPasswordChar = true;
                _contraVisible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void EditarDatosPersonales()
        {
            if (checkBoxEditarPerfil.Checked)
            {
                HabilitarCuadrosDatos(true);
            }
            else
            {
                HabilitarCuadrosDatos(false);
                ActualizarInformacionUI();
            }
        }

        public void EditarDatosUsuario()
        {
            if (checkBoxUsuario.Checked)
            {
                HabilitarCuadroUsuario(true);
            }
            else
            {
                HabilitarCuadroUsuario(false);
            }
        }

        public void HabilitarCuadrosDatos(bool habiliar)
        {
            TxtNombre.Enabled = habiliar;
            TxtApellidos.Enabled = habiliar;
            TxtCalle.Enabled = habiliar;
            TxtColonia.Enabled = habiliar;
            TxtMunicipio.Enabled = habiliar;
            TxtCP.Enabled = habiliar;
            TxtTelefono.Enabled = habiliar;
            TxtCelular.Enabled = habiliar;
            TxtRFC.Enabled = habiliar;
            btGuardarDatos.Enabled = habiliar;
        }

        public void HabilitarCuadroUsuario(bool habilitar)
        {
            TxtNuevaContra.Enabled = habilitar;
            TxtConfirmarContra.Enabled = habilitar;
            btGuardarUsuario.Enabled = habilitar;
            pictureBox15.Enabled = habilitar;
            _contraVisible = false;
        }

        private void checkBoxEditarPerfil_CheckedChanged(object sender, EventArgs e)
        {
            EditarDatosPersonales();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!VerificarCuadrosBlancoUsuario())
            {
                if (TxtConfirmarContra.Text.Equals(TxtNuevaContra.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("Guardar cambios", "Desea guardar los cambios de su usuario?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int numeroCuenta = _N_Empleado.ObtenerNumeroCuenta();
                        if (numeroCuenta != 0)
                        {
                            _N_Cuenta.EditarCuenta(numeroCuenta,TxtUsuario.Text, TxtNuevaContra.Text);
                            MessageBox.Show("Los datos se han guardado correctamente");

                            LimpiarGrupoDatosUsuario();
                            ActualizarInformacionUI();//actualiza los textbox con los datos nuevos 
                            ActulizarInformacionCache();//Actualiza la clase cache para que guarde los nuevos datos
                            EditarDatosUsuario();
                            checkBoxUsuario.Checked = false;
                            _contraVisible = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Contrasena incorrecta verifique los campos");
                }
            }
            else
            {
                MessageBox.Show("No deje campos en blanco");
            }        
        }

        private bool VerificarCuadrosBlancoUsuario()
        {
            if(TxtNuevaContra.Text.Equals("") || TxtConfirmarContra.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUsuario.Checked)
            {
                HabilitarCuadroUsuario(true);
            }
            else
            {
                HabilitarCuadroUsuario(false);         
                TxtConfirmarContra.Clear();
                TxtNuevaContra.Clear();
                _contraVisible = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (!VerificarCuadrosBlancoDatos())
            {
                DialogResult dialogResult = MessageBox.Show("Guardar cambios", "Desea guardar los cambios de sus datos persoanles?", MessageBoxButtons.YesNo);

                if(dialogResult == DialogResult.Yes)
                {
                    int numeroCuenta = _N_Empleado.ObtenerNumeroCuenta();
                    if (numeroCuenta != 0)
                    {

                        string nombre = TxtNombre.Text;
                        string apellidos = TxtApellidos.Text;
                        string calle = TxtCalle.Text;
                        string colonia = TxtColonia.Text;
                        string municipio = TxtMunicipio.Text;
                        string CP = TxtCP.Text;
                        string telefono = TxtTelefono.Text;
                        string celular = TxtCelular.Text;
                        string RFC = TxtRFC.Text.ToUpper();

                        _N_Empleado.EditarEmpleado(CacheUsuario.ClaveEmpleado,nombre, apellidos, calle, colonia, municipio, CP, telefono, celular, RFC, numeroCuenta);
                        MessageBox.Show("Los datos se han guardo correctamente");
                        ActulizarInformacionCache();
                        ActualizarInformacionUI();                        

                        checkBoxEditarPerfil.Checked = false;
                        EditarDatosPersonales();
                    }
                }
            }
            else
            {
                MessageBox.Show("No deje campos en blanco");
            }
        }

        private void ActualizarInformacionUI()
        {
            TxtNombre.Text = CacheUsuario.NombreEmpleado1;
            TxtApellidos.Text = CacheUsuario.ApellidosEmpleado1;
            TxtCalle.Text = CacheUsuario.Calle_Empleado1;
            TxtColonia.Text = CacheUsuario.Colonia_Empleado1;
            TxtCP.Text = CacheUsuario.CP_Empleado1;
            TxtMunicipio.Text = CacheUsuario.Municipio_Empleado1;
            TxtTelefono.Text = CacheUsuario.TelefonoCasa_Empleado1;
            TxtCelular.Text = CacheUsuario.Celular_Empleado1;
            TxtRFC.Text = CacheUsuario.RFC_Empleado1;

            TxtUsuario.Text = CacheUsuario.Usuario_Empleado1;
            TxtContrasena.Text = CacheUsuario.Contra_Empleado;
        }

        private void ActulizarInformacionCache()
        {
            CacheUsuario.NombreEmpleado1 = TxtNombre.Text;
            CacheUsuario.ApellidosEmpleado1 = TxtApellidos.Text;
            CacheUsuario.Calle_Empleado1 = TxtCalle.Text;
            CacheUsuario.Colonia_Empleado1 = TxtColonia.Text;
            CacheUsuario.Municipio_Empleado1 = TxtMunicipio.Text;
            CacheUsuario.CP_Empleado1 = TxtCP.Text;
            CacheUsuario.TelefonoCasa_Empleado1 = TxtTelefono.Text;
            CacheUsuario.Celular_Empleado1 = TxtCelular.Text;
            CacheUsuario.RFC_Empleado1 = TxtRFC.Text;
        }

        private void LimpiarGrupoDatosEmpleado()
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
        }

        private void LimpiarGrupoDatosUsuario()
        {
            TxtNuevaContra.Clear();
            TxtConfirmarContra.Clear();
        }

        public bool VerificarCuadrosBlancoDatos()
        {
            if (String.IsNullOrEmpty(TxtNombre.Text) || String.IsNullOrEmpty(TxtApellidos.Text) || String.IsNullOrEmpty(TxtCalle.Text) || String.IsNullOrEmpty(TxtColonia.Text)
                || String.IsNullOrEmpty(TxtMunicipio.Text) || String.IsNullOrEmpty(TxtCP.Text) || String.IsNullOrEmpty(TxtTelefono.Text) || String.IsNullOrEmpty(TxtCelular.Text)
                || String.IsNullOrEmpty(TxtRFC.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FrmEditarPerfil_Load(object sender, EventArgs e)
        {
            TxtNombre.Text = CacheUsuario.NombreEmpleado1;
            TxtApellidos.Text = CacheUsuario.ApellidosEmpleado1;
            TxtCalle.Text = CacheUsuario.Calle_Empleado1;
            TxtColonia.Text = CacheUsuario.Colonia_Empleado1;
            TxtCP.Text = CacheUsuario.CP_Empleado1;
            TxtMunicipio.Text = CacheUsuario.Municipio_Empleado1;
            TxtTelefono.Text = CacheUsuario.TelefonoCasa_Empleado1;
            TxtCelular.Text = CacheUsuario.Celular_Empleado1;
            TxtRFC.Text = CacheUsuario.RFC_Empleado1;

            TxtUsuario.Text = CacheUsuario.Usuario_Empleado1;
            TxtContrasena.Text = CacheUsuario.Contra_Empleado;
        }

        private void TxtContrasena_TextChanged(object sender, EventArgs e)
        {

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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
