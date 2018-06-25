using System.Linq;
using System.Text;

namespace Exercises
{
    public static class E008_Largest_product_in_a_series
    {
        public static long LargestProductInASeries(string text, int adjacentDigits)
        {
            var currentSerie = new StringBuilder();
            var highestValue = 0L;

            foreach (var character in text)
            {
                var number = long.Parse(character.ToString());

                if (number == 0)
                {
                    currentSerie = new StringBuilder();
                }
                else
                {
                    currentSerie.Append(character);

                    if (currentSerie.Length == adjacentDigits + 1)
                    {
                        currentSerie.Remove(0, 1);
                    }

                    if (currentSerie.Length == adjacentDigits)
                    {
                        var currentValue = ProductInSerie(currentSerie.ToString());

                        if (currentValue > highestValue)
                        {
                            highestValue = currentValue;
                        }
                    }
                }
            }

            return highestValue;
        }

        private static long ProductInSerie(string serie)
        {
            return serie.Select(c => long.Parse(c.ToString())).Aggregate(1L, (prod, next) => prod * next);
        }
    }
}
