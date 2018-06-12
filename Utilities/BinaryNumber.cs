using System.Text;

namespace Utilities
{
    public struct BinaryNumber
    {
        private readonly string _number; 

        public BinaryNumber(int base10Number)
        {
            int aux = 1, i;

            do
            {
                i = aux;

                aux *= 2;
            } while (aux <= base10Number);

            var number = new StringBuilder();

            if (base10Number == 0) number.Append("0");
            else
            {
                while (i > 0)
                {
                    if (i <= base10Number)
                    {
                        number.Append("1");
                        base10Number -= i;
                    }
                    else number.Append("0");
                    i /= 2;
                }
            }

            _number = number.ToString();
        }

        public override string ToString()
        {
            return _number;
        }
    }
}
