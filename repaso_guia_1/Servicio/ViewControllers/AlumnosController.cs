using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Servicio.Controllers;

public class AlumnosController : Controller
{
    // GET: AlumnosController1
    public ActionResult Index()
    {
        return View();
    }

    // GET: AlumnosController1/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: AlumnosController1/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: AlumnosController1/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: AlumnosController1/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: AlumnosController1/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: AlumnosController1/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: AlumnosController1/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
