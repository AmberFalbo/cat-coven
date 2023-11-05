// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service.Models.Constants;
using CatCoven.MewMewMaterials.ServiceContracts;
using Grpc.Core;

namespace CatCoven.MewMewMaterials.Service
{
    public class MewMewMaterialsRequestValidator : IMewMewMaterialsRequestValidator
    {
        public void Validate(MewMewGetCacheContract request)
        {
            if (request == null)
            {
                var message = "Request is null";
                Throw(message);
            }

            if (!Guid.TryParse(request.MeowMageId, out var _))
            {
                var message = $"MeowMage Id {request.MeowMageId} is not a valid Id format, expected Guid.";
                Throw(message);
            }
        }

        public void Validate(MewMewUpdateCacheContract request)
        {
            if (request == null)
            {
                var message = "Request is null";
                Throw(message);
            }

            if (request.Cache == null)
            {
                var message = "Cache is null";
                Throw(message);
            }

            if (!Guid.TryParse(request.Cache.Id, out var _))
            {
                var message = $"Cache Id {request.Cache.Id} is not a valid Id format, expected Guid.";
                Throw(message);
            }
        }

        public void Validate(MewMewDepositContract request)
        {
            var failureMessages = new List<string>();

            if (request == null)
            {
                var message = "Request is null";
                Throw(message);
            }

            if (!Guid.TryParse(request.MeowMageId, out var _))
            {
                var message = $"MeowMage Id {request.MeowMageId} is not a valid Id format, expected Guid.";
                failureMessages.Add(message);
            }

            if (!ReagentCatalog.ReagentsDictionary.ContainsKey(request.ReagentName))
            {
                var message = $"Reagent name {request.ReagentName} is not a known reagent name.";
                failureMessages.Add(message);
            }

            if (request.Quantity < 1)
            {
                var message = $"Deposit amount = {request.Quantity} quantity cannot be less than 1.";
                failureMessages.Add(message);
            }

            if (failureMessages.Any())
            {
                var message = string.Join(", ", failureMessages);
                Throw(message);
            }
        }

        private static void Throw(string message)
        {
            var status = new Status(StatusCode.InvalidArgument, message);

            throw new RpcException(status);
        }
    }
}
