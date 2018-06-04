using System;
using System.Collections.Concurrent;
using System.Text;

namespace Utilities
{
    public struct LargeNumber : IEquatable<LargeNumber>
    {
        private readonly string _number;

        public LargeNumber(long number)
        {
            _number = number.ToString();
        }

        public LargeNumber(string number)
        {
            _number = number;
        }

        public static bool operator ==(LargeNumber one, LargeNumber other)
        {
            return one._number == other._number;
        }

        public static bool operator !=(LargeNumber one, LargeNumber other)
        {
            return !(one == other);
        }

        public bool Equals(LargeNumber other)
        {
            return this == other;
        }

        public override bool Equals(object obj)
        {
            if (obj is LargeNumber largeNumber)
            {
                return Equals(largeNumber);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return _number.GetHashCode();
        }

        private static string Sum(string left, string right)
        {
            var sum = new StringBuilder();
            var carriage = 0;
            var longest = left.Length > right.Length ? left : right;
            var shortest = left.Length <= right.Length ? left : right;

            for (int i = longest.Length - 1, j = shortest.Length - 1; i >= 0; i--, j--)
            {
                var firstCharacter = int.Parse(longest[i].ToString());
                var secondCharacter = j >= 0 ? int.Parse(shortest[j].ToString()) : 0;

                var currentSum = firstCharacter + secondCharacter + carriage;

                if (currentSum > 9) carriage = currentSum / 10;
                else carriage = 0;

                sum.Insert(0, currentSum % 10);
            }

            if (carriage > 0) sum.Insert(0, carriage);

            return sum.ToString();
        }

        public static LargeNumber operator +(LargeNumber left, LargeNumber right)
        {
            return new LargeNumber(Sum(left._number, right._number));
        }

        private static string Multiply(string left, string right)
        {
            var longest = left.Length > right.Length ? left : right;
            var shortest = left.Length <= right.Length ? left : right;

            var accruedMultiplication = "0";

            for (int i = shortest.Length - 1, zeroesToAdd = 0; i >= 0; i--, zeroesToAdd++)
            {
                var carriage = 0;
                var shortestNum = int.Parse(shortest[i].ToString());
                var currentMultiplication = new StringBuilder(new string('0', zeroesToAdd));

                for (int j = longest.Length - 1; j >= 0; j--)
                {
                    var longestNum = int.Parse(longest[j].ToString());
                    var mult = shortestNum * longestNum + carriage;
                    var numToAdd = mult % 10;
                    carriage = mult / 10;

                    currentMultiplication.Insert(0, numToAdd);
                }

                if (carriage > 0) currentMultiplication.Insert(0, carriage);

                accruedMultiplication = Sum(accruedMultiplication, currentMultiplication.ToString());
            }

            return accruedMultiplication;
        }

        public static LargeNumber operator *(LargeNumber left, LargeNumber right)
        {
            return new LargeNumber(Multiply(left._number, right._number));
        }

        private static readonly ConcurrentDictionary<int, LargeNumber> _factorials = new ConcurrentDictionary<int, LargeNumber>();

        public static LargeNumber Factorial(int number)
        {
            if (_factorials.ContainsKey(number))
            {
                return _factorials[number];
            }

            if (number == 1)
            {
                var baseNumber = new LargeNumber("1");

                _factorials.TryAdd(number, baseNumber);

                return baseNumber;
            }

            return new LargeNumber(number) * Factorial(number - 1);
        }

        public override string ToString()
        {
            return _number;
        }
    }
}
