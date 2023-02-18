namespace pokeAPI.Data
{
    public interface IPokemonRepository
    {
        public IEnumerable<PokemonEntity> GetAllPokemons();
    }
}
