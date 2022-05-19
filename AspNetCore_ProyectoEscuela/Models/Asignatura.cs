using System;
using System.Collections.Generic;

namespace AspNetCore_ProyectoEscuela.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public string cursoId { get; set; }
        public Curso curso { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }
    }
}