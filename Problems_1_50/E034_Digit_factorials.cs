namespace Exercises
{
    public class E034_Digit_factorials
    {
        private static int[] FactorialsUntil9()
        {
            var factorials = new int[10];
            factorials[0] = 1;

            var mult = 1;

            for (int i = 1; i < factorials.Length; i++)
            {
                mult *= i;
                factorials[i] = mult;
            }

            return factorials;
        }

        public static long SumNumbersEqualSumFactorialDigits()
        {
            var factorials = FactorialsUntil9();

            var limit = factorials[9];
            var nines = 9;

            while (limit >= nines)
            {
                limit += factorials[9];
                nines *= 10;
                nines += 9;
            }

            var globalSum = 0;

            for (int i = 10; i <= limit; i++)
            {
                var aux = i;
                var currentSum = 0;

                while (aux > 0)
                {
                    currentSum += factorials[aux % 10];
                    aux /= 10;
                }

                if (currentSum == i) globalSum += i;
            }

            return globalSum;
        }
    }
}
