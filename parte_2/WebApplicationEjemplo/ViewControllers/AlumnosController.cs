using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationEjemplo.Models;
using WebApplicationEjemplo.Services;

namespace WebApplicationEjemplo.Controllers
{
    public class AlumnosController : Controller
    {
        AlumnosService service = new AlumnosService();


        public IActionResult Index()
        {
            return View("Index", service.GetAll());
            //return View("Index", new List<Alumno>());
        }

        public IActionResult Editar(int id)
        {
            Alumno alumno = service.GetById(id);

            return View("Editar", alumno);
        }

        [HttpPost]
        public IActionResult Editar(Alumno alumno)
        {
            service.Update(alumno);

            //hacer cambios 
            return RedirectToAction("Index");
        }
    }
}
