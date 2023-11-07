// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service.Models;

namespace CatCoven.MewMewMaterials.Service
{
    public class MewMewMaterialsProcessor : IMewMewMaterialsProcessor
    {
        private readonly IMewMewMaterialsRepository _mewMewMaterialsRepository;

        public MewMewMaterialsProcessor(
            IMewMewMaterialsRepository mewMewMaterialsRepository)
        {
            _mewMewMaterialsRepository = mewMewMaterialsRepository;
        }

        public async Task<Cache> AddMaterials(Reagent reagent, MeowMage meowMage)
        {
            var cache = await GetCache(meowMage.Id.ToString());

            if (cache == null)
            {
                var newCache = new Cache(meowMage);
                newCache.AddReagent(reagent);
                await _mewMewMaterialsRepository.CreateCache(newCache);

                return newCache;
            }

            cache.AddReagent(reagent);
            await _mewMewMaterialsRepository.UpdateCache(cache);

            return cache;
        }

        public async Task<Cache> GetCache(string meowMageId)
        {
            var cache = await _mewMewMaterialsRepository.GetCache(meowMageId);
            return cache;
        }

        public async Task UpdateCache(Cache cache)
        {
            await _mewMewMaterialsRepository.UpdateCache(cache);
        }
    }
}