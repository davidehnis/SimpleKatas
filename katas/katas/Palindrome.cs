using System;
using System.Linq;

namespace katas
{
    /// <summary>
    /// For each number in a range from low to high Sum all of the palindrome numbers in the sequence.
    /// </summary>
    public class Palindrome
    {
        public static bool Is(string text)
        {
            var ch = text.ToCharArray();
            Array.Reverse(ch);
            var reverse = new string(ch);
            var result = text.Equals(reverse, StringComparison.OrdinalIgnoreCase);
            return result;
        }

        public static int Sum(int low, int high)
        {
            var range = Enumerable.Range(low, high).ToList();
            var sum = 0;
            foreach (var num in range)
            {
                if (Is(num.ToString()))
                {
                    sum = sum + num;
                }
            }

            return sum;
        }
    }
}