// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Models;
using CatCoven.MewMewMaterials.StorageContracts;

namespace CatCoven.MewMewMaterials
{
    public static class MewMewMaterialsMappers
    {
        public static MeowMage ToMeowMage(this MeowMageStorageContract meowMageStorageContract)
        {
            var meowMage = new MeowMage(
                meowMageStorageContract.Name,
                meowMageStorageContract.FlavorText)
            {
                Id = meowMageStorageContract.Id
            };

            return meowMage;
        }

        public static List<Reagent> ToReagents(this IEnumerable<ReagentStorageContract> reagentStorageContracts)
        {
            var reagents = new List<Reagent>();

            foreach (var reagentStorageContract in reagentStorageContracts)
            {
                var reagent = new Reagent(
                    reagentStorageContract.Name,
                    reagentStorageContract.Quantity,
                    reagentStorageContract.FlavorText)
                {
                    Id = reagentStorageContract.Id
                };

                reagents.Add(reagent);
            }

            return reagents;
        }

        public static Cache ToCache(this CacheStorageContract cacheStorageContract)
        {
            var meowMage = cacheStorageContract.MeowMage.ToMeowMage();
            var reagents = cacheStorageContract.Reagents.ToReagents();

            var cache = new Cache(meowMage)
            {
                Id = cacheStorageContract.Id,
                Reagents = reagents
            };  

            return cache;
        }
    }
}