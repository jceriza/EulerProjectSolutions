namespace Exercises
{
    public static class E005_Smallest_Multiple
    {
        public static long SmallestMultiple(int multipleUntil)
        {
            bool validNumber;

            for (int num = multipleUntil; true; num += multipleUntil)
            {
                validNumber = true;

                for (int divisor = multipleUntil; divisor > 2; divisor--)
                {
                    if (num % divisor != 0)
                    {
                        validNumber = false;
                        break;
                    }
                }

                if (validNumber) return num;
            }
        }
    }
}
