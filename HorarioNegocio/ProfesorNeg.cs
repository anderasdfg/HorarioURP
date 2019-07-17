using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorarioDominio;
using HorarioGestionDatos;
using System.Data;

namespace HorarioNegocio
{
    public class ProfesorNeg
    {
        ProfesorDat objProfesorDat;
        public ProfesorNeg()
        {
            objProfesorDat = new ProfesorDat();
        }
        public DataSet LeerProfesores()
        {
            return objProfesorDat.SelectProfesores();
        }
        public DataSet LeerProfesor(Profesor objProfesor)
        {
            return objProfesorDat.SelectProfesor(objProfesor);
        }
        public bool buscarCodigoProfesorPorCorreo(Profesor objProfesor)
        {
            return objProfesorDat.selectCodigoProfesorPorCorreo(objProfesor);
        }


    }
}
