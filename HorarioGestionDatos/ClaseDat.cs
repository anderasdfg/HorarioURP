using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorarioDominio;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace HorarioGestionDatos
{
    public class ClaseDat
    {

        SqlConnection conexion;
        public ClaseDat()
        {
            conexion = new SqlConnection(Conexion.CadenaConexion);
        }

        
        public DataSet SelectClasePorProfesor(String codigo_profesor)
        {
            SqlCommand cmd = null;            
            DataSet dsClase = new DataSet();
            cmd = new SqlCommand("sp_BuscarClasePorProfesor", conexion);
            cmd.Parameters.AddWithValue("@codigoProfesor", codigo_profesor);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();              
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsClase, "Clase");
            return dsClase;            
        }       
    }

}


