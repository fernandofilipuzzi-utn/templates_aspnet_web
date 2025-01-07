using Microsoft.AspNetCore.Mvc;
using Servicio.Models;

namespace Servicio.Services
{
    public class PersonaService
    {

        static List<PersonaDTO> personas = new List<PersonaDTO>()
        {
            new PersonaDTO(){ DNI=2323, Nombre="Bernardo" }
        };

        public List<PersonaDTO> GetAll()
        { 
            return personas.OrderBy(p=>p.Nombre).ToList();
        }

        public PersonaDTO GetById(int dni)
        {
            return personas.Where(p => p.DNI == dni).First();
            
        }
    }
}
