// ------------------------------------
// Cat Coven API
// ------------------------------------

using Grpc.Core;
using ProtoBuf;

namespace CatCoven.Core.ServiceContracts.MewMewMaterials
{
    [ProtoContract]
    public class MewMewResponseContract
    {
        [ProtoMember(1)]
        public StatusCode StatusCode { get; set; }

        [ProtoMember(2)]
        public CacheContract Cache { get; set; }

        [ProtoMember(3)]
        public string Message { get; set; }
    }
}