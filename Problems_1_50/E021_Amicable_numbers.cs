using Utilities;

namespace Exercises
{
    public class E021_Amicable_numbers
    {
        public static long SumOfAmicableNumbersUnder10000()
        {
            long sum = 0;

            for (int i = 1; i < 10000; i++)
            {
                if (AmicableNumber.IsAmicable(i))
                {
                    sum += i;
                }
            }

            return sum;
        } 
    }
}
