using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Matricula
    {
        public int IdCurso { get; set; }
        public int IdEstudiante { get; set;}

        public Matricula() { }

        public Matricula(int idCurso, int idEstudiante)
        {
            IdCurso = idCurso;
            IdEstudiante = idEstudiante;
        }
    }
}
