// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.StorageContracts;
using Microsoft.EntityFrameworkCore;

namespace CatCoven.MewMewMaterials.Data
{
    public class MaterialsDbContext : DbContext
    {
        public MaterialsDbContext(DbContextOptions<MaterialsDbContext> options) : base(options)
        {
        }

        public DbSet<CacheStorageContract> Caches { get; set; }
        public DbSet<MeowMageStorageContract> MeowMages { get; set; }
        public DbSet<ReagentStorageContract> Reagents { get; set; }
    }
}