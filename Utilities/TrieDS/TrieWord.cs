using System.Collections.Generic;

namespace Utilities.TrieDS
{
    public class TrieWord
    {
        private static readonly Dictionary<char, int> _abecedaryWeight
            = new Dictionary<char, int> {
                { 'A', 1 }, { 'B', 2 }, { 'C', 3 }, { 'D', 4 }, { 'E', 5 },
                { 'F', 6 }, { 'G', 7 }, { 'H', 8 }, { 'I', 9 }, { 'J', 10 },
                { 'K', 11 }, { 'L', 12 }, { 'M', 13 }, { 'N', 14 }, { 'O', 15 },
                { 'P', 16 }, { 'Q', 17 }, { 'R', 18 }, { 'S', 19 }, { 'T', 20 },
                { 'U', 21 }, { 'V', 22 }, { 'W', 23 }, { 'X', 24 }, { 'Y', 25 },
                { 'Z', 26 }};

        public TrieWord(char character)
        {
            Value = character;
        }

        public char Value { get; }
        public int Weight { get { return _abecedaryWeight[Value]; } }
    }
}
