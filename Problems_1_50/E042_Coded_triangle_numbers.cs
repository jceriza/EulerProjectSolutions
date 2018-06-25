using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Utilities;

namespace Exercises
{
    public static class E042_Coded_triangle_numbers
    {
        private static readonly string[] _words;
        private static readonly Dictionary<char, int> _dictionary;

        static E042_Coded_triangle_numbers()
        {
            _words = File.ReadAllText("p042_words.txt").Replace("\"", "").Split(',');
            _dictionary = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                .Select((letter, index) => (letter, index: index + 1))
                .ToDictionary(a => a.letter, a => a.index);
        }

        public static int NumTriangleWords()
        {
            var triangleNumbers = new List<int> { 1 };
            var numTriangleWords = 0;

            foreach (var word in _words)
            {
                var wordNumber = word.Select(w => _dictionary[w]).Sum();

                if (TriPenHexNumbers.IsTriangleNumber(wordNumber))
                {
                    numTriangleWords++;
                }
            }

            return numTriangleWords;
        }
    }
}
