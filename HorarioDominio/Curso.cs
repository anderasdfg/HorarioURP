using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioDominio
{
    public class Curso
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Ciclo { get; set; }

        public Curso() {
            Codigo = "";
            Nombre = "";
            Ciclo = 0;
        }
        public Curso(string codigo, string nombre, int ciclo){
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Ciclo = ciclo;         
        }

    }
}
