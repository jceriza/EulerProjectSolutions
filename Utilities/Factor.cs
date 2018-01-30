using System;
using System.Collections.Generic;

namespace Utilities
{
    public static class Factor
    {
        private static Dictionary<long, HashSet<long>> factorsDictionary = new Dictionary<long, HashSet<long>>();

        public static HashSet<long> GetFactors(long number)
        {
            if (factorsDictionary.ContainsKey(number)) return factorsDictionary[number];

            var factors = new HashSet<long>() { 1, number };

            var limit = Math.Sqrt(number);
           
            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                    factors.UnionWith(GetFactors(number / i));
                }
            }

            factorsDictionary.Add(number, factors);

            return factors;
        }
    }
}
