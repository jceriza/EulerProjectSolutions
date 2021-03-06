﻿using System.IO;
using System.Linq;
using Utilities.TrieDS;

namespace Exercises
{
    public class E022_Name_scores
    {
        private static readonly string[] _names;

        static E022_Name_scores()
        {
            _names = File.ReadAllText("p022_names.txt").Replace("\"", "").Split(',');
        }

        public static int NamesScore()
        {
            var orderedWords = new Trie(_names).ExtractOrderedWords();
            var sum = 0;

            for (int i = 0; i < orderedWords.Count; i++)
            {
                sum += ((i + 1) * orderedWords[i].Weight);
            }
            
            return sum;
        }
    }
}
