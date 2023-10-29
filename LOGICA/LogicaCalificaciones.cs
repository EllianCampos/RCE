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
        LogicaEvaluaciones logicaEvaluaciones = new LogicaEvaluaciones();

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

        public List<Promedio> ObtenerPromedios(int idCurso)
        {
            cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT * FROM Calificaciones c, Evaluaciones e, Estudiantes es WHERE c.IdEvaluacion = e.IdEvaluacion AND c.IdEstudiante = es.IdEstudiante;";
            DataTable dt_calif_estu_evalua = datos.Obtener(cmd);

            // Filtrar calificaciones por curso
            foreach (DataRow dr in dt_calif_estu_evalua.Rows)
            {
                if (Convert.ToInt32(dr["IdCurso"]) != idCurso)
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
        
        public DataTable ObtenerReportePromedios(int idCurso)
        {
            // Obtner las evaluaciones 
            cmd = new SQLiteCommand();
            cmd.CommandText = "SELECT * FROM Calificaciones c, Evaluaciones e, Estudiantes es " +
                "WHERE c.IdEvaluacion = e.IdEvaluacion AND c.IdEstudiante = es.IdEstudiante;";
            DataTable dt_calif_estu_evalua = datos.Obtener(cmd);

            // Filtrar calificaciones por curso
            foreach (DataRow dr in dt_calif_estu_evalua.Rows)
            {
                if (Convert.ToInt32(dr["IdCurso"]) != idCurso)
                {
                    dt_calif_estu_evalua.Rows[Convert.ToInt32(dr["IdCalificacion"]) - 1].Delete();
                }
            }
            dt_calif_estu_evalua.AcceptChanges();

            // Crear el DataTable del reporte
            DataTable dtReporte = new DataTable("Promedios");
            DataColumn column;
            DataRow row;

            // Crear la Columna del ID
            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "IdEstudiante";
            column.ReadOnly = true;
            column.Unique = true;
            dtReporte.Columns.Add(column);

            // Crear la Columna del Nombre
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "NombreEstudiante";
            column.ReadOnly = true;
            column.Unique = false;
            dtReporte.Columns.Add(column);

            // Generar una columna por cada EVALUACION
            List<Evaluacion> listaEvaluaciones = logicaEvaluaciones.ObtenerEvaluacionesPorCurso(idCurso);
            foreach (Evaluacion evaluacion in listaEvaluaciones)
            {
                column = new DataColumn();
                column.DataType = typeof(double);
                column.ColumnName = evaluacion.Nombre;
                column.ReadOnly = false;
                column.Unique = false;
                dtReporte.Columns.Add(column);
            }

            // Crear la Columna del Promedio
            column = new DataColumn();
            column.DataType = typeof(double);
            column.ColumnName = "Promedio";
            column.ReadOnly = false;
            column.Unique = false;
            dtReporte.Columns.Add(column);

            // Crear la lista de los estudiantes SIN notas
            foreach (DataRow dr in dt_calif_estu_evalua.Rows)
            {
                int idEstudiante = Convert.ToInt32(dr["IdEstudiante"]);

                // Validar si el estudiante ya existe
                bool encontrado = false;
                foreach (DataRow dr2 in dtReporte.Rows)
                {
                    if (Convert.ToInt32(dr2["IdEstudiante"]) == idEstudiante)
                    {
                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    row = dtReporte.NewRow();
                    row["IdEstudiante"] = idEstudiante;
                    row["NombreEstudiante"] = Convert.ToString(dr["NombreEstudiante"]) + " " + Convert.ToString(dr["ApellidosEstudiante"]);
                    dtReporte.Rows.Add(row);
                }                
            }

            // Generar las notas 
            foreach (DataRow dr in dt_calif_estu_evalua.Rows )
            {
                if (Convert.ToInt32(dr["CalculoAutomatico"]) == 0)
                {
                    // Calcular el porcentaje obtenido
                    decimal puntosObtenidos = Convert.ToInt32(dr["PuntosCalificacion"]);
                    decimal puntosTotal = Convert.ToInt32(dr["PuntosEvaluacion"]);
                    decimal porcentaje = Convert.ToDecimal(dr["PorcentajeEvaluacion"]);
                    decimal porcentajeObtenidoEnLaEvaluacion = porcentaje * puntosObtenidos / puntosTotal;

                    var indexRow = 0;
                    foreach (DataRow item in dtReporte.Rows)
                    {
                        if (item["IdEstudiante"].ToString() == dr["IdEstudiante"].ToString())
                        {
                            item[dr["NombreEvaluacion"].ToString()] = porcentajeObtenidoEnLaEvaluacion;
                        }
                    }
                }
                else
                {
                    int cantidad = Convert.ToInt32(dr["CantidadEvaluaciones"].ToString());

                    // Calcular el porcentaje obtenido
                    decimal puntosObtenidos = Convert.ToInt32(dr["PuntosCalificacion"]);
                    decimal puntosTotal = Convert.ToInt32(dr["PuntosEvaluacion"]);
                    decimal porcentaje = Convert.ToDecimal(dr["PorcentajeEvaluacion"]);
                    decimal porcentajeObtenidoEnLaEvaluacion = (porcentaje / cantidad) * puntosObtenidos / puntosTotal;

                    foreach (DataRow item in dtReporte.Rows)
                    {
                        if (item["IdEstudiante"].ToString() == dr["IdEstudiante"].ToString())
                        {
                            decimal porcentajeActual;
                            if (decimal.TryParse(item[dr["NombreEvaluacion"].ToString()].ToString(), out porcentajeActual))
                            {
                                item[dr["NombreEvaluacion"].ToString()] = porcentajeActual + porcentajeObtenidoEnLaEvaluacion;
                            }
                            else
                            {
                                item[dr["NombreEvaluacion"].ToString()] = porcentajeObtenidoEnLaEvaluacion;
                            }
                        }
                    }
                }
            }

            // Generar los promedios
            foreach (DataRow dr in dtReporte.Rows)
            {
                double porcentaje = 0;
                foreach (Evaluacion evaluacion in listaEvaluaciones)
                {
                    try
                    {
                        porcentaje += Convert.ToDouble(dr[evaluacion.Nombre]);
                    }
                    catch (Exception ex) { }                   
                }
                dr["Promedio"] = porcentaje;
                porcentaje = 0;
            }

            return dtReporte;
        }
    }
}
