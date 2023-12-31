﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Estudiante 
    {
        public int IdEstudiante { get; set; } 
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Estudiante() { }

        public Estudiante(int idEstudiante, string cedula, string nombre, string apellidos, int edad, string correo, string direccion)
        {
            IdEstudiante = idEstudiante;
            Cedula = cedula;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Correo = correo;
            Direccion = direccion;
        }
    }
}
