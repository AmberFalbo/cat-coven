// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.Core.Models;

namespace CatCoven.Core.Clients
{
    public interface IMewMewMaterialsClient
    {
        Task<Cache> AddMaterials(List<Reagent> reagents);
    }
}