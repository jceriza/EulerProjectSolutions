using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E039_Tests
    {
        [Fact]
        public void MaxSolutionsPerimeter()
        {
            Assert.Equal(
                840,
                E039_Integer_right_triangles.MaxSolutionsPerimeter());
        }
    }
}
