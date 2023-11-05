// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service;
using CatCoven.MewMewMaterials.ServiceContracts;
using ProtoBuf.Grpc;

namespace CatCoven.MewMewMaterials
{
    public class MewMewMaterialsService : IMewMewMaterialsService
    {
        private IMewMewMaterialsProcessor mewMewMaterialsProcessor;

        public MewMewMaterialsService(IMewMewMaterialsProcessor mewMewMaterialsProcessor)
        {
            this.mewMewMaterialsProcessor = mewMewMaterialsProcessor;
        }

        public Task<MewMewResponseContract> AddMaterials(MewMewDepositContract request, CallContext context = default)
        {
            throw new NotImplementedException();
        }

        public Task<MewMewResponseContract> GetCache(MewMewGetCacheContract request, CallContext context = default)
        {
            throw new NotImplementedException();
        }

        public async Task<MewMewResponseContract> ItLives(MewMewDepositContract request, CallContext context = default)
        {
            Task.Delay(1).Wait();

            var response = new MewMewResponseContract
            {
                Message = "It lives!"
            };

            return response;
        }

        public Task<MewMewResponseContract> UpdateCache(MewMewGetCacheContract request, CallContext context = default)
        {
            throw new NotImplementedException();
        }
    }
}