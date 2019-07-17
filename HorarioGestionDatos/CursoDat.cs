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
    public class CursoDat
    {
        SqlConnection conexion;
        public CursoDat()
        {
            conexion = new SqlConnection(Conexion.CadenaConexion);
        }
        public DataSet SelectProfesorPorCurso(Curso objCurso)
        {            
            SqlCommand cmd = null;
            DataSet dsProfesor = new DataSet();
            cmd = new SqlCommand("sp_BuscarProfesorPorCurso2", conexion);            
            cmd.Parameters.AddWithValue("@codigoCurso", objCurso.Codigo);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();            
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsProfesor, "Profesor");
            return dsProfesor;
        }
        public DataSet SelectCodigoClasePorCurso(Curso objCurso)
        {
            SqlCommand cmd = null;
            DataSet dsCodigoClase = new DataSet();
            cmd = new SqlCommand("sp_BuscarCodigoClasePorCurso", conexion);
            cmd.Parameters.AddWithValue("@codigoCurso", objCurso);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dsCodigoClase, "CodigoClase");
            return dsCodigoClase;
        }
        /*public bool selectCodigoCursoPorCodigoCurso(Curso objCurso)
        {
            string select = "SELECT Codigo FROM T_Curso WHERE Codigoc = '" + objCurso.Codigo + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);
            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objCurso.Codigo = (string)reader[0];
            }
            else
                objCurso = null;
            conexion.Close();
            return hayRegistros;

        }*/
    }
}
