using Tyuiu.Fericule.Sprint1.Task7.V13.Lib;


namespace Tyuiu.Fericule.Sprint1.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private readonly DataService ds = new DataService();

        [TestMethod]
        public void ValidExpression()
        {
            // Arrange
            double x = 2.0;
            double y = 3.0;
            // CORRECTION : Mettre à jour la valeur attendue avec le bon calcul en radians.
            double expected = 23.742; // C'est la valeur correcte, arrondie à 3 décimales.

            // Act
            double actual = ds.Calculate(x, y);

            // Assert
            double delta = 0.001;
            Assert.AreEqual(expected, actual, delta, "Le calcul avec des valeurs positives est incorrect.");
        }

        [TestMethod]
        public void ValidExpressionWithNegativeValues()
        {
            // Arrange
            double x = -2.0;
            double y = -3.0;
            // CORRECTION : La valeur attendue est la même ici aussi.
            double expected = 23.742;

            // Act
            double actual = ds.Calculate(x, y);

            // Assert
            double delta = 0.001;
            Assert.AreEqual(expected, actual, delta, "Le calcul avec des valeurs négatives est incorrect.");
        }

        [TestMethod]
        public void ExpressionWithDivisionByZero()
        {
            // Arrange
            double x = 0.0;
            double y = 5.0;

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => ds.Calculate(x, y));
        }
    }
}


