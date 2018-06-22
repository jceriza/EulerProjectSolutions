using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Utilities
{
    public struct LargeNumber : IEquatable<LargeNumber>, IComparable<LargeNumber>
    {
        private const int _chunkSize = 9;
        private readonly ReadOnlyCollection<long> _chunks;

        public LargeNumber(long number)
        {
            _chunks = NumberInChunks(number.ToString()).ToList().AsReadOnly();
        }

        public LargeNumber(ulong number)
        {
            _chunks = NumberInChunks(number.ToString()).ToList().AsReadOnly();
        }

        public LargeNumber(string number)
        {
            _chunks = NumberInChunks(number).ToList().AsReadOnly();
        }

        private LargeNumber(IEnumerable<long> chunks)
        {
            _chunks = chunks.ToList().AsReadOnly();
        }

        private static IEnumerable<long> NumberInChunks(string number)
        {
            for (int i = number.Length - _chunkSize; i >= 0; i -= _chunkSize)
            {
                yield return long.Parse(number.Substring(i, _chunkSize));
            }

            var remaining = number.Length % _chunkSize;

            if (remaining > 0)
            {
                yield return long.Parse(number.Substring(0, remaining));
            }
        }

        public static bool operator ==(LargeNumber one, object other)
        {
            return one == ObjectToLargeNumber(other);
        }

        public static bool operator !=(LargeNumber one, object other)
        {
            return one != ObjectToLargeNumber(other);
        }

        public static bool operator ==(object one, LargeNumber other)
        {
            return ObjectToLargeNumber(one) == other;
        }

        public static bool operator ==(LargeNumber one, LargeNumber other)
        {
            return one.Equals(other);
        }

        public static bool operator !=(object one, LargeNumber other)
        {
            return ObjectToLargeNumber(one) != other;
        }

        public static bool operator !=(LargeNumber one, LargeNumber other)
        {
            return !one.Equals(other);
        }

        public bool Equals(LargeNumber other)
        {
            return CompareTo(other) == 0;
        }

        public override bool Equals(object obj)
        {
            return Equals(ObjectToLargeNumber(obj));
        }

        public override int GetHashCode()
        {
            return _chunks.ToString().GetHashCode();
        }

        public int CompareTo(LargeNumber other)
        {
            if (_chunks.Count != other._chunks.Count)
            {
                return _chunks.Count.CompareTo(other._chunks.Count);
            }

            for (int i = _chunks.Count - 1; i >= 0; i--)
            {
                if (_chunks[i] != other._chunks[i]) return _chunks[i].CompareTo(other._chunks[i]);
            }

            return 0;
        }

        private static LargeNumber ObjectToLargeNumber(object obj)
        {
            switch (obj)
            {
                case LargeNumber largeNumber:
                    return largeNumber;
                case sbyte sbyteNum:
                    return new LargeNumber(sbyteNum);
                case byte byteNum:
                    return new LargeNumber(byteNum);
                case short shortNum:
                    return new LargeNumber(shortNum);
                case ushort ushortNum:
                    return new LargeNumber(ushortNum);
                case int intNum:
                    return new LargeNumber(intNum);
                case uint uintNum:
                    return new LargeNumber(uintNum);
                case long longNum:
                    return new LargeNumber(longNum);
                case ulong ulongNum:
                    return new LargeNumber(ulongNum);
                default:
                    throw new NotSupportedException("You can't use this type");
            }
        }

        public int CompareTo(object other)
        {
            return CompareTo(ObjectToLargeNumber(other));
        }

        public static bool operator <(LargeNumber left, LargeNumber right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <(object left, LargeNumber right)
        {
            return ObjectToLargeNumber(left) < right;
        }

        public static bool operator <(LargeNumber left, object right)
        {
            return left < ObjectToLargeNumber(right);
        }

        public static bool operator >(object left, LargeNumber right)
        {
            return ObjectToLargeNumber(left) > right;
        }

        public static bool operator >(LargeNumber left, object right)
        {
            return left > ObjectToLargeNumber(right);
        }

        public static bool operator >(LargeNumber left, LargeNumber right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(object left, LargeNumber right)
        {
            return ObjectToLargeNumber(left) <= right;
        }

        public static bool operator <=(LargeNumber left, object right)
        {
            return left <= ObjectToLargeNumber(right);
        }

        public static bool operator <=(LargeNumber left, LargeNumber right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(object left, LargeNumber right)
        {
            return ObjectToLargeNumber(left) >= right;
        }

        public static bool operator >=(LargeNumber left, object right)
        {
            return left >= ObjectToLargeNumber(right);
        }

        public static bool operator >=(LargeNumber left, LargeNumber right)
        {
            return left.CompareTo(right) >= 0;
        }

        public static LargeNumber operator +(LargeNumber left, LargeNumber right)
        {
            var largest = left >= right ? left : right;
            var shortest = left >= right ? right : left;
            var carriage = 0L;
            var chunksSum = new List<long>();

            for (int i = 0; i < largest._chunks.Count; i++)
            {
                var sum = largest._chunks[i] + carriage;

                if (i < shortest._chunks.Count) sum += shortest._chunks[i];

                var chunk = sum % 1_000_000_000;

                chunksSum.Add(chunk);
                carriage = sum / 1_000_000_000;
            }

            if (carriage > 0) chunksSum.Add(carriage);

            return new LargeNumber(chunksSum);
        }

        public static LargeNumber operator +(LargeNumber left, object right)
        {
            return left + ObjectToLargeNumber(right);
        }

        public static LargeNumber operator +(object left, LargeNumber right)
        {
            return ObjectToLargeNumber(left) + right;
        }

        public static LargeNumber operator -(LargeNumber left, LargeNumber right)
        {
            if (left < right) throw new NotSupportedException("Negative numbers not supported");

            var carriage = false;
            var chunksSubtract = new List<long>();

            for (int i = 0; i < left._chunks.Count; i++)
            {
                long subtract = left._chunks[i];

                if (carriage) subtract -= 1;

                if (i < right._chunks.Count) subtract -= right._chunks[i];

                if (subtract < 0)
                {
                    carriage = true;
                    subtract = 1_000_000_000 - (0 - subtract);
                }
                else carriage = false;

                chunksSubtract.Add(subtract);
            }

            while (chunksSubtract[chunksSubtract.Count - 1] == 0 && chunksSubtract.Count > 1)
            {
                chunksSubtract.RemoveAt(chunksSubtract.Count - 1);
            }

            return new LargeNumber(chunksSubtract);
        }

        public static LargeNumber operator -(LargeNumber left, object right)
        {
            return left - ObjectToLargeNumber(right);
        }

        public static LargeNumber operator -(object left, LargeNumber right)
        {
            return ObjectToLargeNumber(left) - right;
        }

        public static LargeNumber operator *(LargeNumber left, LargeNumber right)
        {            
            var largest = left >= right ? left : right;
            var shortest = left >= right ? right : left;
            var carriage = 0L;
            var chunksSum = new List<long>();
            var startIndex = 0;

            foreach (var shortChunk in shortest._chunks)
            {
                var index = startIndex++;

                foreach (var largeChunk in largest._chunks)
                {
                    var product = shortChunk * largeChunk + carriage;

                    if (index >= chunksSum.Count) chunksSum.Add(product);
                    else chunksSum[index] += product;

                    carriage = chunksSum[index] / 1_000_000_000;
                    chunksSum[index] %= 1_000_000_000;

                    index++;
                }
            }

            if (carriage > 0) chunksSum.Add(carriage);

            return new LargeNumber(chunksSum);
        }

        public static LargeNumber operator *(LargeNumber left, object right)
        {
            return left * ObjectToLargeNumber(right);
        }

        public static LargeNumber operator /(LargeNumber left, LargeNumber right)
        {
            if (left < right) throw new NotSupportedException("Left side division has to be higher than right side.");

            var binaryLeft = new BinaryNumber(left);
            var binaryRight = new BinaryNumber(right);

            return (binaryLeft / binaryRight).ToLargeNumber();
        }

        public static LargeNumber operator /(object left, LargeNumber right)
        {
            return ObjectToLargeNumber(left) / right;
        }

        public static LargeNumber operator /(LargeNumber left, object right)
        {
            return left / ObjectToLargeNumber(right);
        }

        private static readonly ConcurrentDictionary<int, LargeNumber> _factorials = new ConcurrentDictionary<int, LargeNumber>();

        public static LargeNumber Factorial(int number)
        {
            if (_factorials.ContainsKey(number)) return _factorials[number];

            if (number == 0 || number == 1) return new LargeNumber(1);

            var largeNumber = new LargeNumber(number) * Factorial(number - 1);

            _factorials.TryAdd(number, largeNumber);

            return largeNumber;
        }

        public static LargeNumber Pow(int baseNum, int exponent)
        {
            var pow = new LargeNumber(1);
            var largeBase = new LargeNumber(baseNum);

            for (int i = 0; i < exponent; i++)
            {
                pow *= largeBase;
            }

            return pow;
        }

        public override string ToString()
        {
            var stringNumber = new StringBuilder();

            for (int i = _chunks.Count - 1; i >= 0; i--)
            {
                var currentStringNum = _chunks[i].ToString();

                if (currentStringNum.Length < _chunkSize && i != _chunks.Count - 1)
                {
                    var zeroes = new String('0', _chunkSize - currentStringNum.Length);
                    currentStringNum = $"{zeroes}{currentStringNum}";
                }

                stringNumber.Append(currentStringNum);
            }

            return stringNumber.ToString();
        }
    }
}
