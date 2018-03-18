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
            Assert.Equal(Divisors.AllDivisors(1), new HashSet<long>() { 1 });
        }

        [Fact]
        public void Factor_Input3_Output1_3()
        {
            Assert.Equal(Divisors.AllDivisors(3), new HashSet<long>() { 1, 3 });
        }

        [Fact]
        public void Factor_Input6_Output1_2_3_6()
        {
            Assert.Equal(Divisors.AllDivisors(6), new HashSet<long>() { 1, 2, 3, 6 });
        }

        [Fact]
        public void Factor_Input10_Output1_2_5_10()
        {
            Assert.Equal(Divisors.AllDivisors(10), new HashSet<long>() { 1, 2, 5, 10 });
        }

        [Fact]
        public void Factor_Input15_Output1_3_5_15()
        {
            Assert.Equal(Divisors.AllDivisors(15), new HashSet<long>() { 1, 3, 5, 15 });
        }

        [Fact]
        public void Factor_Input21_Output1_3_7_21()
        {
            Assert.Equal(Divisors.AllDivisors(21), new HashSet<long>() { 1, 3, 7, 21 });
        }

        [Fact]
        public void Factor_Input28_Output1_2_4_7_14_28()
        {
            Assert.Equal(Divisors.AllDivisors(28), new HashSet<long>() { 1, 2, 4, 7, 14, 28 });
        }
    }
}
