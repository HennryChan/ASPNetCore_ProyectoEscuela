using System;
using System.ComponentModel.DataAnnotations;


namespace AspNetCore_ProyectoEscuela.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }

        public virtual string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {

        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}