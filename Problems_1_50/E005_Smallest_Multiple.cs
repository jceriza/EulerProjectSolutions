namespace Exercises
{
    public class E005_Smallest_Multiple
    {
        public static long SmallestMultiple(int multipleUntil)
        {
            int minPossible;

            for (minPossible = multipleUntil; true; minPossible += multipleUntil)
            {
                var isDivisible = true;

                for (int j = 2; j <= multipleUntil - 2 && isDivisible; j += 2)
                {
                    if (minPossible % j != 0) isDivisible = false;
                }

                if (isDivisible) break;
            }

            for (int result = minPossible; true; result += minPossible)
            {
                var isDivisible = true;

                for (int j = 3; j <= multipleUntil; j += 2)
                {
                    if (result % j != 0) isDivisible = false;
                }

                if (isDivisible) return result;
            }
        }
    }
}
