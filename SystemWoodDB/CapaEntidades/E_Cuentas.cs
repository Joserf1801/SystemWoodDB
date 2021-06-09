using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Cuentas
    {
        private int Numero_Cuenta;
        private string Usuario;
        private string password;

        public int Numero_Cuenta1
        {
            get
            {
                return Numero_Cuenta;
            }

            set
            {
                Numero_Cuenta = value;
            }
        }

        public string Usuario1
        {
            get
            {
                return Usuario;
            }

            set
            {
                Usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}
