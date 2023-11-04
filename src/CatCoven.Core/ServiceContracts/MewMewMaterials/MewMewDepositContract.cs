// ------------------------------------
// Cat Coven API
// ------------------------------------

using ProtoBuf;

namespace CatCoven.Core.ServiceContracts.MewMewMaterials
{
    [ProtoContract]
    public class MewMewDepositContract
    {
        [ProtoMember(1)]
        public string MeowMageId { get; set; }

        [ProtoMember(2)]
        public string ReagentName { get; set; }

        [ProtoMember(3)]
        public int Quantity { get; set; }
    }
}