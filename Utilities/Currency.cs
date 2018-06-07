using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public class Currency
    {
        private static readonly List<int> _coins
            = new List<int> { 1, 2, 5, 10, 20, 50, 100, 200 };

        private readonly List<int> _currentCoins = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private readonly HashSet<string> _ways = new HashSet<string>();
        private readonly int _quantity;

        public Currency(int quantity)
        {
            _quantity = quantity;
        }

        public List<string> WaysToGet()
        {
            Backtracking(0, 0);

            return _ways.ToList();
        }

        private void Backtracking(int currentNumber, int coinIndex)
        {
            if (currentNumber > _quantity) return;

            if (IsComplete(currentNumber))
            {
                _ways.Add(GetWayFromCurrentCoins());
                return;
            }

            if (coinIndex >= _coins.Count) return;

            for (int i = coinIndex; i < _coins.Count; i++)
            {
                var threshold = (_quantity - currentNumber) / _coins[i];

                for (int numCoins = 0; threshold > 0 && numCoins <= threshold; numCoins++)
                {
                    _currentCoins[i] += numCoins;
                    Backtracking(currentNumber + numCoins * _coins[i], i + 1);
                    _currentCoins[i] -= numCoins;
                }
            }
        }

        private bool IsComplete(int currentNumber)
        {
            return currentNumber == _quantity;
        }

        private string GetWayFromCurrentCoins()
        {
            var wayStrings = _currentCoins
                .Select((quantity, index) => (quantity, index))
                .Where(c => c.quantity > 0)
                .Select((c, index) 
                    => $"{c.quantity}x{(_coins[c.index] < 100 ? $"{_coins[c.index]}p" : $"{_coins[c.index] / 100}£")}");

            return string.Join(" + ", wayStrings);
        }
    }
}
