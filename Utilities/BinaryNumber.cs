using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public struct BinaryNumber : IEquatable<BinaryNumber>, IComparable<BinaryNumber>
    {
        private readonly List<byte> _binary;

        private static List<byte> BinaryNumberString(LargeNumber largeNumber)
        {
            if (largeNumber == 1) return new List<byte> { 1 };
            if (largeNumber == 0) return new List<byte> { 0 };

            var numbers = new Stack<LargeNumber>();

            var aux = new LargeNumber(1);
            var i = new LargeNumber(1);

            while (aux <= largeNumber)
            {
                i = aux;

                numbers.Push(i);

                aux *= 2;

                if (new LargeNumber("1237940039285380274899124224") == aux)
                {

                }
            }

            var number = new List<byte>();

            while (numbers.Any())
            {
                var num = numbers.Pop();

                if (num <= largeNumber)
                {
                    largeNumber -= num;
                    number.Add(1);
                }
                else number.Add(0);
            }

            return number;
        }

        public BinaryNumber(string number)
        {
            _binary = number
                .SkipWhile(n => n == '0')
                .Select(n => byte.Parse(n.ToString()))
                .DefaultIfEmpty((byte)0)
                .ToList();
        }

        private BinaryNumber(List<byte> binary)
        {
            _binary = binary
                .SkipWhile(b => b == 0)
                .DefaultIfEmpty((byte)0).ToList();
        }

        public BinaryNumber(long base10Number)
        {
            _binary = BinaryNumberString(new LargeNumber(base10Number));
        }

        public BinaryNumber(ulong base10Number)
        {
            _binary = BinaryNumberString(new LargeNumber(base10Number));
        }

        public BinaryNumber(LargeNumber largeNumber)
        {
            _binary = BinaryNumberString(largeNumber);
        }

        public static BinaryNumber operator *(BinaryNumber left, BinaryNumber right)
        {
            var largest = left >= right ? left._binary : right._binary;
            var shortest = left >= right ? right._binary : left._binary;

            var number = new BinaryNumber(0);

            for (int i = shortest.Count - 1; i >= 0; i--)
            {
                if (shortest[i] == 1)
                    number += new BinaryNumber(largest);

                largest.Add(0);
            }

            return number;
        }

        public static BinaryNumber operator /(BinaryNumber left, BinaryNumber right)
        {
            if (left < right) throw new NotSupportedException("Left side of division needs to be higher or equal than right side");
            if (left == right) return new BinaryNumber(1);

            var currentNumber = new StringBuilder();
            var result = new StringBuilder();

            for (int i = 0; i < left._binary.Count; i++)
            {
                currentNumber.Append(left._binary[i]);
                var c = new BinaryNumber(currentNumber.ToString());

                if (c < right) result.Append(0);
                else
                {
                    result.Append(1);
                    c -= right;
                    currentNumber = new StringBuilder(c.ToString());
                }
            }

            return new BinaryNumber(result.ToString());
        }

        public static BinaryNumber operator +(BinaryNumber left, BinaryNumber right)
        {
            var largest = left >= right ? left._binary : right._binary;
            var shortest = left >= right ? right._binary : left._binary;

            var number = new List<byte>();
            var carriage = 0;

            for (int i = largest.Count - 1, j = shortest.Count - 1; i >= 0; i--, j--)
            {
                var num = largest[i] + carriage;
                if (j >= 0) num += shortest[j];

                number.Insert(0, (byte)(num % 2));

                if (num > 1) carriage = 1;
                else carriage = 0;                
            }

            if (carriage % 2 == 1) number.Insert(0, 1);

            return new BinaryNumber(number);

        }

        public static BinaryNumber operator -(BinaryNumber left, BinaryNumber right)
        {
            if (left < right) throw new NotSupportedException("Negative binary numbers are not supported");
            if (left == right) return new BinaryNumber(0);

            var number = new List<byte>();
            int carriage = 0;

            for (int i = left._binary.Count - 1, j = right._binary.Count - 1; i >= 0; i--, j--)
            {
                var num = left._binary[i] - carriage;
                if (j >= 0) num -= right._binary[j];

                if (num < 0)
                {
                    num = 0 - num;
                    carriage = 1;
                }
                else carriage = 0;

                number.Insert(0, (byte)(num % 2));
            }

            while (number[0] == 0 && number.Count > 1)
                number.RemoveAt(0);

            return new BinaryNumber(number);
        }

        public static bool operator ==(BinaryNumber left, BinaryNumber right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(BinaryNumber left, BinaryNumber right)
        {
            return !(left == right);
        }

        public static bool operator <(BinaryNumber left, BinaryNumber right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(BinaryNumber left, BinaryNumber right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(BinaryNumber left, BinaryNumber right)
        {
            return left.CompareTo(right) >= 0;
        }

        public static bool operator <=(BinaryNumber left, BinaryNumber right)
        {
            return left.CompareTo(right) <= 0;
        }

        public int CompareTo(BinaryNumber other)
        {
            if (_binary.Count != other._binary.Count)
                return _binary.Count.CompareTo(other._binary.Count);

            for (int i = 0; i < _binary.Count; i++)
                if (_binary[i] != other._binary[i])
                    return _binary[i].CompareTo(other._binary[i]);

            return 0;
        }

        public LargeNumber ToLargeNumber()
        {
            var largeNumber = new LargeNumber(0);
            var mult = new LargeNumber(1);

            for (int i = _binary.Count - 1; i >= 0; i--)
            {
                if (_binary[i] == 1) largeNumber += mult;
                mult *= 2;
            }

            return largeNumber;
        }

        public bool Equals(BinaryNumber other)
        {
            return CompareTo(other) == 0;
        }

        public override bool Equals(object obj)
        {
            if (obj is BinaryNumber binaryNumber)
                return Equals(binaryNumber);

            return false;
        }

        public override string ToString()
        {
            return string.Join("", _binary.Select(b => b.ToString()));
        }

        public override int GetHashCode()
        {
            return 1204864143 + EqualityComparer<List<byte>>.Default.GetHashCode(_binary);
        }
    }
}
