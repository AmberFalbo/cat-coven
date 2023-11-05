// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service.Models;
using CatCoven.MewMewMaterials.ServiceContracts;
using Riok.Mapperly.Abstractions;

namespace CatCoven.MewMewMaterials.Service
{
    [Mapper]
    public static partial class MewMewMaterialsMappers
    {
        public static partial Cache ToCache(this CacheContract cacheContract);

        public static partial MeowMage ToMeowMage(this MeowMageContract meowMageContract);

        public static partial Reagent ToReagent(this ReagentContract reagentContract);
    }
}