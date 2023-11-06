// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service.Models;

namespace CatCoven.MewMewMaterials.Service
{
    public class MewMewMaterialsRepository : IMewMewMaterialsRepository
    {
        private readonly ILogger _logger;

        public MewMewMaterialsRepository(
            ILogger<MewMewMaterialsRepository> logger)
        {
            _logger = logger;
        }

        public Task<Cache> CreateCache(Cache cache)
        {
            throw new NotImplementedException();
        }

        public Task<Cache> GetCache(Guid cacheId)
        {
            throw new NotImplementedException();
        }

        public Task<Cache> UpdateCache(Cache cache)
        {
            throw new NotImplementedException();
        }
    }
}
