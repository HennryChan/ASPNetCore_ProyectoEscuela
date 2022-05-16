using Microsoft.AspNetCore.Mvc;
using AspNetCore_ProyectoEscuela.Models;
using System;

namespace AspNetCore_ProyectoEscuela.Controllers
{
    public class AsignaturaController:Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre= "Programacion"            
            };

            ViewBag.Fecha = DateTime.Now;
            return View(asignatura);
        }
    }
}
