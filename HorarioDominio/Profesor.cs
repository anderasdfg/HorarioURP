using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioDominio
{
    public class Profesor
    {
        public string Codigo { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Especialidad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Grado_Academico { get; set; }
            
        public Profesor()
        {
            Codigo = "";
            Nombre1 = "";
            Nombre2 = "";
            Apellido1 = "";
            Apellido2 = "";
            Especialidad = "";
            Correo = "";
            Telefono = "";
            Grado_Academico = "";
        }

        public Profesor(string codigo, string nombre1, string nombre2, string apellido1, string apellido2, string especialidad, string correo, string telefono, string grado_academico)
        {
            this.Codigo = codigo;
            this.Nombre1 = nombre1;
            this.Nombre2 = nombre2;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Especialidad = especialidad;
            this.Correo = correo;
            this.Telefono = telefono;
            this.Grado_Academico = grado_academico;
        }
    }
}
