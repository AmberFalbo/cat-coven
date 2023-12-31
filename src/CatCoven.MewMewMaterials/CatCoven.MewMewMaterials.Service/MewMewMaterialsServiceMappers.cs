﻿// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service.Models;
using CatCoven.MewMewMaterials.ServiceContracts;
using CatCoven.MewMewMaterials.StorageContracts;
using Riok.Mapperly.Abstractions;

namespace CatCoven.MewMewMaterials.Service
{
    [Mapper]
    public static partial class MewMewMaterialsServiceMappers
    {
        public static partial Cache ToCache(this CacheContract cacheContract);

        public static partial MeowMage ToMeowMage(this MeowMageContract meowMageContract);

        public static partial Reagent ToReagent(this ReagentContract reagentContract);

        public static partial CacheContract ToContract(this Cache cache);

        public static partial MeowMageContract ToContract(this MeowMage meowMage);

        public static partial ReagentContract ToContract(this Reagent reagent);

        [MapProperty(nameof(Cache.MeowMage.Id), nameof(CacheStorageContract.MeowMageId))]
        public static partial CacheStorageContract ToStorageContract(this Cache cache);

        public static partial MeowMageStorageContract ToStorageContract(this MeowMage meowMage);

        public static partial ReagentStorageContract ToStorageContract(this Reagent reagent);

        public static partial Cache ToCache(this CacheStorageContract storageContract);

        public static partial MeowMage ToMeowMage(this MeowMageStorageContract storageContract);

        public static partial Reagent ToReagent(this ReagentStorageContract storageContract);
    }
}