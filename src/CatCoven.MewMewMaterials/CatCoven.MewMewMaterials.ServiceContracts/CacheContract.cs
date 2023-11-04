// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf;

namespace CatCoven.MewMewMaterials.ServiceContracts
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