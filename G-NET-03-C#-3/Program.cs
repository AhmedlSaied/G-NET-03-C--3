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
            // Explanation: Direct (long)o fails because boxed value is int. Convert.ToInt64 handles the conversion safely.
            #endregion
            #region Q8: Avoid Exception using as or pattern matching
            object o8 = 10;
            long x8 = o8 is long l ? l : -1;
            Console.WriteLine(x8);
            // Output: -1
            // Explanation: Checks if object is long, if not assigns -1 safely.
            #endregion
            #region Q9: Null-conditional Operator
            string? name = null;
            Console.WriteLine(name?.Length);
            // Output: (Empty/Nothing)
            // Explanation: Safe navigation operator (?.) returns null instead of throwing NullReferenceException.
            #endregion
            #region Q10: Null-conditional with Null-coalescing
            string? name2 = null;
            int length = name2?.Length ?? 0;
            Console.WriteLine(length);
            // Output: 0
            // Explanation: name2?.Length evaluates to null, then ?? 0 falls back to 0.
            #endregion
            #region Q11: Handling Potential Issue in Parse
            string? s11 = null;
            // Solution: Use TryParse to avoid magic default strings
            if (int.TryParse(s11, out int result11))
            {
                Console.WriteLine(result11);
            }
            else
            {
                Console.WriteLine(0);
            }
            #endregion
            #region Q12: Fixing Null Forgiving Warning/Crash
            string? s12 = null;
            // Fix: Use null check instead of forcing with ! operator which causes runtime crash
            Console.WriteLine(s12?.Length ?? 0);
            #endregion
            #region Q13: Convert.ToInt32 with Null
            string? s13 = null;
            int x13 = Convert.ToInt32(s13);
            Console.WriteLine(x13);
            // Output: 0
            // Explanation: Convert.ToInt32 returns 0 when receiving null without throwing exception.
            #endregion
            #region Q14: Compare int.Parse vs Convert.ToInt32
            string? s14 = null;

            // A: int.Parse(null) -> Throws ArgumentNullException
            // int a = int.Parse(s14); 

            // B: Convert.ToInt32(null) -> Handles null safely and returns 0
            int b = Convert.ToInt32(s14);
            Console.WriteLine(b);
            // Explanation: Parse requires non-null string, Convert handles null by returning default value (0).
            #endregion
        }
    }
}