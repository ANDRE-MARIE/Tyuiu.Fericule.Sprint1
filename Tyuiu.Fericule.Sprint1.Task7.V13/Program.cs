
using Tyuiu.Fericule.Sprint1.Task7.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
     
        {
            // 2. Créer une instance de votre service de calcul
            // C'est cet objet qui contient la logique métier.
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* SPRINT #1                                                               *");
            Console.WriteLine("* TÂCHE #7                                                                *");
            Console.WriteLine("* VARIATION #13                                                             *");
            Console.WriteLine("* EFFECTUÉ PAR : [VOTRE NOM]                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* CONDITION :                                                             *");
            Console.WriteLine("* Écrire un programme qui demande à l'utilisateur des données sources,    *");
            Console.WriteLine("* calcule le résultat selon la formule et l'affiche à l'écran.          *");
            Console.WriteLine("* Formule : y² - cos(x²) + 10/x² - sin(y²) + 12                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* DONNÉES SOURCES :                                                       *");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Demande à l'utilisateur de saisir les valeurs
                Console.Write("Veuillez entrer la valeur de x : ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Veuillez entrer la valeur de y : ");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* RÉSULTAT :                                                              *");
                Console.WriteLine("***************************************************************************");

                // 3. Appeler la méthode 'Calculate' de l'instance de DataService
                // C'est ici que la magie opère : on utilise la logique de la bibliothèque.
                double resultat = ds.Calculate(x, y);

                // Afficher le résultat arrondi à trois décimales
                Console.WriteLine($"Le résultat de l'expression est : {Math.Round(resultat, 3)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erreur : Veuillez entrer des nombres valides.");
            }
            catch (DivideByZeroException ex)
            {
                // On peut afficher le message personnalisé défini dans la bibliothèque
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur inattendue est survenue : {ex.Message}");
            }

            Console.ReadKey();
        }
    }

}
