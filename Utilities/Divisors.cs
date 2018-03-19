using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Utilities
{
    public static class Divisors
    {
        private static ConcurrentDictionary<long, HashSet<long>> _factorsDictionary = new ConcurrentDictionary<long, HashSet<long>>();

        private static HashSet<long> GetAllDivisors(long number)
        {
            if (number == 0) return new HashSet<long>();

            if (_factorsDictionary.ContainsKey(number)) return _factorsDictionary[number];

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

            _factorsDictionary.TryAdd(number, factors);

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
