// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Client.Models;
using CatCoven.MewMewMaterials.ServiceContracts;
using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;

namespace CatCoven.MewMewMaterials.Client
{
    public class MewMewMaterialsClient : IMewMewMaterialsClient
    {
        private readonly IMewMewMaterialsService _client;

        public MewMewMaterialsClient()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7064");
            _client = channel.CreateGrpcService<IMewMewMaterialsService>();
        }

        public async Task<Cache> AddMaterials(string reagentName, int quantity, MeowMage meowMage)
        {
            var requestContract = new MewMewDepositContract
            {
                MeowMage = new MeowMageContract
                {
                    Id = meowMage.Id.ToString(),
                    Name = meowMage.Name
                },
                ReagentName = reagentName,
                Quantity = quantity
            };

            var responseContract = await _client.AddMaterials(requestContract);
            var cacheContract = responseContract.Cache;
            var cache = cacheContract.ToCache();

            return cache;
        }

        public async Task<Cache> GetCache(Guid meowMageId)
        {
            var requestContract = new MewMewGetCacheContract
            {
                MeowMageId = meowMageId.ToString()
            };

            var responseContract = await _client.GetCache(requestContract);
            var cacheContract = responseContract.Cache;
            var cache = cacheContract.ToCache();

            return cache;
        }

        public async Task<bool> ItLives()
        {
            var request = new MewMewDepositContract();
            var response = await _client.ItLives(request);
            return response != null;
        }

        public async Task UpdateCache(Cache cache)
        {
            var requestContract = new MewMewUpdateCacheContract
            {
                Cache = cache.ToContract()
            };

            await _client.UpdateCache(requestContract);
        }
    }
}