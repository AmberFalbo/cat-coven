// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service.Models;

namespace CatCoven.MewMewMaterials.Service
{
    public interface IMewMewMaterialsProcessor
    {
        Task<Cache> AddMaterials(Reagent reagent, string meowMageId);

        Task<Cache> GetCache(string meowMageId);

        Task<Cache> UpdateCache(Cache cache);
    }
}
