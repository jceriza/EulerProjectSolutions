using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public class RightTriangle
    {
        private readonly int _perimeter;

        public RightTriangle(int perimeter)
        {
            _perimeter = perimeter;
        }

        private IEnumerable<(int num, int square)> SquareNumbers()
        {
            for (int i = 1; true; i++)
            {
                yield return (i, i * i);
            }
        }

        public List<(int a, int b, int h)> Solutions()
        {
            var solutions = new List<(int a, int b, int h)>();

            foreach (var (h, square) in SquareNumbers().TakeWhile(s => s.num <= _perimeter))
            {
                for (int a = 1, b = _perimeter - a - h; a < h && b > a; a++, b--)
                {
                    if (a * a + b * b == square)
                    {
                        solutions.Add((a, b, h));
                    }
                }
            }

            return solutions;
        }
    }
}
