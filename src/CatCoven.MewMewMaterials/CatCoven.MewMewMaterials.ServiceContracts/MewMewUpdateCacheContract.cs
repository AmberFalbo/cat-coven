// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf;

namespace CatCoven.MewMewMaterials.ServiceContracts
{
    [ProtoContract]
    public class MewMewUpdateCacheContract
    {
        [ProtoMember(1)]
        public CacheContract Cache { get; set; }
    }
}