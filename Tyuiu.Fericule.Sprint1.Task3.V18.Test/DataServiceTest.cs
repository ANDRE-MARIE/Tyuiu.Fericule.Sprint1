using Tyuiu.Fericule.Sprint1.Task3.V18.Lib;

namespace Tyuiu.Fericule.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [DataTestMethod]
        [DataRow(10, 10, 2, 25)]
        [DataRow(9, 6, 2, 12)]

        public void ValidExpression(double A, double B, double C, double expected)
            {
            var DataService = new DataService();
            double result = DataService.HowManySquares(A, B, C);
                Assert.AreEqual(expected, result, 3);
            }

            
            public void SquaresInRectangle_C_NegativeOrZero_ThrowsException()
            {
            var calculator = new DataService();
            Assert.ThrowsException<ArgumentException>(() => calculator.HowManySquares(10, 10, 0));
            Assert.ThrowsException<ArgumentException>(() => calculator.HowManySquares(10, 10, -2));
        }
        }
    }

