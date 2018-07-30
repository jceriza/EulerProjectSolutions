namespace Utilities
{
    public class RightTriangle
    {
        private readonly int _perimeter;

        public RightTriangle(int perimeter)
        {
            _perimeter = perimeter;
        }

        public int Solutions()
        {
            var solutions = 0;

            for (int h = 1; h < _perimeter; h++)
            {
                var hSquare = h * h;

                for (int a = 1, b = _perimeter - a - h; a < h && b > a; a++, b--)
                {
                    if (a * a + b * b == hSquare) solutions++;
                }
            }

            return solutions;
        }
    }
}
