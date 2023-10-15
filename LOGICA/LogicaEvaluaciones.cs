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
    public class LogicaEvaluaciones
    {
        Datos datos = new Datos();
        SQLiteCommand cmd;

        public bool CrearEvaluacion(Evaluacion evaluacion)
        {
            return true;
        }

        public List<Curso> ObtenerEvaluaciones()
        {
            return new List<Curso>();
        }

        public bool ActualizarEvaluacion(Evaluacion evaluacion)
        {
            return true;
        }

        public bool EliminarEvaluacion(int idEvaluacion)
        {
            return true;
        }
    }
}
