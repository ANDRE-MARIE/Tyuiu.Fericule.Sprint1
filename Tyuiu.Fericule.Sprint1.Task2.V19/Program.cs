
using System;
using Tyuiu.Fericule.Sprint1.Task2.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        var converter = new DataService();

        Console.WriteLine("Entrez la distance en pouces :");
        int inches = Convert.ToInt32(Console.ReadLine());

        double km = converter.ConvertInchToKm(inches);
        Console.WriteLine($"Distance en kilomètres : {km}");
    }
}