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

      
        }
    }
}