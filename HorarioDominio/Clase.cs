using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioDominio
{
    public class Clase
    {
        public string Codigo { get; set; }
        public Curso Codigo_Curso { get; set; }
        public string Grupo { get; set; }
        public int Subgrupo { get; set; }
        public Profesor Codigo_Profesor { get; set; }

        public Clase()
        {
            this.Codigo = "";
            this.Codigo_Curso = null;
            this.Grupo = "";
            this.Subgrupo = 0;           
            this.Codigo_Profesor = null;
        }
        public Clase(string codigo, Curso codigo_curso, string grupo, int subgrupo, Profesor codigo_profesor)
        {
            this.Codigo = codigo;
            this.Codigo_Curso = codigo_curso;
            this.Grupo = grupo;
            this.Subgrupo = subgrupo;   
            this.Codigo_Profesor = codigo_profesor;
        }
    }
}
