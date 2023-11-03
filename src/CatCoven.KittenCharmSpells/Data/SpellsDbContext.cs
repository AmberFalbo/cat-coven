// ------------------------------------
// Cat Coven API
// ------------------------------------

using Microsoft.EntityFrameworkCore;

namespace CatCoven.KittenCharmSpells.Data
{
    public class SpellsDbContext : DbContext
    {
        public SpellsDbContext(DbContextOptions<SpellsDbContext> options) : base(options)
        {
        }

        // public DbSet<Model> Name { get; set; }
    }
}