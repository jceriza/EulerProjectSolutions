using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E042_Tests
    {
        [Fact]
        public void NumTriangleWords()
        {
            Assert.Equal(
                162,
                E042_Coded_triangle_numbers.NumTriangleWords());
        }
    }
}
