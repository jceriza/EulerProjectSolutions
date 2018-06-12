using System.Linq;
using Utilities;

namespace Exercises
{
    public static class E038_Pandigital_multiples
    {
        public static long LargestPandigitalFormedWithMultiples()
        {
            return PandigitalNumber.PandigitalMultiples().Max();
        }
    }
}
