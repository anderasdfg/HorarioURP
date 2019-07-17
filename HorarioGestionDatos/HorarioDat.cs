using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorarioDominio;
using System.Data.SqlClient;
using System.Data;
namespace HorarioGestionDatos
{
    public class HorarioDat
    {
        SqlConnection conexion;
        public HorarioDat()
        {
            conexion = new SqlConnection(Conexion.CadenaConexion);
        }
        public DataSet SelectHorarioPorProfesor(String codigo_profesor)
        {
            SqlCommand cmd = null;
            DataSet dsHorario = new DataSet();
            cmd = new SqlCommand("sp_BuscarHorarioPorProfe", conexion);
            cmd.Parameters.AddWithValue("@codigoProfesor", codigo_profesor);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsHorario, "Horario");
            return dsHorario;
        }
        public DataSet SelectHorarioPorClase(String codigo_Clase)
        {
            SqlCommand cmd = null;
            DataSet dsHorario2 = new DataSet();
            cmd = new SqlCommand("sp_BuscarHorarioPorClase", conexion);
            cmd.Parameters.AddWithValue("@codigoClase", codigo_Clase);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsHorario2, "Horario2");
            return dsHorario2;
        }

    }
}
