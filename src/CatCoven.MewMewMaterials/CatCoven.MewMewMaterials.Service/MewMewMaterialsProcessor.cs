﻿// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service.Models;

namespace CatCoven.MewMewMaterials.Service
{
    public class MewMewMaterialsProcessor : IMewMewMaterialsProcessor
    {
        private readonly ILogger _logger;
        private readonly IMewMewMaterialsRepository _mewMewMaterialsRepository;

        public MewMewMaterialsProcessor(
            ILogger<MewMewMaterialsProcessor> logger,
            IMewMewMaterialsRepository mewMewMaterialsRepository)
        {
            _logger = logger;
            _mewMewMaterialsRepository = mewMewMaterialsRepository;
        }

        public Task<Cache> AddMaterials(Reagent reagent, MeowMage meowMage)
        {
            throw new NotImplementedException();
        }

        public Task<Cache> GetCache(string meowMageId)
        {
            throw new NotImplementedException();
        }

        public Task<Cache> UpdateCache(Cache cache)
        {
            throw new NotImplementedException();
        }
    }
}
