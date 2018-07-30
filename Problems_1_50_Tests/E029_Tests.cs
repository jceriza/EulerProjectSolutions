using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E029_Tests
    {
        [Fact]
        public void DistinctPowersSequence_2_5()
        {
            Assert.Equal(
                15,
                E029_Distinct_powers.Sequence(2, 5).Count);
        }

        [Fact]
        public void DistinctPowersSequence_2_100()
        {
            Assert.Equal(
                9183,
                E029_Distinct_powers.Sequence(2, 100).Count);
        }
    }
}
