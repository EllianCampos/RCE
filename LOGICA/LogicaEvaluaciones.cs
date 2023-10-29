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
    public class LogicaEvaluaciones
    {
        Datos datos = new Datos();
        SQLiteCommand cmd;

        public bool CrearEvaluacion(Evaluacion evaluacion)
        {
            cmd = new SQLiteCommand();
            cmd.CommandText = "INSERT INTO Evaluaciones (NombreEvaluacion, PuntosEvaluacion, PorcentajeEvaluacion, CalculoAutomatico, IdCurso) " +
                "VALUES(@nombre, @puntos, @porcentaje, @calculo, @idCurso)";
            cmd.Parameters.AddWithValue("@nombre", evaluacion.Nombre);
            cmd.Parameters.AddWithValue("@puntos", evaluacion.Puntos);
            cmd.Parameters.AddWithValue("@porcentaje", evaluacion.Porcentaje);
            cmd.Parameters.AddWithValue("@calculo", evaluacion.CalculoAutomatico);
            cmd.Parameters.AddWithValue("@idCurso", evaluacion.IdCurso);
            return datos.Ejecutar(cmd);
        }

        public List<Evaluacion> ObtenerEvaluacionesPorCurso(int idCurso)
        {
            cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT * FROM Evaluaciones WHERE IdCurso = @idCurso";
            cmd.Parameters.AddWithValue("@idCurso", idCurso);
            DataTable dt = datos.Obtener(cmd);

            List<Evaluacion> listaEvaluaciones = new List<Evaluacion>();
            foreach (DataRow dr in dt.Rows)
            {
                listaEvaluaciones.Add(new Evaluacion(
                        Convert.ToInt32(dr["IdEvaluacion"]),
                        Convert.ToString(dr["NombreEvaluacion"]),
                        Convert.ToInt32(dr["PuntosEvaluacion"]),
                        Convert.ToInt32(dr["PorcentajeEvaluacion"]),
                        Convert.ToString(dr["CalculoAutomatico"]),
                        Convert.ToInt32(dr["IdCurso"])
                    ));
            }
            return listaEvaluaciones;
        }

        public bool ActualizarEvaluacion(Evaluacion evaluacion)
        {
            cmd = new SQLiteCommand();
            cmd.CommandText = "UPDATE Evaluaciones SET NombreEvaluacion = @nombre, PuntosEvaluacion = @puntos, PorcentajeEvaluacion = @porcentaje " +
                "WHERE IdEvaluacion = @idEvaluacion";
            cmd.Parameters.AddWithValue("@nombre", evaluacion.Nombre);
            cmd.Parameters.AddWithValue("@puntos", evaluacion.Puntos);
            cmd.Parameters.AddWithValue("@porcentaje", evaluacion.Porcentaje);
            cmd.Parameters.AddWithValue("@idEvaluacion", evaluacion.IdEvaluacion);
            return datos.Ejecutar(cmd);
        }

        public bool EliminarEvaluacion(int idEvaluacion)
        {
            return true;
        }
    }
}
