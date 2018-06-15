using Utilities;

namespace Exercises
{
    public static class E012_Highly_divisible_triangular_number
    {
        public static long FirstTriangleNumberWithOverFiveHundredDivisors()
        {
            var threshold = 500 * 500 - 1;

            var i = (int)TriPenHexNumbers.TriangleNumberIndex(threshold);

            long number;

            do
            {
                number = TriPenHexNumbers.TriangleNumber(i++);
            } while (Divisors.AllDivisors(number).Count <= 500);

            return number;
        }
    }
}
