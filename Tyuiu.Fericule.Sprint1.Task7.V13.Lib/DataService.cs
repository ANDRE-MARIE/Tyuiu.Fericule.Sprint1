using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Fericule.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
        public double Calculate(double x, double y)
        {
            // C'est LA méthode que l'interface demande d'implémenter.

            {
                // 1. Vérifier les conditions qui peuvent causer une erreur.
                // Ici, on évite une division par zéro si x est 0.
                if (x == 0)
                {
                    throw new DivideByZeroException("Le dénominateur (x) ne peut pas être égal à zéro.");
                }

                // 2. Calculer l'expression. La syntaxe a été corrigée.
                // L'expression semble être : y² - cos(x²) + 10/x² - sin(y²) + 12
                double z = Math.Pow(y, 2)
                           - Math.Cos(Math.Pow(x, 2))
                           + (10 / Math.Pow(x, 2))
                           - Math.Sin(Math.Pow(y, 2))
                           + 12;

                // 3. Retourner le résultat final.
                return z;
            }
        }
    }
}
    
