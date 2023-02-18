using Microsoft.AspNetCore.Mvc;
using pokeAPI.Data;
using System.Xml.Linq;

namespace pokeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController: ControllerBase
    {


        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }



        [HttpGet(Name = "GetAllPokemon")]
        public ActionResult<IEnumerable<PokemonEntity>> GetAllPokemon()
        {
            return Ok(_pokemonRepository.GetAllPokemons());
        }
    }
}
