





// CLASE DE EJEMPLO
// CLASE DE EJEMPLO
// CLASE DE EJEMPLO
// CLASE DE EJEMPLO
// CLASE DE EJEMPLO
// CLASE DE EJEMPLO
// CLASE DE EJEMPLO











/*using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SQLite;
using System.Data;
using System.Threading;
using DATOS;
using ENTIDADES;

namespace LOGICA_NEGOCIO
{
	public class LogicaTareas
	{
		Datos datos = new Datos();

		public bool CrearTarea(Tarea tarea)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = "INSERT INTO tareas(Titulo, Fecha, Estado, Categoria, " +
				"Apuntes) VALUES(@titulo, @fecha, @estado, @categoria, @apuntes)";
			cmd.Parameters.AddWithValue("@titulo", tarea.Titulo);
			cmd.Parameters.AddWithValue("@fecha", tarea.Fecha);
			cmd.Parameters.AddWithValue("@estado", tarea.Estado);
			cmd.Parameters.AddWithValue("@categoria", tarea.Categoria);
			cmd.Parameters.AddWithValue("@apuntes", tarea.Apuntes);

			return datos.Ejecutar(cmd);
		}

		public List<Tarea> ObtenerTareas()
		{
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = "SELECT * FROM tareas";
			DataTable dt = datos.Obtener(cmd);

			List<Tarea> listaTareas = new List<Tarea>();
			foreach (DataRow row in dt.Rows)
			{
				listaTareas.Add(new Tarea(
						Convert.ToInt32(row["Id_Tarea"]),
						Convert.ToString(row["Titulo"]),
						Convert.ToDateTime(row["Fecha"]),
						Convert.ToString(row["Estado"]),
						Convert.ToString(row["Categoria"]),
						Convert.ToString(row["Apuntes"])
					));
			}
			return listaTareas;
		}

		public bool ActualizarTarea(Tarea tarea)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = "UPDATE tareas SET Titulo = @titulo, Fecha = @fecha, " +
				"Estado = @estado, Categoria = @categoria, Apuntes = @apuntes " +
				"WHERE Id_Tarea = @idtarea";
			cmd.Parameters.AddWithValue("@titulo", tarea.Titulo);
			cmd.Parameters.AddWithValue("@fecha", tarea.Fecha);
			cmd.Parameters.AddWithValue("@estado", tarea.Estado);
			cmd.Parameters.AddWithValue("@categoria", tarea.Categoria);
			cmd.Parameters.AddWithValue("@apuntes", tarea.Apuntes);
			cmd.Parameters.AddWithValue("@idtarea", tarea.IdTarea);

			return datos.Ejecutar(cmd);
		}

		public bool EliminarTarea(int idTarea)
		{
			SQLiteCommand cmd = new SQLiteCommand();
			cmd.CommandText = "DELETE FROM tareas WHERE Id_Tarea = @idTarea";
			cmd.Parameters.AddWithValue("@idTarea", idTarea);

			return datos.Ejecutar(cmd);
		}
	}
} */