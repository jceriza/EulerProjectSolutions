using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class E028_Number_spiral_diagonals
    {
        public static int SumDiagonals(int size)
        {
            var topLeftDiagonal = new List<int> { 1 };
            var bottomLeftDiagonal = new List<int> { };

            var lastTopLeftDiagonalNumberInserted = 1;
            var lastBottomLeftDiagonalNumberInserted = 1;

            for (int i = 0, j = 2, k = 4; i < size / 2; i++, k += 4)
            {
                for (int l = 0; l < 2; l++)
                {
                    lastTopLeftDiagonalNumberInserted += j;
                    topLeftDiagonal.Add(lastTopLeftDiagonalNumberInserted);

                    j += 2;

                    lastBottomLeftDiagonalNumberInserted += k;
                    bottomLeftDiagonal.Add(lastBottomLeftDiagonalNumberInserted);
                }
            }

            return topLeftDiagonal.Sum() + bottomLeftDiagonal.Sum();
        }
    }
}
