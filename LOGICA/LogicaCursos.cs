using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
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
            cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT IdCurso, NombreCurso FROM Cursos";
            DataTable dtCursos = datos.Obtener(cmd);

            List<Curso> listaCursos = new List<Curso>();
            foreach (DataRow dr in dtCursos.Rows)
            {
                listaCursos.Add(new Curso() { IdCurso = Convert.ToInt32(dr["IdCurso"]), Nombre = Convert.ToString(dr["NombreCurso"]) });
            }

            return listaCursos;
        }

        public Curso ObtenerCurso(int id)
        {
            List<Curso> listaCursos = ObtenerCursos();
            Curso curso = listaCursos.Find(curso => curso.IdCurso == id);
            return curso;
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
