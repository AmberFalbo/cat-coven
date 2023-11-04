// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.Core.Clients;

namespace CatCoven.FunctionalTests
{
    public class TestBase
    {
        public readonly IMewMewMaterialsClient _mewMewMaterialsClient;

        public TestBase()
        {
            _mewMewMaterialsClient = new MewMewMaterialsClient();
        }
    }
}