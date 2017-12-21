namespace Exercises
{
    public static class E001_Multiples_of_3_or_5
    {
        public static int SumOfMultiplesOf3Or5Below(int number)
        {
            int sum = 0;

            for (int i = 3; i < number; i += 3)
            {
                sum += i;
            }

            for (int j = 5; j < number; j += 5)
            {
                if (j % 3 != 0) sum += j;
            }

            return sum;
        }
    }
}
