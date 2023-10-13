namespace ENTIDADES
{
    public class Cursos
    {
     //Datos para los cursos
        public string NombreCurso { get; set; }
        public string ProfesorEncargado { get; set; }
        public string Duracion { get; set; }
        public string Horario { get; set; }

        //Constructor
        public Cursos(string nombreCurso, string profesorEncargado, string duracion, string horario)
        {
            NombreCurso = nombreCurso;
            ProfesorEncargado = profesorEncargado;
            Duracion = duracion;
            Horario = horario;
        }

    }



}