
using Google.Protobuf.WellKnownTypes;
using System.Diagnostics;
using Tyuiu.Fericule.Sprint1.Task6.V7.Lib;

internal class Program
{
    static void Main()
    {
        DataService processor = new DataService();

        Console.WriteLine("Saisissez une phrase :");
        string input = Console.ReadLine();

        string output = processor.DeleteLastLetter(input);

        Console.WriteLine("Résultat : " + output);
    }
}