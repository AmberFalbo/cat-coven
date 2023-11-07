// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Client.Models;

namespace CatCoven.MewMewMaterials.Client
{
    public interface IMewMewMaterialsClient
    {
        Task<Cache> AddMaterials(string reagentName, int quantity, MeowMage meowMage);

        Task<Cache> GetCache(Guid meowMageId);

        Task UpdateCache(Cache cache);

        Task<bool> ItLives();
    }
}