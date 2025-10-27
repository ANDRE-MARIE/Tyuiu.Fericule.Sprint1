
using Tyuiu.Fericule.Sprint1.Task0.V15.Lib;

namespace Tyuiu.Fericule.Sprint1.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(3.0, res); // ou bien Assert.AreEqual(3, res) fonctionnera car 3.0 == 3
        }
    }
}
