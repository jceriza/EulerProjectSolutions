using Exercises;
using System.Collections.Generic;
using Xunit;

namespace Exercises_Tests
{
    public class E029_Tests
    {
        [Fact]
        public void DistinctPowersSequence_2_5()
        {
            Assert.Equal(
                new HashSet<string>
                {
                    "4", "8", "9", "16", "25", "27", "32", "64", "81", "125", "243", "256", "625", "1024", "3125"
                },
                E029_Distinct_powers.Sequence(2, 5));
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
