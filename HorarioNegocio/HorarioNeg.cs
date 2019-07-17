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
    public class HorarioNeg
    {
        HorarioDat objHorarioDat;
        public HorarioNeg()
        {
            objHorarioDat = new HorarioDat();
        }
        public DataSet BuscarHorarioPorProfesor(String codigoProfesor)
        {
            return objHorarioDat.SelectHorarioPorProfesor(codigoProfesor);
        }
        public DataSet BuscarHorarioPorClase(String codigoClase)
        {
            return objHorarioDat.SelectHorarioPorClase(codigoClase);
        }

    }
}
