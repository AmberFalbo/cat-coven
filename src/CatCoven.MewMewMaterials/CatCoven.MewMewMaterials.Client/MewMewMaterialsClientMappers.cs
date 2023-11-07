// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Client.Models;
using CatCoven.MewMewMaterials.ServiceContracts;
using Riok.Mapperly.Abstractions;

namespace CatCoven.MewMewMaterials.Client
{
    [Mapper]
    public static partial class MewMewMaterialsClientMappers
    {
        public static partial Cache ToCache(this CacheContract cacheContract);

        public static partial MeowMage ToMeowMage(this MeowMageContract meowMageContract);

        public static partial Reagent ToReagent(this ReagentContract reagentContract);

        public static partial CacheContract ToContract(this Cache cache);

        public static partial MeowMageContract ToContract(this MeowMage meowMage);

        public static partial ReagentContract ToContract(this Reagent reagent);
    }
}