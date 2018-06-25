using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E043_Tests
    {
        [Fact]
        public void SubstringDivisibility()
        {
            Assert.Equal(
                16695334890,
                E043_Substring_divisibility.SubstringDivisibility());
        }
    }
}
