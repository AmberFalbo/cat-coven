// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.StorageContracts
{
    public class CacheStorageContract
    {
        public Guid Id { get; set; }

        // Navigation properties
        public Guid MeowMageId { get; set; }
        public MeowMageStorageContract MeowMage { get; set; }
        public IEnumerable<ReagentStorageContract> Reagents { get; set; }
    }
}
