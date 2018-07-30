namespace Exercises
{
    public class E009_Special_Pythagorean_triplet
    {
        public static int PythagoreanProduct(int desiredSum)
        {
            for (int c = desiredSum / 3; c <= desiredSum - 3; c++)
            {
                var a = desiredSum - (c - 1) - c;

                for (int b = c - 1; a < b; b--)
                {
                    a = desiredSum - b - c;

                    if (b > a
                        && a + b + c == desiredSum
                        && a * a + b * b == c * c)
                    {
                        return a * b * c;
                    }
                }
            }

            return -1;
        }
    }
}
