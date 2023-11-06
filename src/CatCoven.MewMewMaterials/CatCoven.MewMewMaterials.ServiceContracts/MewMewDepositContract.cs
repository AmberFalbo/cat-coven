// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf;

namespace CatCoven.MewMewMaterials.ServiceContracts
{
    [ProtoContract]
    public class MewMewDepositContract
    {
        [ProtoMember(1)]
        public MeowMageContract MeowMage { get; set; }

        [ProtoMember(2)]
        public string ReagentName { get; set; }

        [ProtoMember(3)]
        public int Quantity { get; set; }
    }
}