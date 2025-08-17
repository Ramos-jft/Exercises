using System;

namespace Basic
{
    public class Exercise40
    {
        public static int FindNearestTo20(int num1, int num2)
        {

            if (num1 == num2)
            {
                return 0;
            }

            int diff1 = Math.Abs(num1 - 20);
            int diff2 = Math.Abs(num2 - 20);

            if (diff1 == diff2)
            {
                return 0;
            }

            return diff1 < diff2 ? num1 : num2;
        }

        public static string GetNearestResult(int num1, int num2)
        {
            int result = FindNearestTo20(num1, num2);
            return $"Input first integer:\n{num1}\n" +
                   $"Input second integer:\n{num2}\n" +
                   $"Nearest to 20: {result}";
        }
    }
}