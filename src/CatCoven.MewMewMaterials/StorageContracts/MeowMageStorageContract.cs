// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.StorageContracts
{
    public class MeowMageStorageContract
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FlavorText { get; set; }

        // Navigation
        public CacheStorageContract Cache { get; set; } 
    }
}
