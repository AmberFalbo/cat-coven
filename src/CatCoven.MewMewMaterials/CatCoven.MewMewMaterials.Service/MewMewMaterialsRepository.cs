// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Data;
using CatCoven.MewMewMaterials.Service.Models;
using CatCoven.MewMewMaterials.Service.Models.Constants;

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

        public async Task CreateCache(Cache cache)
        {
            try
            {
                var cacheStorageContract = cache.ToStorageContract();
                var storedCacheContract = await _context.Caches.AddAsync(cacheStorageContract);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                LogFailure("An error occurred while creating a cache.", ex);
                throw;
            }
        }

        public async Task<Cache> GetCache(string cacheId)
        {
            try
            {
                var cacheStorageContract = await _context.Caches.FindAsync(Guid.Parse(cacheId));
                var cache = cacheStorageContract.ToCache();
                return cache;
            }
            catch (Exception ex)
            {
                LogFailure("An error occurred while retrieving a cache.", ex);
                throw;
            }
        }

        public async Task UpdateCache(Cache cache)
        {
            try
            {
                var cacheStorageContract = cache.ToStorageContract();
                _context.Caches.Update(cacheStorageContract);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                LogFailure("An error occurred while updating a cache.", ex);
                throw;
            }
        }

        private void LogFailure(string meowMageId, Exception ex)
        {
            var logEvent = new MewMewMaterialsFailureEvent()
            {
                MeowMageId = meowMageId,
                Operation = Operation.AddMaterials,
                OperationDateTime = DateTimeOffset.UtcNow,
                Exception = ex,
                Message = ex.Message,
                InnerExceptionMessage = ex.InnerException?.Message
            };

            _logger.LogError(ex, nameof(MewMewMaterialsFailureEvent), logEvent);
        }
    }
}