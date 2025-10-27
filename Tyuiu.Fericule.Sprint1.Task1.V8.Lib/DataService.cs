using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.Fericule.Sprint1.Task1.V8.Lib
{
    public class DataService : ISprint1Task1V8
    {
        public double Calculate(double a, double x)
        {
            if (a == 0) throw new ArgumentException("a ne peut pas être zéro.");
            return (x * Math.PI) / a;
        }
    }
    }
