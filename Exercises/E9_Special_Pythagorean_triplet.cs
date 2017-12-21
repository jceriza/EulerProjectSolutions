using Utilities;

namespace Exercises
{
    public static class E9_Special_Pythagorean_triplet
    {
        public static int PythagoreanProduct(int desiredSum)
        {
            foreach (var (a, b, c) in PythagoreanTriplet.PythagoreanTripletGenerator())
            {
                if (a + b + c == desiredSum)
                {
                    return a * b * c;
                }
            }

            return -1;
        }
    }
}
