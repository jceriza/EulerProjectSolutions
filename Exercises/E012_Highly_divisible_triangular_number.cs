using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E012_Highly_divisible_triangular_number
    {
        public static long FirstTriangleNumberWithOverFiveHundredDivisors()
        {
            var threshold = 500 * 500 - 1;

            foreach (var number in TriangleNumbers.Generator().SkipWhile(t => t < threshold))
            {
                if (Divisors.AllDivisors(number).Count > 500)
                {
                    return number;
                }
            }

            return -1;
        }
    }
}
