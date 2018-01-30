using System.Collections.Generic;
using Utilities;
using Xunit;

namespace Utilities_Tests
{
    public class FactorTests
    {
        [Fact]
        public void Factor_Input1_Output1()
        {
            Assert.Equal(Factor.GetFactors(1), new HashSet<long>() { 1 });
        }

        [Fact]
        public void Factor_Input3_Output1_3()
        {
            Assert.Equal(Factor.GetFactors(3), new HashSet<long>() { 1, 3 });
        }

        [Fact]
        public void Factor_Input6_Output1_2_3_6()
        {
            Assert.Equal(Factor.GetFactors(6), new HashSet<long>() { 1, 2, 3, 6 });
        }

        [Fact]
        public void Factor_Input10_Output1_2_5_10()
        {
            Assert.Equal(Factor.GetFactors(10), new HashSet<long>() { 1, 2, 5, 10 });
        }

        [Fact]
        public void Factor_Input15_Output1_3_5_15()
        {
            Assert.Equal(Factor.GetFactors(15), new HashSet<long>() { 1, 3, 5, 15 });
        }

        [Fact]
        public void Factor_Input21_Output1_3_7_21()
        {
            Assert.Equal(Factor.GetFactors(21), new HashSet<long>() { 1, 3, 7, 21 });
        }

        [Fact]
        public void Factor_Input28_Output1_2_4_7_14_28()
        {
            Assert.Equal(Factor.GetFactors(28), new HashSet<long>() { 1, 2, 4, 7, 14, 28 });
        }
    }
}
