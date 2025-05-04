using WeatherApiSandbox.Utils;

namespace WeatherApiSandbox.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void ReturnName()
        {
            string name = new RandomClass().ReturnName();

            Assert.AreEqual(name, "Alex");
        }
    }
}