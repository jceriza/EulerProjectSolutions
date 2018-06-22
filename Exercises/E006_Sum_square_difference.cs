namespace Exercises
{
    public static class E006_Sum_square_difference
    {
        public static long SumSquareDifference(long limit)
        {
            long sumOfSquares = 0;
            long squareOfSums = 0;

            for (int i = 1; i <= limit; i++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }

            return squareOfSums * squareOfSums - sumOfSquares;
        }
    }
}
