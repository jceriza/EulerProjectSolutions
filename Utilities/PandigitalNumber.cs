using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public class PandigitalNumber
    {
        public static bool IsPandigitalWithoutZero(long number)
        {
            if (number < 10) return true;
            var numbers = new List<long>();

            while (number > 0)
            {
                var currentNumber = number % 10;
                if (currentNumber == 0 || numbers.Contains(currentNumber)) return false;
                numbers.Add(currentNumber);
                number /= 10;
            }

            return true;
        }
    }
}
