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

        public Task<bool> ItLives(CallContext context = default)
        {
            throw new NotImplementedException();
        }

        public Task<MewMewResponseContract> UpdateCache(MewMewGetCacheContract request, CallContext context = default)
        {
            throw new NotImplementedException();
        }
    }
}
