using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E026_Tests
    {
        [Fact]
        public void DecimalReciprocalCyclesUnder1000()
        {
            Assert.Equal(
                983,
                E026_Reciprocal_cycles.DecimalReciprocalCyclesUnder1000());
        }
    }
}
