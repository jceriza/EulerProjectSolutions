using System;
using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E016_Power_digit_sum
    {
        private static Lazy<long> _powerOf50 = new Lazy<long>(LoadPowerOf50);
        public static long PowerOf50 => _powerOf50.Value;

        private static long LoadPowerOf50()
        {
            return GetPowerOfN(50);
        }

        private static long GetPowerOfN(int power)
        {
            long powerOf2 = 1;
            var until = power % 50 == 0 ? 50 : power;

            for (int i = 0; i < until; i++, powerOf2 *= 2) ;

            return powerOf2;
        }

        private static long DigitsSum(string num)
        {
            return num
                .Select(c => long.Parse(c.ToString()))
                .Sum();
        }

        public static long PowerOf2(int power)
        {
            var pow = "1";

            for (; power > 0; power -= 50)
            {
                var currentPower = power % 50 == 0 ? PowerOf50 : GetPowerOfN(power);

                pow = LargeNumbersCalculations.Multiplication(
                    pow,
                    currentPower.ToString());
            }

            return DigitsSum(pow);
        }
    }
}
