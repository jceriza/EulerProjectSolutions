using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public class DigitPowers
    {
        private readonly Dictionary<int, int> _powers = new Dictionary<int, int>();
        private readonly List<int> _numbers = new List<int>();
        private readonly int _pow;

        public DigitPowers(int n)
        {
            _pow = n;
            for (int i = 0; i < 10; i++)
            {
                _powers.Add(i, (int)Math.Pow(i, _pow));
            }
        }

        public List<int> GetPowers()
        {
            for (int i = 1; i < 10; i++)
            {
                ExploreNumbers(i);
            }

            return _numbers;
        }

        private long PowSum(int number)
        {
            var sum = 0L;
            var numberCopy = number;

            while (numberCopy > 0)
            {
                sum += (long)Math.Pow(numberCopy % 10, _pow);
                numberCopy /= 10;
            }

            return sum;
        }

        private bool IsComplete(int number)
        {
            if (number < 10) return false;

            return PowSum(number) == number;
        }

        private bool CanAddMoreNumbers(int number)
        {
            return PowSum(number) + _powers[9] > number;
        }

        private void ExploreNumbers(int number)
        {
            if (IsComplete(number))
            {
                _numbers.Add(number);
                return;
            }
            if (!CanAddMoreNumbers(number)) return;

            for (int i = 0; i < 10; i++)
            {
                ExploreNumbers(int.Parse($"{number}{i}"));
            }
        }
    }
}
