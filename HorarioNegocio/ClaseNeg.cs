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
    public class ClaseNeg
    {
        ClaseDat objClaseDat;
        public ClaseNeg()
        {
            objClaseDat = new ClaseDat();
        }

        public DataSet BuscarClasePorProfesor(String codigoProfesor)
        {
            return objClaseDat.SelectClasePorProfesor(codigoProfesor);
        }
       
    }
}
