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
        public string NombreEvaluacion { get; set; }
        public double PorcentajeEvaluacion { get; set; }
        public string DescripcionEvaluacion { get; set; }
        public int IdRubro { get; set; }
        public Evaluacion(int idEvaluacion, string nombreEvaluacion, double porcentajeEvaluacion, string descripcionEvaluacion, int idRubro)
        {
            IdEvaluacion = idEvaluacion;
            NombreEvaluacion = nombreEvaluacion;
            PorcentajeEvaluacion = porcentajeEvaluacion;
            DescripcionEvaluacion = descripcionEvaluacion;
            IdRubro = idRubro;
        }
    }
}
