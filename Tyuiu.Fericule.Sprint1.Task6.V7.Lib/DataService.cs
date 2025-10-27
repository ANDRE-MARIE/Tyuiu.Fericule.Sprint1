
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.Fericule.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;

            var mots = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var resultat = mots.Select(m =>
                m.Length > 1 ? m.Substring(0, m.Length - 1) : ""
            );
            return string.Join(" ", resultat);
        }
    }
    }

