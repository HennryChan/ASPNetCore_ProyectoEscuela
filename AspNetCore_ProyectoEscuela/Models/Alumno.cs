using System;
using System.Collections.Generic;

namespace AspNetCore_ProyectoEscuela.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}