// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service.Models;

namespace CatCoven.MewMewMaterials.Service
{
    public interface IMewMewMaterialsRepository
    {
        Task CreateCache(Cache cache);

        Task<Cache> GetCache(string cacheId);

        Task UpdateCache(Cache cache);
    }
}