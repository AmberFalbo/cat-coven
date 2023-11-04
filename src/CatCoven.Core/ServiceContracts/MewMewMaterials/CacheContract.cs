// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf;

namespace CatCoven.Core.ServiceContracts.MewMewMaterials
{
    [ProtoContract]
    public class CacheContract
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        [ProtoMember(2)]
        public MeowMageContract MeowMage { get; set; }

        [ProtoMember(3)]
        public List<ReagentContract> Reagents { get; set; }
    }
}