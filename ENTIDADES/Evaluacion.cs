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
        public double Porcentaje { get; set; }
        public string Descripcion { get; set; }
        public int CalculoAutomatico { get; set; }
        public int IdCurso { get; set; }

        public Evaluacion() { }

        public Evaluacion(int idEvaluacion, string nombre, double porcentaje, string descripcion, int calculoAutomatico, int idCurso)
        {
            IdEvaluacion = idEvaluacion;
            Nombre = nombre;
            Porcentaje = porcentaje;
            Descripcion = descripcion;
            CalculoAutomatico = calculoAutomatico;
            IdCurso = idCurso;
        }
    }
}
