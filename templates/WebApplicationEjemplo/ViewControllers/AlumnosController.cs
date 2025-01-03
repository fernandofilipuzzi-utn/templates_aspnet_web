using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationEjemplo.Models;

namespace WebApplicationEjemplo.Controllers
{
    public class AlumnosController : Controller
    {
        static List<Alumno> lista = new List<Alumno>() {
                new Alumno { Id = 1, Nombre="Ana", Nota=91.5M },
                new Alumno { Id = 2, Nombre="Gerardo", Nota=98M }
            };


        public IActionResult Index()
        {
            return View("Index", lista);
        }

        public IActionResult Editar(int id)
        {
            Alumno alumno= lista.Where(p=> p.Id == id).FirstOrDefault();

            return View("Editar", alumno);
        }

        [HttpPost]
        public IActionResult Editar(Alumno alumno)
        {
            Alumno aEditar= lista.Where(p => p.Id == alumno?.Id).FirstOrDefault();

            aEditar.Nombre= alumno.Nombre;
            aEditar.Nota= alumno.Nota;

            //hacer cambios 
            return RedirectToAction("Index");
        }
    }
}
