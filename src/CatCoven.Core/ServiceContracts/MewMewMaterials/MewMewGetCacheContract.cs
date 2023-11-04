// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf;

namespace CatCoven.Core.ServiceContracts.MewMewMaterials
{
    [ProtoContract]
    public class MewMewGetCacheContract
    {
        [ProtoMember(1)]
        public string MeowMageId { get; set; }
    }
}