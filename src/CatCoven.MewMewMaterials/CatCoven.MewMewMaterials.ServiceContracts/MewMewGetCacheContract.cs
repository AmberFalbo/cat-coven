// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf;

namespace CatCoven.MewMewMaterials.ServiceContracts
{
    [ProtoContract]
    public class MewMewGetCacheContract
    {
        [ProtoMember(1)]
        public string MeowMageId { get; set; }
    }
}