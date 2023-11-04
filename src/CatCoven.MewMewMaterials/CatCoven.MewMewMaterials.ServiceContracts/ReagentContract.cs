// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf;

namespace CatCoven.MewMewMaterials.ServiceContracts
{
    [ProtoContract]
    public class ReagentContract
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public int Quantity { get; set; }

        [ProtoMember(4)]
        public string FlavorText { get; set; }
    }
}