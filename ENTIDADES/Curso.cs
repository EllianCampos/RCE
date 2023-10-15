namespace ENTIDADES
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public string Duracion { get; set; }
        public int CantidadEstudiantes { get; set; }

        public Curso() { }

        public Curso(int idCurso, string nombre, string duracion, int cantidadEstudiantes)
        {
            IdCurso = idCurso;
            Nombre = nombre;
            Duracion = duracion;
            CantidadEstudiantes = cantidadEstudiantes;
        }
    }
}