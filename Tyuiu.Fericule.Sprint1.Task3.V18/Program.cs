using Tyuiu.Fericule.Sprint1.Task3.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        var DataService = new DataService();

        Console.WriteLine("Entrez la dimension A du rectangle :");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entrez la dimension B du rectangle :");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entrez la taille C du côté du carré :");
        double C = Convert.ToDouble(Console.ReadLine());

        try
        {
            double nbCarres = DataService.HowManySquares(A, B, C);
            Console.WriteLine($"Nombre de carrés dans le rectangle : {nbCarres}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
    }
}