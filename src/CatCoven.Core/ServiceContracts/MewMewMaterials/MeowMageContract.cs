// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf;

namespace CatCoven.Core.ServiceContracts.MewMewMaterials
{
    [ProtoContract]
    public class MeowMageContract
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public string FlavorText { get; set; }
    }
}