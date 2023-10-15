using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Promedio
    {
        public int IdEstudiante { get; set; }
        public string NombreEstudiante { get; set; }
        public decimal Porcentaje { get; set; }

        public Promedio() { }

        public Promedio(int idEstudiante, string nombreEstudiante, int porcentaje)
        {
            IdEstudiante = idEstudiante;
            NombreEstudiante = nombreEstudiante;
            Porcentaje = porcentaje;
        }
    }
}
