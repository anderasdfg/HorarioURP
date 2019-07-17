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
    public class AdministradorNeg
    {   
        AdministradorDat objAdministradorDat;
        public AdministradorNeg()
        {
            objAdministradorDat = new AdministradorDat();
        }
        public DataTable AccesoSistema(Administrador objAdministrador)
        {
            try
            {
                return objAdministradorDat.AccesoSistema(objAdministrador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
