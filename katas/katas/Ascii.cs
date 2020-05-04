using System.Linq;

namespace katas
{
    /// <summary>
    /// Sum the total characters' ASCII value.  For vowels, add the inverse.
    /// </summary>
    public class Ascii
    {
        public static int Sum(string text)
        {
            var stripped = text.Where(char.IsLetter).ToList();

            var total = 0;
            foreach (var c in stripped)
            {
                var ascii = (int)c;
                if (IsVowel(c))
                {
                    total += (ascii * -1);
                }
                else
                {
                    total += ascii;
                }
            }

            return total;
        }

        public static bool IsVowel(char c)
        {
            return "aeiouAEIOU".IndexOf(c) >= 0;
        }
    }
}