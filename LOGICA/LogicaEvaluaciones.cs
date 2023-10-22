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
            return true;
        }

        public List<Evaluacion> ObtenerEvaluaciones(int idCurso)
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
                        Convert.ToDouble(dr["PorcentajeEvaluacion"]),
                        Convert.ToString(dr["DescripcionEvaluacion"]),
                        Convert.ToInt32(dr["CalculoAutomatico"]),
                        Convert.ToInt32(dr["IdCurso"])
                    ));
            }
            return listaEvaluaciones;
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
