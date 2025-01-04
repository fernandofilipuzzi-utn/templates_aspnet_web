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

            var response = await client.GetAsync(endpoint);

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

        async public Task<Alumno> GetById(int id)
        {
            Alumno alumno = null;

            string endpoint = $"{url}/{id}";

            using var client = new HttpClient();

            var response = await client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                //ejemplo de cadena esperada
                var mensaje = await response.Content.ReadAsStringAsync();

                alumno = JsonSerializer.Deserialize<Alumno>(mensaje);
            }

            return alumno;
        }

        async public Task<Alumno> Create(Alumno nuevo)
        {
            Alumno creado = null;

            string endpoint = $"{url}/";

            using var client = new HttpClient();

            //contenido del cuerpo del request
            var json= JsonSerializer.Serialize(nuevo);
            var content = new StringContent( json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                var mensaje = await response.Content.ReadAsStringAsync();
                creado = JsonSerializer.Deserialize<Alumno>(mensaje);
            }

            return creado;
        }

        async public Task<Alumno> Actualizar(Alumno nuevo)
        {
            Alumno actualizado = null;

            string endpoint = $"{url}/";

            using var client = new HttpClient();

            var json = JsonSerializer.Serialize(nuevo);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                var mensaje = await response.Content.ReadAsStringAsync();
                actualizado = JsonSerializer.Deserialize<Alumno>(mensaje);
            }

            return actualizado;
        }

        async public Task Eliminar(int id)
        {
            string endpoint = $"{url}/{id}";

            using var client = new HttpClient();

            var response = await client.DeleteAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                
            }

        }
    }
}
