// ------------------------------------
// Cat Coven API
// ------------------------------------

namespace CatCoven.FunctionalTests
{
    [TestClass]
    public class MewMewMaterialsTests : TestBase
    {
        [TestMethod]
        public async Task ItLives()
        {
            var result = await _mewMewMaterialsClient.ItLives();
            Assert.IsNotNull(result);
        }
    }
}