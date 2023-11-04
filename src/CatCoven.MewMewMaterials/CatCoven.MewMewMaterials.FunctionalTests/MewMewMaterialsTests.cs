// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Client;

namespace CatCoven.MewMewMaterials.FunctionalTests
{
    [TestClass]
    public class MewMewMaterialsTests
    {
        private readonly IMewMewMaterialsClient _client;

        public MewMewMaterialsTests()
        {
            _client = new MewMewMaterialsClient();
        }

        [TestMethod]
        public async Task ItLives()
        {
            var result = await _client.ItLives();
            Assert.IsTrue(result);
        }
    }
}