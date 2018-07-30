namespace Utilities
{
    public class Currency
    {
        private static readonly int[] _coins
            = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };

        private readonly int _quantity;

        public Currency(int quantity)
        {
            _quantity = quantity;
        }

        public int WaysToGet()
        {
            return Backtracking(_quantity, 0);
        }

        private int Backtracking(int currentNumber, int coinIndex)
        {
            if (IsComplete(currentNumber)) return 1;
            if (coinIndex >= _coins.Length) return 0;
            if (currentNumber < _coins[coinIndex]) return 0;

            var sum = 0;
            var currentCoin = _coins[coinIndex];

            for (int i = (currentNumber / currentCoin) * currentCoin; i >= 0; i -= currentCoin)
            {
                sum += Backtracking(currentNumber - i, coinIndex + 1);
            }

            return sum;
        }

        private bool IsComplete(int currentNumber)
        {
            return currentNumber == 0;
        }
    }
}
