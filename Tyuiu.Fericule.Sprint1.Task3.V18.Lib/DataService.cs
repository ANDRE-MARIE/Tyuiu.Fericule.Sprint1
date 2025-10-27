
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Fericule.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            if (c <= 0) throw new ArgumentException("La taille du carré doit être positive.");
            if (a <= 0 || b <= 0) throw new ArgumentException("Les dimensions du rectangle doivent être positives.");
            double countA = Math.Floor(a / c);
            double countB = Math.Floor(b / c);
            double count = countA * countB;
            return Math.Round(count, 3);
        }
    }
}
