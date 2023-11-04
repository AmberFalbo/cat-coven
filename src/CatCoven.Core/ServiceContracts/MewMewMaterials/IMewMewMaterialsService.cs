// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace CatCoven.Core.ServiceContracts.MewMewMaterials
{
    [Service]
    public interface IMewMewMaterialsService
    {
        Task<MewMewResponseContract> AddMaterials(MewMewDepositContract request, CallContext context = default);

        Task<MewMewResponseContract> GetCache(MewMewGetCacheContract request, CallContext context = default);

        Task<MewMewResponseContract> UpdateCache(MewMewGetCacheContract request, CallContext context = default);
    }
}