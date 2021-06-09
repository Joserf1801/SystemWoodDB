using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class E_Clasificacion
    {
        private int ID_Clasificacion;
        private string Codigo_Clasificacion;
        private string Nombre_Clasificacion;

        public int ID_Clasificacion1
        {
            get
            {
                return ID_Clasificacion;
            }

            set
            {
                ID_Clasificacion = value;
            }
        }

        public string Codigo_Clasificacion1
        {
            get
            {
                return Codigo_Clasificacion;
            }

            set
            {
                Codigo_Clasificacion = value;
            }
        }

        public string Nombre_Clasificacion1
        {
            get
            {
                return Nombre_Clasificacion;
            }

            set
            {
                Nombre_Clasificacion = value;
            }
        }
    }
}
