using System;

namespace Basic
{
    public class Exercise34
    {
        public static bool StartsWithHello(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            return input.TrimStart().StartsWith("Hello", StringComparison.OrdinalIgnoreCase);
        }

        public static string GetCheckResult(string input)
        {
            bool result = StartsWithHello(input);
            return $"Input a string : {input}\n{result}";
        }
    }
}