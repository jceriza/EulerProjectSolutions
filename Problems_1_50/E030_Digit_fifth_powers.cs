using Utilities;

namespace Exercises
{
    public class E030_Digit_fifth_powers
    {
        private static int Limit(int n)
        {
            var nines = 9;
            var ninePow = 9;
            for (int i = 1; i < n; i++) ninePow *= 9;

            var limit = ninePow;
            while (nines <= limit)
            {
                limit += ninePow;
                nines *= 10;
                nines += 9;
            }

            return limit;
        }

        public static int SumNthPowersOfTheirDigits(int n)
        {
            var limit = Limit(n);

            var globalSum = 0;

            for (int i = 10; i < limit; i++)
            {
                var sum = 0;

                for (int aux = i; aux > 0; aux /= 10)
                {
                    sum += (aux % 10).Pow(n);
                }

                if (sum == i)
                    globalSum += sum;
            }

            return globalSum;
        }
    }
}
