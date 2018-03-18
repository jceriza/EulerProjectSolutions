using System;
using System.Collections.Generic;

namespace Utilities
{
    public static class Divisors
    {
        private static Dictionary<long, HashSet<long>> factorsDictionary = new Dictionary<long, HashSet<long>>();

        private static HashSet<long> GetAllDivisors(long number)
        {
            if (number == 0) return new HashSet<long>();

            if (factorsDictionary.ContainsKey(number)) return factorsDictionary[number];

            var factors = new HashSet<long>() { 1, number };

            var limit = Math.Sqrt(number);
           
            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                    factors.Add(number / i);
                    factors.UnionWith(GetAllDivisors(number / i));
                }
            }

            factorsDictionary.Add(number, factors);

            return factors;
        }

        public static HashSet<long> ProperDivisors(long number)
        {
            var factors = GetAllDivisors(number);

            factors.Remove(number);

            return factors;
        }

        public static HashSet<long> AllDivisors(long number)
        {
            return GetAllDivisors(number);
        }
    }
}
