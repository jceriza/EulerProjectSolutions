using Utilities;
using Xunit;

namespace Utilities_Tests
{
    public class LatticePathsTests
    {
        [Fact]
        public void LatticePaths_Input2_Output6()
        {
            Assert.Equal(6, LatticePaths.LatticePathsInASquareGrid(2));
        }

        [Fact]
        public void LatticePaths_Input3_Output20()
        {
            Assert.Equal(20, LatticePaths.LatticePathsInASquareGrid(3));
        }

        [Fact]
        public void LatticePaths_Input4_Output70()
        {
            Assert.Equal(70, LatticePaths.LatticePathsInASquareGrid(4));
        }

        [Fact]
        public void LatticePaths_Input20_Output137846528820()
        {
            Assert.Equal(137846528820, LatticePaths.LatticePathsInASquareGrid(20));
        }
    }
}
