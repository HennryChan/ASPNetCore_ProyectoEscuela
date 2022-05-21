using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace AspNetCore_ProyectoEscuela.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "El nombre del curso es requerido")]
        [StringLength(5)]
        public override string Nombre { set; get; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }

        [Display(Prompt = "Direccion correspondencia", Name = "Address")]
        [Required(ErrorMessage = "Se requiere incluir una direcci�n")]
        [MinLength(10, ErrorMessage = "La longitud m�nima de la direcci�n es 10")]
        public string Direccion { get; set; }

        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }


    }
}