using Utilities;

namespace Exercises
{
    public class E039_Integer_right_triangles
    {
        public static int MaxSolutionsPerimeter()
        {
            var maxSolutions = 0;
            var maxPerimeter = 0;

            for (int perimeter = 1; perimeter <= 1000; perimeter++)
            {
                var numSolutions = new RightTriangle(perimeter).Solutions();

                if (numSolutions > maxSolutions)
                {
                    maxSolutions = numSolutions;
                    maxPerimeter = perimeter;
                }
            }

            return maxPerimeter;
        }
    }
}
