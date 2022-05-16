using Microsoft.AspNetCore.Mvc;
using AspNetCore_ProyectoEscuela.Models;
using System;

namespace AspNetCore_ProyectoEscuela.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AnioDeCreacion = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi";
            escuela.Ciudad = "Merida";
            escuela.Pais = "Mexico";
            escuela.Direccion = "Colonia Mexico";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            
            return View(escuela);
        }
    }
}
