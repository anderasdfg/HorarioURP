using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorarioDominio
{
    public class Horario
    {
        public int Codigo { get; set; }
        public Aula Id_Aula { get; set; }
        public Clase Codigo_Clase { get; set; }
        public string Dia { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Fin { get; set; }
        public string Tipo { get; set; }

        public Horario() {
            this.Codigo = 0;
            this.Id_Aula = null;
            this.Codigo_Clase = null;
            this.Dia = "";
            this.Hora_Inicio = DateTime.Now;
            this.Hora_Fin = DateTime.Now;
            this.Tipo = "";
        }
        public Horario(int codigo, Aula id_Aula, Clase codigo_clase, string dia, DateTime hora_inicio, DateTime hora_fin, string tipo)
        {
            this.Codigo = codigo;
            this.Id_Aula =id_Aula;
            this.Codigo_Clase = codigo_clase;
            this.Dia = dia;
            this.Hora_Inicio = hora_inicio;
            this.Hora_Fin = hora_fin;
            this.Tipo = tipo;
        }
    }
}
