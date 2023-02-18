using Microsoft.EntityFrameworkCore;

namespace pokeAPI.Data
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions options) : base(options) { }
        public DbSet<PokemonEntity> Pokemon { get; set; }

    }
}
