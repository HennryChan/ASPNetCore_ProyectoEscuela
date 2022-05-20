using Microsoft.AspNetCore.Mvc;
using AspNetCore_ProyectoEscuela.Models;
using System.Linq;
using System;

namespace AspNetCore_ProyectoEscuela.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CosaDinamica = "La Monja";
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
