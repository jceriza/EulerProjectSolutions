using Exercises;
using Xunit;

namespace Exercises_Tests
{
    public class E015_Tests
    {
        [Fact]
        public void LatticePaths_Input2_Output6()
        {
            Assert.Equal(6, E015_Lattice_Paths.LatticePathsInANxNGrid(2));
        }

        [Fact]
        public void LatticePaths_Input3_Output20()
        {
            Assert.Equal(20, E015_Lattice_Paths.LatticePathsInANxNGrid(3));
        }

        [Fact]
        public void LatticePaths_Input4_Output70()
        {
            Assert.Equal(70, E015_Lattice_Paths.LatticePathsInANxNGrid(4));
        }

        [Fact]
        public void LatticePaths_Input20_Output137846528820()
        {
            Assert.Equal(137_846_528_820, E015_Lattice_Paths.LatticePathsInANxNGrid(20));
        }
    }
}
