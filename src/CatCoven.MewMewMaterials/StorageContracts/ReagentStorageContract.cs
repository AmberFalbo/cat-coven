// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.StorageContracts
{
    public class ReagentStorageContract
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string FlavorText { get; set; }

        // Foreign Key
        public Guid CacheId { get; set; }

        // Navigation
        public CacheStorageContract Cache { get; set; }
    }
}
