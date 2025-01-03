using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Area.BackOffice.ViewControllers
{
    [Area("backoffice")]
    public class AlumnosController : Controller
    {
        // GET: AlumnosController
        public ActionResult Index()
        {
            return View();
        }

       
    }
}
