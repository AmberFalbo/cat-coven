// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.MewMewMaterials.Service
{
    public class MewMewMaterialsProcessor : IMewMewMaterialsProcessor
    {
        private IMewMewMaterialsRepository _mewMewMaterialsRepository;

        public MewMewMaterialsProcessor(IMewMewMaterialsRepository mewMewMaterialsRepository)
        {
            _mewMewMaterialsRepository = mewMewMaterialsRepository;
        }
    }
}
