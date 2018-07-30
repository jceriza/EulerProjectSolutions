using Utilities;

namespace Exercises
{
    public class E045_Triangular_pentagonal_hexagonal
    {
        public static long TriangularPentagonalHexagonal()
        {
            var h = 144;
            long hexagonal;

            do
            {
                hexagonal = TriPenHexNumbers.HexagonalNumber(h++);
            } while (!(TriPenHexNumbers.IsPentagonNumber(hexagonal)
                    && TriPenHexNumbers.IsTriangleNumber(hexagonal)));

            return hexagonal;
        }
    }
}
