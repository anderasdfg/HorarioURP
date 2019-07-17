using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioDominio
{
    public class Administrador
    {
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

        public Administrador()
        {
            Usuario = "";
            Contrasenia = "";
        }
        public Administrador(string usuario, string contrasenia)
        {
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;
        }
    }
}
