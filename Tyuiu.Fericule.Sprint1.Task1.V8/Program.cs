
using Tyuiu.Fericule.Sprint1.Task1.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        var DataService = new DataService();

        Console.WriteLine("Entrez la valeur de x :");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entrez la valeur de a :");
        double a = Convert.ToDouble(Console.ReadLine());

        try
        {
            double result = DataService.Calculate(x, a);
            Console.WriteLine($"Résultat = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }
}