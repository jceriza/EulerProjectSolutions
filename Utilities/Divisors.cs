using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class Divisors
    {
        private static List<long> GetAllDivisors(long number)
        {
            if (number == 0) return new List<long>();
            if (number == 1) return new List<long> { 1 };

            var limit = (int)Math.Floor(Math.Sqrt(number));

            var factors = new List<long> { 1, number };

            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)    
                {
                    var divisor = number / i;

                    factors.Insert(factors.Count / 2, divisor);

                    if (divisor != i)
                        factors.Insert(factors.Count / 2, i);
                }
            }

            return factors;
        }

        public static (long numerator, long denominator) LowestCommonTerms(long numerator, long denominator)
        {
            var numeratorDivisors = AllDivisors(numerator);
            var denominatorDivisors = AllDivisors(denominator);
            var commonDivisors = new List<long>();

            for (int i = 1; i < numeratorDivisors.Count; i++)
            {
                if (denominatorDivisors.ContainsWithBinarySearch(numeratorDivisors[i]))
                    commonDivisors.Add(numeratorDivisors[i]);
            }

            foreach (var divisor in commonDivisors.OrderByDescending(c => c))
            {
                while (numerator % divisor == 0 && denominator % divisor == 0)
                {
                    numerator /= divisor;
                    denominator /= divisor;
                }
            }

            return (numerator, denominator);
        }

        public static List<long> ProperDivisors(long number)
        {
            var factors = GetAllDivisors(number);

            factors.Remove(number);

            return factors;
        }

        public static List<long> AllDivisors(long number)
        {
            return GetAllDivisors(number);
        }
    }
}
