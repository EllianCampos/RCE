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
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
    }
}