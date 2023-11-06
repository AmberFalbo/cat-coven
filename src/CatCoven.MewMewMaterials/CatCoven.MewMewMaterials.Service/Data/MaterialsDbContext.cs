// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.StorageContracts;
using Microsoft.EntityFrameworkCore;
using System;

namespace CatCoven.MewMewMaterials.Data
{
    public class MaterialsDbContext : DbContext
    {
        public DbSet<CacheStorageContract> Caches { get; set; }
        public DbSet<MeowMageStorageContract> MeowMages { get; set; }
        public DbSet<ReagentStorageContract> Reagents { get; set; }

        public MaterialsDbContext(DbContextOptions<MaterialsDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the primary keys
            modelBuilder.Entity<ReagentStorageContract>().HasKey(x => x.Id);
            modelBuilder.Entity<MeowMageStorageContract>().HasKey(x => x.Id);
            modelBuilder.Entity<CacheStorageContract>().HasKey(x => x.Id);

            // Configure the one-to-one relationship between Cache and MeowMage
            modelBuilder.Entity<CacheStorageContract>()
                .HasOne(x => x.MeowMage)
                .WithOne(x => x.Cache)
                .HasForeignKey<CacheStorageContract>(x => x.MeowMageId);

            // Configure the one-to-many relationship between Cache and Reagents
            modelBuilder.Entity<CacheStorageContract>()
                .HasMany(x => x.Reagents)
                .WithOne(x => x.Cache)
                .HasForeignKey(x => x.CacheId);

            base.OnModelCreating(modelBuilder);
        }
    }
}