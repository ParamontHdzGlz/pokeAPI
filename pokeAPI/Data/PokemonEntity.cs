using Microsoft.EntityFrameworkCore;

namespace pokeAPI.Data
{
    [Keyless]
    public class PokemonEntity
    {
        public string Name { get; set; }
    }
}
