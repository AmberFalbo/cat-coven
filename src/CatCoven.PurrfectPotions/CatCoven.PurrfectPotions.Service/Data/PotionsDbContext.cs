// ------------------------------------
// Cat Coven API
// ------------------------------------

using Microsoft.EntityFrameworkCore;

namespace CatCoven.PurrfectPotions.Data
{
    public class PotionsDbContext : DbContext
    {
        public PotionsDbContext(DbContextOptions<PotionsDbContext> options) : base(options)
        {
        }

        // public DbSet<Model> Name { get; set; }
    }
}
