// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.StorageContracts
{
    public class CacheStorageContract
    {
        public Guid Id { get; set; }
        public MeowMageStorageContract MeowMage { get; set; }

        // Foreign Key
        public Guid MeowMageId { get; set; }

        // Navigation
        public IEnumerable<ReagentStorageContract> Reagents { get; set; }
    }
}
