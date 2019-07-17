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
    public class CursoNeg
    {
        CursoDat objCursoDat;
        public CursoNeg()
        {
            objCursoDat = new CursoDat();
        }
        public DataSet BuscarProfesorPorCurso(Curso objCurso)
        {
            return objCursoDat.SelectProfesorPorCurso(objCurso);
        }
        public DataSet buscarCodigoClasePorCurso(Curso objCurso)
        {
            return objCursoDat.SelectCodigoClasePorCurso(objCurso);
        }
        /* public bool buscarCodigoCursoPorCodigoCurso(Curso objCurso)
         {
             return objCursoDat.selectCodigoCursoPorCodigoCurso(objCurso);
         }*/
    }
}
