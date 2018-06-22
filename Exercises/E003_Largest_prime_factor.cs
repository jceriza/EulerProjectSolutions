namespace Exercises
{
    public class E003_Largest_prime_factor
    {
        private static long FirstPrimeFactor(long num)
        {
            if (num % 2 == 0) return 2;
            for (int i = 3; i < num; i += 2)
            {
                if (num % i == 0) return i;
            }

            return num;
        }

        public static long LargestPrimeFactor(long num)
        {
            long prime;

            do
            {
                prime = FirstPrimeFactor(num);
                num = num / prime;
            } while (num > 1);

            return prime;
        }
    }
}
