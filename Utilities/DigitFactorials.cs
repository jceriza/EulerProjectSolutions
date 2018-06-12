namespace Utilities
{
    public class DigitFactorials
    {
        private LargeNumber _currentFactorialSum;
        private long _sum;

        public DigitFactorials(int num)
        {
            _currentFactorialSum = LargeNumber.Factorial(num);
            Backtracking(num);
        }

        private static long DigitsFactorialSum(long num)
        {
            var sum = new LargeNumber(0);

            while (num > 0)
            {
                sum += LargeNumber.Factorial((int)num % 10);
                num /= 10;
            }

            return long.Parse(sum.ToString());
        }

        private bool IsCorrect(long num)
        {
            return num > 9 && _currentFactorialSum == num;
        }

        private bool IsComplete(long num)
        {
            var threshold = num * 10 + 9;
            return threshold > DigitsFactorialSum(threshold)
                && num * 10 > DigitsFactorialSum(num * 10);
        }

        private void Backtracking(long num)
        {
            if (IsCorrect(num)) _sum += num;
            if (IsComplete(num)) return;

            for (int i = 0; i < 10; i++)
            {
                var currentSum = _currentFactorialSum;
                _currentFactorialSum += LargeNumber.Factorial(i);
                Backtracking(num * 10 + i);
                _currentFactorialSum = currentSum;                
            }
        }

        public static long DigitFactorialsSum()
        {
            var sum = 0L; 

            for (int i = 1; i < 10; i++)
            {
                sum += new DigitFactorials(i)._sum;
            }

            return sum;
        }
    }
}
