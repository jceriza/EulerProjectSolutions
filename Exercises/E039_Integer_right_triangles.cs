using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Exercises
{
    public static class E039_Integer_right_triangles
    {
        public static int MaxSolutionsPerimeter()
        {
            var maxSolutions = 0;
            var maxPerimeter = 0;

            for (int perimeter = 1; perimeter <= 1000; perimeter++)
            {
                var numSolutions = new RightTriangle(perimeter).Solutions().Count;

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
