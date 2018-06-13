using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class E040_Champernownes_constant
    {
        private static int NthDigitInNumber(int number, int index, int divideBy)
        {
            while (--index >= 0) divideBy /= 10;

            return (number / divideBy) % 10;
        }

        public static int Expression()
        {
            var nthDigit = new int[] { 10, 100, 1_000, 10_000, 100_000, 1_000_000 };
            var mult = 1;
            var currentLength = 9;
            var previousLength = 9;
            var pow = 1;
            var numLength = 1;

            foreach (var currentDigit in nthDigit)
            {
                while (currentLength < currentDigit)
                {
                    pow *= 10;
                    previousLength = currentLength;
                    currentLength += pow * 9 * ++numLength;
                }

                var digitIndex = currentDigit - previousLength - 1;
                var number = digitIndex / numLength + pow;
                var indexInDigit = digitIndex % numLength;

                mult *= NthDigitInNumber(number, indexInDigit, pow);
            }

            return mult;
        }
    }
}
