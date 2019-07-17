using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorarioDominio;
using System.Data;
using System.Data.SqlClient;

namespace HorarioGestionDatos
{
    public class AdministradorDat
    {

        SqlConnection conexion;
        public AdministradorDat() {
            conexion = new SqlConnection(Conexion.CadenaConexion);
        }
        public DataTable AccesoSistema(Administrador objAdministrador) {

            SqlCommand cmd = new SqlCommand("sp_Acceso_Sistema", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@asUsuario", objAdministrador.Usuario);
            cmd.Parameters.AddWithValue("@asContrasenia", objAdministrador.Contrasenia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            da.Fill(datatable);
            return datatable;
        }
       
        
    }
}
