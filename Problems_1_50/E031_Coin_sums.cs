using Utilities;

namespace Exercises
{
    public static class E031_Coin_sums
    {
        public static int WaysToGetXPounds(int pences)
        {
            return new Currency(pences).WaysToGet().Count;
        }
    }
}
