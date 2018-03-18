using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities.TrieDS
{
    public class Trie
    {
        public TrieNode Root { get; set; } = new TrieNode();
        private List<(string Word, int Weight)> _orderedWords = new List<(string Word, int Weight)>();

        public Trie() { }

        public Trie(string word)
        {
            InsertOrdered(word);
        }

        public Trie(string[] words)
        {
            InsertOrdered(words);
        }

        private void BuildOrderedWords(TrieNode node, StringBuilder word, int weight)
        {
            if (node.IsWord)
            {
                _orderedWords.Add((word.ToString(), weight));

                if (!node.Children.Any()) return;
            }
            foreach (var child in node.Children)
            {
                word.Append(child.Character.Value);
                weight += child.Character.Weight;

                BuildOrderedWords(child, word, weight);

                word.Length--;
                weight -= child.Character.Weight;
            }
        }

        public void InsertOrdered(string word)
        {
            Root.InsertOrdered(word);
        }

        public void InsertOrdered(string[] words)
        {
            foreach (var word in words)
            {
                InsertOrdered(word);
            }
        }

        public List<(string Word, int Weight)> ExtractOrderedWords()
        {
            BuildOrderedWords(Root, new StringBuilder(), 0);

            return new List<(string Word, int Weight)>(_orderedWords);
        }
    }
}
