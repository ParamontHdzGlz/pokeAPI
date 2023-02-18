namespace pokeAPI.Data
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonContext _context;
        public PokemonRepository(PokemonContext pokemonContext)
        {
            _context = pokemonContext;
        }


        public IEnumerable<PokemonEntity> GetAllPokemons()
        {
            return _context.Pokemon.ToList();
        }
    }
}
