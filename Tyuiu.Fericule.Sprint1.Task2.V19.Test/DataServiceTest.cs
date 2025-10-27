using System;
using Tyuiu.Fericule.Sprint1.Task2.V19.Lib;

namespace Tyuiu.Fericule.Sprint1.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test_ConvertInchToKm()
        {
            var converter = new DataService();
            double result = converter.ConvertInchToKm(1000);
            Assert.AreEqual(0.025, result, 25.4);
        }
    }
    }

