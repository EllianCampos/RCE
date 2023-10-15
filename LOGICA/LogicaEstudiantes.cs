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
    public class LogicaEstudiantes
    {
        Datos datos = new Datos();
        SQLiteCommand cmd;

        public bool CrearEstudiante(Estudiante estudiante)
        {
            return true;
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return new List<Estudiante>();
        }

        public bool ActualizarEstudiante(Estudiante estudiante)
        {
            return true;
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            return true;
        }
    }
}
