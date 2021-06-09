using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class D_Proveedores
    {
        //Siempre Escribir cuando se cree una nueva clase
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);      

        //PROCESOS ALMACENADOS AQUÍ CONSULTEN LOS SCRIPTS DE SQL PARA VER


    }
}
