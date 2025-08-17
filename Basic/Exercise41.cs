using System;
using System.Linq;

namespace Basic
{
    public class Exercise41
    {
        public static bool CheckWCount(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            int wCount = input.Count(c => c == 'w' || c == 'W');
            return wCount >= 1 && wCount <= 3;
        }

        public static string GetCheckResult(string input)
        {
            bool result = CheckWCount(input);
            return $"Input a string (contains at least one 'w' char) : {input}\n" +
                   "Test the string contains 'w' character between 1 and 3 times:\n" +
                   $"{result}";
        }
    }
}