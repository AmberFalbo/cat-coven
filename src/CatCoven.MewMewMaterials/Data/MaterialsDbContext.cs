// ------------------------------------
// Cat Coven API
// ------------------------------------

using Microsoft.EntityFrameworkCore;

namespace CatCoven.MewMewMaterials.Data
{
    public class MaterialsDbContext : DbContext
    {
        public MaterialsDbContext(DbContextOptions<MaterialsDbContext> options) : base(options)
        {
        }

        // public DbSet<Model> Name { get; set; }
    }
}