
using Tyuiu.Fericule.Sprint1.Task0.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        double result = ds.Calculate();
        Console.WriteLine("Le résultat de l'expression (30/6-4)*3 est : " + result); ;
    }
}