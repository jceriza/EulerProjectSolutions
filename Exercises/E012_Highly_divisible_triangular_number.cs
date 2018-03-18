using Utilities;

namespace Exercises
{
    public static class E012_Highly_divisible_triangular_number
    {
        public static long FirstTriangleNumberWithOverFiveHundredDivisors()
        {
            foreach (var number in TriangleNumbers.Generator())
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
