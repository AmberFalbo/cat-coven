// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.Core.ServiceContracts.MewMewMaterials;
using ProtoBuf.Grpc;

namespace CatCoven.MewMewMaterials
{
    public class MewMewMaterialsService : IMewMewMaterialsService
    {
        public Task<MewMewResponseContract> AddMaterials(MewMewDepositContract request, CallContext context = default)
        {
            throw new NotImplementedException();
        }

        public Task<MewMewResponseContract> GetCache(MewMewGetCacheContract request, CallContext context = default)
        {
            throw new NotImplementedException();
        }

        public async Task<MewMewResponseContract> ItLives(CallContext context = default)
        {
            Task.Delay(1).Wait();
            return new MewMewResponseContract();
        }

        public Task<MewMewResponseContract> UpdateCache(MewMewGetCacheContract request, CallContext context = default)
        {
            throw new NotImplementedException();
        }
    }
}
