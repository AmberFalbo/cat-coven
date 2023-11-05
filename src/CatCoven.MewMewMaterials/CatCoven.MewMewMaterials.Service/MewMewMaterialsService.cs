// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service;
using CatCoven.MewMewMaterials.Service.Models;
using CatCoven.MewMewMaterials.Service.Models.Constants;
using CatCoven.MewMewMaterials.ServiceContracts;
using Grpc.Core;
using ProtoBuf.Grpc;

namespace CatCoven.MewMewMaterials
{
    public class MewMewMaterialsService : IMewMewMaterialsService
    {
        private readonly IMewMewMaterialsProcessor _mewMewMaterialsProcessor;
        private readonly IMewMewMaterialsRequestValidator _mewMewMaterialsRequestValidator;

        public MewMewMaterialsService(
            IMewMewMaterialsProcessor mewMewMaterialsProcessor,
            IMewMewMaterialsRequestValidator mewMewMaterialsRequestValidator)
        {
            _mewMewMaterialsProcessor = mewMewMaterialsProcessor;
            _mewMewMaterialsRequestValidator = mewMewMaterialsRequestValidator;
        }

        public async Task<MewMewResponseContract> AddMaterials(MewMewDepositContract request, CallContext context = default)
        {
            _mewMewMaterialsRequestValidator.Validate(request);

            var reagentName = request.ReagentName;
            var quantity = request.Quantity;
            var flavorText = ReagentCatalog.ReagentsDictionary[reagentName];

            var reagent = new Reagent(reagentName, quantity, flavorText);
            var meowMageId = request.MeowMageId;

            try
            {
                var cache = await _mewMewMaterialsProcessor.AddMaterials(reagent, meowMageId);
                var cacheContract = cache.ToContract();

                var meowMageName = cache.MeowMage.Name;
                var response = new MewMewResponseContract
                {
                    Cache = cacheContract,
                    StatusCode = StatusCode.OK,
                    Message = $"Added {quantity} {reagentName}(s) to {meowMageName}'s cache."
                };

                return response;
            }
            catch (Exception ex)
            {
                var response = new MewMewResponseContract
                {
                    Cache = null,
                    StatusCode = StatusCode.Internal,
                    Message = ex.Message
                };

                return response;
            }
        }

        public async Task<MewMewResponseContract> GetCache(MewMewGetCacheContract request, CallContext context = default)
        {
            _mewMewMaterialsRequestValidator.Validate(request);

            var meowMageId = request.MeowMageId;

            try
            {
                var cache = await _mewMewMaterialsProcessor.GetCache(meowMageId);
                var cacheContract = cache.ToContract();

                var meowMageName = cache.MeowMage.Name;
                var response = new MewMewResponseContract
                {
                    Cache = cacheContract,
                    StatusCode = StatusCode.OK,
                    Message = $"Successfully retrieved {meowMageName}'s cache."
                };

                return response;
            }
            catch (Exception ex)
            {
                var response = new MewMewResponseContract
                {
                    Cache = null,
                    StatusCode = StatusCode.Internal,
                    Message = ex.Message
                };

                return response;
            }
        }

        public async Task<MewMewResponseContract> ItLives(MewMewDepositContract request, CallContext context = default)
        {
            await Task.CompletedTask;

            var response = new MewMewResponseContract
            {
                Cache = null,
                StatusCode = StatusCode.OK,
                Message = "It lives!"
            };

            return response;
        }

        public Task<MewMewResponseContract> UpdateCache(MewMewUpdateCacheContract request, CallContext context = default)
        {
            throw new NotImplementedException();
        }
    }
}