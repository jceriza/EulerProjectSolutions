using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E040_Tests
    {
        [Fact]
        public void ChampernownesConstant()
        {
            Assert.Equal(
                210,
                E040_Champernownes_constant.Expression());
        }
    }
}
