using Tyuiu.Fericule.Sprint1.Task1.V8.Lib;

namespace Tyuiu.Fericule.Sprint1.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var DataService = new DataService();
            double x = 2, a = 4;
            double expected = (x * Math.PI) / a;
            Assert.AreEqual(expected, DataService.Calculate(x, a), 5); // précision à 5 décimales
        }
    }
}
