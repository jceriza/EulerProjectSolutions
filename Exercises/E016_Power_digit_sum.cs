using System;
using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E016_Power_digit_sum
    {
        private static long DigitsSum(LargeNumber num)
        {
            return num
                .ToString()
                .Select(c => long.Parse(c.ToString()))
                .Sum();
        }

        public static long PowerOf2(int power)
        {
            return DigitsSum(LargeNumber.Pow(2, power));
        }
    }
}
