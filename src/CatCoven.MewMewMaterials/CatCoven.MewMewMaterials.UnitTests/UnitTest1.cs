// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Service;
using CatCoven.MewMewMaterials.ServiceContracts;

namespace CatCoven.MewMewMaterials.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cacheContract = new CacheContract()
            {
                Id = Guid.NewGuid().ToString(),
                MeowMage = new MeowMageContract()
                {
                    Name = "Test MeowMage"
                },
                Reagents = new List<ReagentContract>()
            };

            var cache = cacheContract.ToCache();

            Assert.AreEqual(cacheContract.Id, cache.Id.ToString());
            Assert.AreEqual(cacheContract.MeowMage.Name, cache.MeowMage.Name);
            Assert.IsNotNull(cache.Reagents);
        }
    }
}