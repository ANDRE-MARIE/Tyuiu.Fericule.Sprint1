
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Fericule.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        
        {
            {
                var res = 1 / (Math.Pow(x, 5) + Math.Pow(y, 4));
                return res;
            }
        }
    }
}
