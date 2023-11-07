// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service.Models;
using CatCoven.MewMewMaterials.Service.Models.Constants;
using CatCoven.MewMewMaterials.ServiceContracts;
using Grpc.Core;
using ProtoBuf.Grpc;

namespace CatCoven.MewMewMaterials.Service
{
    public class MewMewMaterialsService : IMewMewMaterialsService
    {
        private readonly ILogger _logger;
        private readonly IMewMewMaterialsProcessor _mewMewMaterialsProcessor;
        private readonly IMewMewMaterialsRequestValidator _mewMewMaterialsRequestValidator;

        public MewMewMaterialsService(
            ILogger<MewMewMaterialsService> logger,
            IMewMewMaterialsProcessor mewMewMaterialsProcessor,
            IMewMewMaterialsRequestValidator mewMewMaterialsRequestValidator)
        {
            _logger = logger;
            _mewMewMaterialsProcessor = mewMewMaterialsProcessor;
            _mewMewMaterialsRequestValidator = mewMewMaterialsRequestValidator;
        }

        public async Task<MewMewResponseContract> AddMaterials(MewMewDepositContract request, CallContext context = default)
        {
            _mewMewMaterialsRequestValidator.Validate(request);

            var meowMageId = request.MeowMage.Id;

            try
            {
                var reagentName = request.ReagentName;
                var quantity = request.Quantity;
                var flavorText = ReagentCatalog.ReagentsDictionary[reagentName];

                var reagent = new Reagent(reagentName, quantity, flavorText);
                var meowMage = request.MeowMage.ToMeowMage();

                var cache = await _mewMewMaterialsProcessor.AddMaterials(reagent, meowMage);
                var cacheContract = cache.ToContract();

                var meowMageName = cache.MeowMage.Name;
                var message = $"Successfully added {quantity} {reagentName}(s) to {meowMageName}'s cache.";
                var response = new MewMewResponseContract
                {
                    Cache = cacheContract,
                    StatusCode = StatusCode.OK,
                    Message = message
                };

                LogSuccess(cache, message);
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

                LogFailure(meowMageId, ex);
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
                var message = $"Successfully retrieved {meowMageName}'s cache.";

                var response = new MewMewResponseContract
                {
                    Cache = cacheContract,
                    StatusCode = StatusCode.OK,
                    Message = message
                };

                LogSuccess(cache, message);
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

                LogFailure(meowMageId, ex);
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

        public async Task<MewMewResponseContract> UpdateCache(MewMewUpdateCacheContract request, CallContext context = default)
        {
            _mewMewMaterialsRequestValidator.Validate(request);

            var meowMageId = request.Cache.MeowMage.Id;

            try
            {
                var cache = request.Cache.ToCache();

                await _mewMewMaterialsProcessor.UpdateCache(cache);

                var cacheContract = cache.ToContract();
                var meowMageName = cache.MeowMage.Name;
                var message = $"Successfully updated cache for {meowMageName}";

                var response = new MewMewResponseContract
                {
                    Cache = cacheContract,
                    StatusCode = StatusCode.OK,
                    Message = message
                };

                LogSuccess(cache, message);
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

                LogFailure(meowMageId, ex);
                return response;
            }
        }

        private void LogSuccess(Cache cache, string message)
        {
            var logEvent = new MewMewMaterialsSuccessEvent()
            {
                MeowMageId = cache.MeowMage.Id.ToString(),
                Operation = Operation.AddMaterials,
                OperationDateTime = DateTimeOffset.UtcNow,
                Message = message
            };

            _logger.LogInformation(nameof(MewMewMaterialsSuccessEvent), logEvent);
        }

        private void LogFailure(string meowMageId, Exception ex)
        {
            var logEvent = new MewMewMaterialsFailureEvent()
            {
                MeowMageId = meowMageId,
                Operation = Operation.AddMaterials,
                OperationDateTime = DateTimeOffset.UtcNow,
                Exception = ex,
                Message = ex.Message,
                InnerExceptionMessage = ex.InnerException?.Message
            };

            _logger.LogError(ex, nameof(MewMewMaterialsFailureEvent), logEvent);
        }
    }
}