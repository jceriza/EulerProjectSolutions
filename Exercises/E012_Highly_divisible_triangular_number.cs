using System;
using Utilities;

namespace Exercises
{
    public class E012_Highly_divisible_triangular_number
    {
        private static bool HasMoreThan500Divisors(long number)
        {
            var limit = (int)Math.Floor(Math.Sqrt(number));

            if (limit * 2 <= 500) return false;

            var numDivisors = 2;

            for (int i = 3; i <= limit; i++)
            {
                if (number % i == 0)
                {
                    numDivisors += 2;
                }
            }

            return numDivisors > 500;
        }

        public static long FirstTriangleNumberWithOverFiveHundredDivisors()
        {
            var pointReached = false;
            long number = -1;

            for (int i = 1; !pointReached; i += 2)
            {
                number = TriPenHexNumbers.TriangleNumber(i);
                if (HasMoreThan500Divisors(number))
                    pointReached = true;
            }

            return number;
        }
    }
}
