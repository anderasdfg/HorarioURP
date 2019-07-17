using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HorarioGestionDatos
{
    public class Conexion
    {
        public static string CadenaConexion
        {
            get
            {
                return "data source=DESKTOP-JD6AVD3\\SQLEXPRESS;initial catalog=HORARIOURP;integrated security=SSPI; User ID=Anderley; Password=2014lunahuana";
            }
        }
        
    }
}
