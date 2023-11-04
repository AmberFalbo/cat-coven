// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.Core.Models;

namespace CatCoven.Core.Clients
{
    public interface IMewMewMaterialsClient
    {
        Task<Cache> AddMaterials(List<Reagent> reagents);

        Task<Cache> GetCache(Guid meowMageId);

        Task<Cache> UpdateCache(Cache cache);

        Task<bool> ItLives();
    }
}