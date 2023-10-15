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
    public class LogicaCalificaciones
    {
        Datos datos = new Datos();
        SQLiteCommand cmd;

        public List<Calificacion> ObtenerCalificaciones()
        {
            cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT * FROM Calificaciones";
            DataTable dt = datos.Obtener(cmd);

            List<Calificacion> listaCalificaciones = new List<Calificacion>();
            foreach (DataRow dr in dt.Rows)
            {
                listaCalificaciones.Add(new Calificacion(
                        Convert.ToInt32(dr["IdCalificacion"]),
                        Convert.ToDecimal(dr["Nota"]),
                        Convert.ToInt32(dr["IdEvaluacion"]),
                        Convert.ToInt32(dr["IdEstudiante"])
                    ));
            }
            return listaCalificaciones;
        }

        public List<Promedio> ObtenerPromedios(int IdCurso)
        {
            cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT * FROM Calificaciones c, Evaluaciones e, Estudiantes es WHERE c.IdEvaluacion = e.IdEvaluacion AND c.IdEstudiante = es.IdEstudiante;";
            DataTable dt_calif_estu_evalua = datos.Obtener(cmd);

            // Filtrar calificaciones por curso
            foreach (DataRow dr in dt_calif_estu_evalua.Rows)
            {
                if (Convert.ToInt32(dr["IdCurso"]) != IdCurso)
                {
                    dt_calif_estu_evalua.Rows[Convert.ToInt32(dr["IdCalificacion"]) - 1].Delete();
                }
            }
            dt_calif_estu_evalua.AcceptChanges();

            // Crear la lista de los estudiantes SIN el promedio
            List<Promedio> listaPromedios = new List<Promedio>();
            foreach (DataRow dr in dt_calif_estu_evalua.Rows)
            {
                int idEstudiante = Convert.ToInt32(dr["IdEstudiante"]);
                var estudiante = listaPromedios.Find(x => x.IdEstudiante == idEstudiante);
                if (estudiante == null)
                {
                    listaPromedios.Add(new Promedio(
                            idEstudiante,
                            Convert.ToString(dr["NombreEstudiante"]) + " " + Convert.ToString(dr["ApellidosEstudiante"]),
                            0
                        ));
                }
            }

            // Generar los promedios
            foreach (DataRow dr in dt_calif_estu_evalua.Rows)
            {
                int idEstudiante = Convert.ToInt32(dr["IdEstudiante"]);
                int calculoAutomatico = Convert.ToInt32(dr["CalculoAutomatico"]);

                decimal nota = Convert.ToDecimal(dr["Nota"]);
                decimal porcentaje = Convert.ToDecimal(dr["PorcentajeEvaluacion"]);

                decimal porcentajeObtenidoEnLaEvaluacion = 0;
                if (calculoAutomatico == 1)
                {
                    porcentajeObtenidoEnLaEvaluacion = nota * porcentaje / 100;
                }

                // Sumar el porcentaje
                foreach (Promedio promedio in listaPromedios)
                {
                    if (promedio.IdEstudiante == idEstudiante)
                    {
                        promedio.Porcentaje += porcentajeObtenidoEnLaEvaluacion;
                    }
                }
            }
            return listaPromedios; //15
        }
    }
}
