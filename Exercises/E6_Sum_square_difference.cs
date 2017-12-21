namespace Exercises
{
    public static class E6_Sum_square_difference
    {
        private static long SumSquares(long limit)
        {
            long sum = 0;

            for (int i = 1; i <= limit; i++)
            {
                sum += i * i;
            }

            return sum;
        }

        private static long SquareOfTheSum(long limit)
        {
            long sum = 0;

            for (int i = 1; i <= limit; i++)
            {
                sum += i;
            }

            return sum * sum;
        }

        public static long SumSquareDifference(long limit)
        {
            return SquareOfTheSum(limit) - SumSquares(limit);
        }
    }
}
