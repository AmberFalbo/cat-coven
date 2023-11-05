// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.Service.Models
{
    public class MewMewMaterialsFailureEvent : MewMewMaterialsLogEvent
    {
        public Exception Exception { get; set; }
        public string InnerExceptionMessage { get; set; }
    }
}
