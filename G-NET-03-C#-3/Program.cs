using System;

namespace CSharpAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Casting double to int
            // Explicit casting truncates decimal part
            double d = 9.99;
            int x = (int)d;
            Console.WriteLine(x);
            // Output: 9
            // Explanation: Casting double to int removes the fraction part (.99) without rounding.
            #endregion

            #region Q2: Integer Division Fix
            // Fix: Cast one of the operands to double so it performs floating-point division
            int n = 5;
            double d2 = (double)n / 2;
            Console.WriteLine(d2);
            // Output: 2.5
            #endregion
        }
    }
}