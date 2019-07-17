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
    public class ProfesorDat
    {
        SqlConnection conexion;
        public ProfesorDat()
        {
            conexion = new SqlConnection(Conexion.CadenaConexion);
        }
        DataSet resultado = new DataSet();
        DataView filtro;
        public DataSet SelectProfesores()
        {
            DataSet dsProfesores = new DataSet();

            string select = "SELECT * FROM T_Profesor";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conexion);

            dataAdapter.Fill(dsProfesores, "Profesores");
            return dsProfesores;
        }
        public DataSet SelectProfesor(Profesor objProfesor)
        {
            DataSet dsProfesores = new DataSet();            
            string select = "SELECT * FROM T_Profesor WHERE Nombre1 LIKE '%" + objProfesor.Nombre1 + "%' OR Nombre2 LIKE '%" + objProfesor.Nombre2 + "%' OR Apellido1 LIKE '%" + objProfesor.Apellido1 + "%' OR Apellido2 LIKE '%" + objProfesor.Apellido2 + "%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, conexion);

            dataAdapter.Fill(dsProfesores, "Profesor");
            return dsProfesores;
        }
        public bool selectCodigoProfesorPorCorreo(Profesor objProfesor)
        {
            string select = "SELECT Codigo FROM T_Profesor WHERE Correo = '" + objProfesor.Correo + "'";
            SqlCommand unComando = new SqlCommand(select, conexion);
            conexion.Open();
            SqlDataReader reader = unComando.ExecuteReader();
            bool hayRegistros = reader.Read();
            if (hayRegistros)
            {
                objProfesor.Codigo = (string)reader[0];
            }
            else
                objProfesor = null;
            conexion.Close();
            return hayRegistros;
            
        }


       

    }
}
