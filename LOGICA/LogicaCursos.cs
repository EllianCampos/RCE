using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class LogicaCursos
    {
        Datos datos = new Datos();
        SQLiteCommand cmd;

        public bool CrearCurso(Curso curso)
        {
            return true;
        }

        public List<Curso> ObtenerCursos()
        {
            return new List<Curso>();
        }

        public bool ActualizarCurso(Curso curso)
        {
            return true;
        }

        public bool EliminarCurso(int idCurso)
        {
            return true;
        }
    }
}
