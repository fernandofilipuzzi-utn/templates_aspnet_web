using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WinFormClienteEjemplo.Models;

namespace WinFormClienteEjemplo.ClientService
{
    public class AlumnosClientService
    {
        string url="http://localhost:5020/api/Alumnos";

        public async Task<List<Alumno>> GetAll()
        {
            List<Alumno> alumnos =new  List<Alumno>();

            string endpoint = $"{url}/";

            using var client = new HttpClient();

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                //ejemplo de cadena esperada
                //"[{\"id\":1,\"nombre\":\"Ana\",\"nota\":100},{\"id\":2,\"nombre\":\"Ema\",\"nota\":80},{\"id\":3,\"nombre\":\"Samuel\",\"nota\":50}]"
                //esto me obliga a usar [JsonProperty("id")] en cada atributo en la clase alumno
                var mensaje = await response.Content.ReadAsStringAsync();

                alumnos = JsonSerializer.Deserialize<List<Alumno>>(mensaje);
            }

            return alumnos;
        }

        public async Task<Alumno> Create(Alumno nuevo)
        {
            Alumno creado = null;

            string endpoint = $"{url}/";

            using var client = new HttpClient();

            //contenido del cuerpo del request
            var json= JsonSerializer.Serialize(nuevo);
            var content = new StringContent( json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url,content);

            if (response.IsSuccessStatusCode)
            {
                var mensaje = await response.Content.ReadAsStringAsync();
                creado = JsonSerializer.Deserialize<Alumno>(mensaje);
            }

            return creado;
        }
    }
}
