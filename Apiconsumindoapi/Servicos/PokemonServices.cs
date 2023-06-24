using Apiconsumindoapi.Entidades;
using Newtonsoft.Json;

namespace Apiconsumindoapi.Servicos
{
    public class PokemonServices
    {
        public async Task<Pokemon> Pokemon()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/pikachu");
            var jsonString = await response.Content.ReadAsStringAsync();

            var jsonObjeto = JsonConvert.DeserializeObject<Pokemon>(jsonString);

            return jsonObjeto;
          
        }
    }
}
