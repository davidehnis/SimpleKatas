using System;
using System.Linq;
using System.Text;

namespace katas
{
    /// <summary>
    /// Counts the Occurrences of a Roman Numeral with a Range from low to high of integers
    /// </summary>
    public class Legion
    {
        public static int CountOccurrences(int low, int high, char search)
        {
            var range = Enumerable.Range(low, high).ToList();
            var sb = new StringBuilder();
            foreach (var num in range)
            {
                sb.Append(ToRomanNumeral(num));
            }

            return sb.ToString().Count(x => x == search);
        }

        private static string ToRomanNumeral(int number)
        {
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRomanNumeral(number - 1000);
            if (number >= 900) return "CM" + ToRomanNumeral(number - 900);
            if (number >= 500) return "D" + ToRomanNumeral(number - 500);
            if (number >= 400) return "CD" + ToRomanNumeral(number - 400);
            if (number >= 100) return "C" + ToRomanNumeral(number - 100);
            if (number >= 90) return "XC" + ToRomanNumeral(number - 90);
            if (number >= 50) return "L" + ToRomanNumeral(number - 50);
            if (number >= 40) return "XL" + ToRomanNumeral(number - 40);
            if (number >= 10) return "X" + ToRomanNumeral(number - 10);
            if (number >= 9) return "IX" + ToRomanNumeral(number - 9);
            if (number >= 5) return "V" + ToRomanNumeral(number - 5);
            if (number >= 4) return "IV" + ToRomanNumeral(number - 4);
            if (number >= 1) return "I" + ToRomanNumeral(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
    }
}