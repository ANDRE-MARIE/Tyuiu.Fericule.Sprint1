
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.Fericule.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double res = Math.Floor(x);
            return (int)Math.Floor(x * res);
        }
    }
}
