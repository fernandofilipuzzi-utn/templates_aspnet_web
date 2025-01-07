using Microsoft.AspNetCore.Mvc;
using Servicio.Models;
using Servicio.Services;


namespace Servicio.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        PersonaService servicio=new PersonaService();

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(servicio.GetAll());
            }
            catch
            { 
                return NoContent();
            }
        }

        ////http://localhost:23432/api/alumnos?id={id}
        //[HttpGet]
        //public IActionResult Get(int id)
        //{
        //    return Ok(personas);
        //}

        //http://localhost:23432/api/alumnos/{id}
        [HttpGet("{dni}")]
        public IActionResult Get(int dni)
        {

            try
            {
                if (dni <= 0)
                    return BadRequest("Falta dni");

                return Ok(servicio.GetById(dni));
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
