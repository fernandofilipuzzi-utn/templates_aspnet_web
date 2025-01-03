using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using WebApplicationEjemplo.Models;
using WebApplicationEjemplo.Services;

namespace WebApplicationEjemplo.ApiControllers;

[ApiController]
[Route("api/[controller]")]
public class AlumnosController : ControllerBase
{
    // Mock 
    AlumnosService service = new AlumnosService(); 

    // GET: api/alumnos
    [HttpGet]
    public IActionResult GetAlumnos()
    {
        return Ok(service.GetAll());
    }

    // GET: api/alumnos/{id}
    [HttpGet("{id}")]
    public IActionResult GetAlumnoById(int id)
    {
        Alumno alumno=new Alumno();
        if (alumno == null)
        {
            return NotFound(new { Message = "Alumno no encontrado" });
        }
        return Ok(alumno);
    }

    // POST: api/alumnos
    [HttpPost]
    public IActionResult CreateAlumno([FromBody] Alumno nuevoAlumno)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        Alumno nuevo=service.Create(nuevoAlumno);

        //investigar el 201=createAtAction
        return CreatedAtAction("CreateAlumno", new { id = nuevoAlumno.Id }, nuevoAlumno);
    }

    // PUT: api/alumnos/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateAlumno([FromBody] Alumno actualizarAlumno)
    {
        if (service.Update(actualizarAlumno) == false)
        {
            return NotFound(new { Message = "Alumno no encontrado" });
        }

        return NoContent();
    }

    // DELETE: api/productos/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteAlumno(int id)
    {
        if (service.Delete(id) == false)
        {
            return NotFound(new { Message = "Alumno no encontrado" });
        }
        return NoContent();//204
    }
}