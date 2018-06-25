using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E045_Tests
    {
        [Fact]
        public void TriangularPentagonalHexagonal()
        {
            Assert.Equal(
                1533776805,
                E045_Triangular_pentagonal_hexagonal.TriangularPentagonalHexagonal());
        }
    }
}
