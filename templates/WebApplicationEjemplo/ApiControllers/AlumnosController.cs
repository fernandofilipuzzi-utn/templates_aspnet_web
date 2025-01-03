using Microsoft.AspNetCore.Mvc;
using WebApplicationEjemplo.Models;

namespace WebApplicationEjemplo.ApiControllers;

[ApiController]
[Route("api/[controller]")]
public class AlumnosController : ControllerBase
{
    // Mock 
    private static readonly List<Alumno> Alumnos = new()
    {
        new Alumno { Id = 1, Nombre = "Ana", Nota = 100 },
        new Alumno { Id = 2, Nombre = "Ema", Nota = 80 },
        new Alumno { Id = 3, Nombre = "Samuel", Nota = 50 }
    };

    // GET: api/alumnos
    [HttpGet]
    public IActionResult GetAlumnos()
    {
        return Ok(Alumnos);
    }

    // GET: api/alumnos/{id}
    [HttpGet("{id}")]
    public IActionResult GetAlumnoById(int id)
    {
        var product = Alumnos.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound(new { Message = "Product not found" });
        }
        return Ok(product);
    }

    // POST: api/alumnos
    [HttpPost]
    public IActionResult CreateAlumno([FromBody] Alumno newProduct)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        newProduct.Id = Alumnos.Count + 1;
        Alumnos.Add(newProduct);
        return CreatedAtAction(nameof(GetAlumnoById), new { id = newProduct.Id }, newProduct);
    }

    // PUT: api/alumnos/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateAlumno(int id, [FromBody] Alumno updatedAlumno)
    {
        var product = Alumnos.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound(new { Message = "Product not found" });
        }

        product.Nombre = updatedAlumno.Nombre;
        product.Nota = updatedAlumno.Nota;
        return NoContent();
    }

    // DELETE: api/productos/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteAlumno(int id)
    {
        var product = Alumnos.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound(new { Message = "Alumno not found" });
        }

        Alumnos.Remove(product);
        return NoContent();
    }
}