using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public class Permutations
    {
        private List<char> _characters;
        private Stack<int> _weights;

        public Permutations(params char[] characters)
        {
            _characters = characters.ToList();
            _weights = new Stack<int>();

            int sum = 1;

            for (int i = 0; i < _characters.Count; i++)
            {
                _weights.Push(sum);
                sum += sum * (i + 1);
            }
        }

        public string NthPermutation(int permutation)
        {
            permutation--;
            var permutationString = new StringBuilder();

            while (_weights.Any())
            {
                var currentWeight = _weights.Pop() / (_weights.Count + 1);

                if (currentWeight > permutation)
                {
                    permutationString.Append(_characters[0]);
                    _characters.RemoveAt(0);
                }
                else
                {
                    var timesCurrentWeight = permutation / currentWeight;

                    permutationString.Append(_characters[timesCurrentWeight]);
                    _characters.RemoveAt(timesCurrentWeight);
                    
                    permutation -= currentWeight * timesCurrentWeight;
                }
            }

            return permutationString.ToString();
        }
    }
}
