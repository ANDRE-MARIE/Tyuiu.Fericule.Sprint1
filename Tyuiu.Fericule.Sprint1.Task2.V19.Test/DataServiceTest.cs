using System;
using Tyuiu.Fericule.Sprint1.Task2.V19.Lib;

namespace Tyuiu.Fericule.Sprint1.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void InchesToMeters_ShouldConvertCorrectly(int input, double expected)
        {
            var converter = new DataService();
            double result = converter.ConvertInchToKm(input);
            Assert.AreEqual(expected, result, 3); // précision à 3 décimales
        }
    }
    }

