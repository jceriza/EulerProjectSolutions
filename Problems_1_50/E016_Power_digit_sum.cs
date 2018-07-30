using System.Linq;
using Utilities;

namespace Exercises
{
    public class E016_Power_digit_sum
    {
        private static int DigitsSum(LargeNumber num)
        {
            return num
                .ToString()
                .Select(c => int.Parse(c.ToString()))
                .Sum();
        }

        public static int PowerOf2(int power)
        {
            return DigitsSum(LargeNumber.Pow(2, power));
        }
    }
}
