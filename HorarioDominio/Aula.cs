using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioDominio
{
    public class Aula
    {
        public string IdAula { get; set; }
        public Aula() {
            IdAula = "";
        }
        public Aula(string idAula)
        {
            this.IdAula = idAula;
        }
    }
}
