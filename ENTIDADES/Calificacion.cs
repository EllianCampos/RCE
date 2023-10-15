using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Calificacion
    {
        public int IdCalificacion { get; set; }
        public Decimal Nota { get; set; }
        public int IdEvaluacion { get; set; }
        public int IdEstudiante { get; set; }

        public Calificacion() { }

        public Calificacion(int idCalificacion, decimal nota, int idEvaluacion, int idEstudiante)
        {
            IdCalificacion = idCalificacion;
            Nota = nota;
            IdEvaluacion = idEvaluacion;
            IdEstudiante = idEstudiante;
        }
    }
}
