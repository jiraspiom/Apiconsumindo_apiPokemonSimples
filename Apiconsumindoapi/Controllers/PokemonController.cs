using Apiconsumindoapi.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Apiconsumindoapi.Controllers
{
    [Route("v1")]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        [Route("pokemon")]
        public async Task<IActionResult> Index()
        {

            var servico = new PokemonServices();
            
            //await servico.Pokemon();

            return Ok(await servico.Pokemon());
        }
    }
}
