using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Evaluacion
    {
        public int IdEvaluacion { get; set; }
        public string Nombre { get; set; }
        public int Puntos { get; set; }
        public int Porcentaje { get; set; }
        public string CalculoAutomatico { get; set; }
        public int IdCurso { get; set; }

        public Evaluacion() { }

        public Evaluacion(string nombre, int puntos, int porcentaje, string calculoAutomatico, int idCurso)
        {
            Nombre = nombre;
            Puntos = puntos;
            Porcentaje = porcentaje;
            CalculoAutomatico = calculoAutomatico;
            IdCurso = idCurso;
        }

        public Evaluacion(int idEvaluacion, string nombre, int puntos, int porcentaje, string calculoAutomatico, int idCurso)
        {
            IdEvaluacion = idEvaluacion;
            Nombre = nombre;
            Porcentaje = porcentaje;
            CalculoAutomatico = calculoAutomatico;
            IdCurso = idCurso;
        }
    }
}
