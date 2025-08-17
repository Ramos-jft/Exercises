using System;

namespace Basic
{
    public class Exercise43
    {
        public static bool CheckWWWStart(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 3)
                return false;

            return input.StartsWith("w") &&
                   input.Substring(1, 2) == "ww";
        }

        public static string GetCheckResult(string input)
        {
            bool result = CheckWWWStart(input);
            return $"Input a string : {input}\n{result}";
        }
    }
}