// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Data;
using CatCoven.MewMewMaterials.Service.Models;

namespace CatCoven.MewMewMaterials.Service
{
    public class MewMewMaterialsRepository : IMewMewMaterialsRepository
    {
        private readonly MaterialsDbContext _context;
        private readonly ILogger _logger;

        public MewMewMaterialsRepository(MaterialsDbContext context, ILogger<MewMewMaterialsRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Cache> CreateCache(Cache cache)
        {
            try
            {
                await _context.Caches.AddAsync(cache);
                await _context.SaveChangesAsync();
                return cache;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating a cache.");
                throw;
            }
        }

        public async Task<Cache> GetCache(string cacheId)
        {
            try
            {
                var cache = await _context.Caches.FindAsync(Guid.Parse(cacheId));
                return cache;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving a cache.");
                throw;
            }
        }

        public async Task<Cache> UpdateCache(Cache cache)
        {
            try
            {
                _context.Caches.Update(cache);
                await _context.SaveChangesAsync();
                return cache;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating a cache.");
                throw;
            }
        }

        public async Task DeleteCache(string cacheId)
        {
            try
            {
                var cache = await _context.Caches.FindAsync(Guid.Parse(cacheId));
                if (cache != null)
                {
                    _context.Caches.Remove(cache);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting a cache.");
                throw;
            }
        }
    }
}