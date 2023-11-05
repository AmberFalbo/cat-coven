// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.Service.Models
{
    public class MewMewMaterialsLogEvent
    {
        public string MeowMageId { get; set; }
        public string Operation { get; set; }
        public DateTimeOffset OperationDateTime { get; set; }
        public string Message { get; set; }
    }
}
