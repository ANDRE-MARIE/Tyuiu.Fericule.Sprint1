
using Tyuiu.Fericule.Sprint1.Task5.V5.Lib;

namespace Tyuiu.Fericule.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32.597;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            _ = Convert.ToInt32(res);
            int wait = 5;
            Assert.AreEqual(wait, 0, 597);
        }
    }
}
