using System.Collections.Generic;
using System.Linq;

namespace Utilities.TrieDS
{
    public class TrieNode
    {
        public TrieWord Character { get; }
        public List<TrieNode> Children { get; } = new List<TrieNode>();
        public bool IsWord { get; private set; }

        public TrieNode() { }

        public TrieNode(char character)
        {
            Character = new TrieWord(character);
        }

        public void InsertOrdered(string word)
        {
            var character = word[0];
            var node = new TrieNode(character);

            if (!Children.Any()) Children.Add(node);
            else
            {
                var first = 0;
                var last = Children.Count - 1;
                int mid;
                char characterInMid;

                do
                {
                    mid = (first + last) / 2;
                    characterInMid = Children[mid].Character.Value;

                    if (character > characterInMid) first = mid + 1;
                    else if (character < characterInMid) last = mid - 1;
                    else
                    {
                        node = Children[mid];
                        if (word.Length == 1) node.IsWord = true;
                        else node.InsertOrdered(word.Substring(1));
                        return;
                    }
                } while (first <= last);

                if (characterInMid < character) Children.Insert(mid + 1, node);
                else Children.Insert(mid, node);
            }

            if (word.Length == 1) node.IsWord = true; 
            else node.InsertOrdered(word.Substring(1));
        }
    }
}
