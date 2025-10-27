using Tyuiu.Fericule.Sprint1.Task6.V7.Lib;

namespace Tyuiu.Fericule.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestSupprimerDerniereLettre_Fonctionne()
        {
            // Arrange : Initialiser les objets nécessaires pour le test.
            var processor = new DataService();
            var texteInitial = "bonjour tout le monde";
            var resultatAttendu = "bonjou tou l mond";

            // Act : Exécuter la méthode que l'on souhaite tester.
            string resultatActuel = processor.DeleteLastLetter(texteInitial);

            // Assert : Vérifier que le résultat obtenu est bien celui attendu.
            Assert.AreEqual(resultatAttendu, resultatActuel);
        }
    }
}