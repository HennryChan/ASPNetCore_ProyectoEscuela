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
            escuela.AnioFundacion = 2005;
            escuela.EscualaId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi";
            return View(escuela);
        }
    }
}
