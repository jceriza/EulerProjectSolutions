using Utilities;

namespace Exercises
{
    public class E031_Coin_sums
    {
        public static int WaysToGetXPounds(int pences)
        {
            return new Currency(pences).WaysToGet();
        }
    }
}
