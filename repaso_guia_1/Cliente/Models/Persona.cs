using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Cliente.Models
{
    public class Persona
    {
        [JsonPropertyName("dni")]
        public int DNI { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
    }
}
