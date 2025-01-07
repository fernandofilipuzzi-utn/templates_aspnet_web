using Cliente.Models;

namespace Cliente.ClientServices
{
    public class PersonaClientService
    {
        async public Task<List<Persona>> GetAll()
        {
            var personas = new List<Persona>();

            string url = "http://localhost:8080/api/Alumnos";

            var cliente = new HttpClient();

            var response = await cliente.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                personas = System.Text.Json.JsonSerializer.Deserialize<List<Persona>>(json);
            }

            return personas;
        }
    }
}
