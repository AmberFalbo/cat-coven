// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.ServiceContracts;

namespace CatCoven.MewMewMaterials.Service
{
    public interface IMewMewMaterialsRequestValidator
    {
        void Validate(MewMewDepositContract request);

        void Validate(MewMewGetCacheContract request);

        void Validate(MewMewUpdateCacheContract request);
    }
}
