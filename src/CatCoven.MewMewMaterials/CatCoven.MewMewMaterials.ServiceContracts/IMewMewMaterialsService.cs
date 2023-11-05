// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace CatCoven.MewMewMaterials.ServiceContracts
{
    [Service]
    public interface IMewMewMaterialsService
    {
        Task<MewMewResponseContract> AddMaterials(MewMewDepositContract request, CallContext context = default);

        Task<MewMewResponseContract> GetCache(MewMewGetCacheContract request, CallContext context = default);

        Task<MewMewResponseContract> UpdateCache(MewMewUpdateCacheContract request, CallContext context = default);

        Task<MewMewResponseContract> ItLives(MewMewDepositContract request, CallContext context = default);
    }
}