using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E015_Tests
    {
        [Fact]
        public void RoutesInAGrid_20_137846528820()
        {
            Assert.Equal(
                137846528820,
                E015_Lattice_Paths.LatticePathsInA20x20Grid());
        }
    }
}
