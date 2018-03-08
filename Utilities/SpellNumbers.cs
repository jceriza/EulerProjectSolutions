using System;
using System.Text;

namespace Utilities
{
    public class SpellNumbers
    {
        private readonly int _number;
        private bool _andAdded;
        private bool _needsAnd;
        public SpellNumbers(int number)
        {
            _number = number;
            _andAdded = false;
            _needsAnd = false;
        }

        private string Units(int number)
        {
            switch (number)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                default:
                    return "";
            }
        }

        private string Tens(int number)
        {
            if (number >= 90) return "ninety";
            if (number >= 80) return "eighty";
            if (number >= 70) return "seventy";
            if (number >= 60) return "sixty";
            if (number >= 50) return "fifty";
            if (number >= 40) return "forty";
            if (number >= 30) return "thirty";
            if (number >= 20) return "twenty";

            return "";
        }

        private string Hundreds(int number)
        {
            if (number >= 900) return "nine";
            if (number >= 800) return "eight";
            if (number >= 700) return "seven";
            if (number >= 600) return "six";
            if (number >= 500) return "five";
            if (number >= 400) return "four";
            if (number >= 300) return "three";
            if (number >= 200) return "two";
            if (number >= 100) return "one";

            return "";
        }

        private StringBuilder Decider(int number)
        {
            if (number == 1000)
            {
                return Decider(number % 1000).Insert(0, $"one thousand");
            }
            if (number >= 100)
            {
                _needsAnd = true;

                return Decider(number % 100).Insert(0, $" {Hundreds(number)} hundred");
            }
            if (number >= 20)
            {
                _andAdded = true;

                var spell = $"{(_needsAnd ? " and" : "")} {Tens(number)}";

                return Decider(number % 10).Insert(0, spell);
            }
            else if (number > 0)
            {
                var spell = $"{(_needsAnd && !_andAdded ? " and" : "")} {Units(number)}";

                return Decider(0).Insert(0, spell);
            }

            return new StringBuilder();
        }

        private string BuildSpelling()
        {
            return Decider(_number).ToString();
        }

        public static string Spell(int number)
        {
            if (number < 1 || number > 1000)
            {
                throw new NotImplementedException("Out of scope");
            }

            return new SpellNumbers(number).BuildSpelling().Trim();
        }
    }
}
