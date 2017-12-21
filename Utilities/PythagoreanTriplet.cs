using System.Collections.Generic;

namespace Utilities
{
    public static class PythagoreanTriplet
    {
        public static IEnumerable<(int a, int b, int c)> PythagoreanTripletGenerator()
        {
            for (int c = 1; true; c++)
            {
                for (int b = 1; c > b; b++)
                {
                    for (int a = 1; b > a; a++)
                    {
                        if (a * a + b * b == c * c)
                        {
                            yield return (a, b, c);
                        }
                    }
                }
            }
        }
    }
}
