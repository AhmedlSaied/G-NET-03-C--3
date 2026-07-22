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
            #region Q3: Read Age from User
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine() ?? "0");
            #endregion
            #region Q4: int.Parse Invalid String
            // string s = "12a";
            // int x = int.Parse(s);
            // Console.WriteLine(x);
            // Explanation: Throws FormatException at runtime because "12a" contains non-numeric characters.
            #endregion
            #region Q5: Safe Conversion with TryParse
            string s5 = "12a";
            if (int.TryParse(s5, out int parsedVal))
            {
                Console.WriteLine(parsedVal);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            #endregion
            #region Q6: Unboxing Int
            object o6 = 10;
            int a6 = (int)o6;
            Console.WriteLine(a6 + 1);
            // Output: 11
            // Explanation: Unboxing object o to int extracts 10, then adding 1 gives 11.
            #endregion
            #region Q7: Invalid Unboxing Type Handling
            object o7 = 10;
            // Handling: Convert safely instead of direct casting to avoid InvalidCastException
            if (o7 is long lVal)
            {
                Console.WriteLine(lVal);
            }
            else
            {
                long x7 = Convert.ToInt64(o7);
                Console.WriteLine(x7);
            }
        }
    }
}