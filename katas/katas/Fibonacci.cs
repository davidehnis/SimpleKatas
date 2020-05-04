using System;
using System.Collections.Generic;

namespace katas
{
    /// <summary>
    /// Create a Fibonacci sequence to the max place and sum all odds number up to 10000
    /// </summary>
    public class Fibonacci
    {
        public static double SumOfOddNumbers(int max)
        {
            var seq = ToSequence(max);
            var total = 0d;

            foreach (var num in seq)
            {
                if (Math.Abs(num % 2) < 0.001) continue;
                if (num >= 10000) continue;
                total += num;
            }

            return total;
        }

        public static List<double> ToSequence(int max)
        {
            var fib = new List<double>();
            for (var i = 0; i < max; i++)
            {
                fib.Add(Calculate(i));
            }

            return fib;
        }

        public static double Calculate(double n)
        {
            var a = 0d;
            var b = 1d;

            for (var i = 0; i < n; i++)
            {
                var temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}