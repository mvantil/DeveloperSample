using System;
using System.Text;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        private const string preposition = "and";
        public static int GetFactorial(int n)
        {
            var multiplier = n;
            var factorial = 1;
            while (multiplier > 0)
            {
                factorial = factorial * multiplier;
                multiplier--;
            }

            return factorial;
        }

        public static string FormatSeparators(params string[] items)
        {
            var formatBuilder = new StringBuilder();
            if (items.Length > 0)
            {
                switch (items.Length)
                {
                    case 1:
                        {
                            formatBuilder.Append(items[items.Length - 1]);
                            break;
                        }
                    case 2:
                        {
                            formatBuilder.AppendFormat(PrepositionFormatter(items[items.Length - 2], items[items.Length - 1]));
                            break;
                        }
                    default:
                        {
                            for (var i = 0; i < items.Length - 2; i++)
                            {
                                formatBuilder.AppendFormat("{0}, ", items[i]);
                            }
                            formatBuilder.AppendFormat(PrepositionFormatter(items[items.Length - 2], items[items.Length - 1]));
                            break;
                        }
                }

            }

            return formatBuilder.ToString();
        }

        public static string PrepositionFormatter(string a, string b)
        {
            return string.Format("{0} {1} {2}", a, preposition, b);
        }
    }
}