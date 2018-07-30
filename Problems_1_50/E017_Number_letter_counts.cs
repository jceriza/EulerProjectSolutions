using System.Linq;
using Utilities;

namespace Exercises
{
    public class E017_Number_letter_counts
    {
        public static int NumberOfLettersInSpelledNumbers(int from, int to)
        {
            int sum = 0;

            for (int num = from; num <= to; num++)
            {
                sum += SpellNumbers
                    .Spell(num)
                    .Split(' ')
                    .Select(w => w.Length)
                    .Sum();
            }

            return sum;
        }
    }
}
