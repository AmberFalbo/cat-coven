// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Client.Models;

namespace CatCoven.MewMewMaterials.Client
{
    public interface IMewMewMaterialsClient
    {
        Task<Cache> AddMaterials(List<Reagent> reagents);

        Task<Cache> GetCache(Guid meowMageId);

        Task<Cache> UpdateCache(Cache cache);

        Task<bool> ItLives();
    }
}