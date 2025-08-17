using System;

namespace Basic
{
    public class Exercise37
    {
        public static string RemoveHP(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 3)
                return input;

            if (input.Substring(1, 2).Equals("HP", StringComparison.OrdinalIgnoreCase))
            {
                return input.Remove(1, 2);
            }
            return input;
        }

        public static string GetModifiedString(string input)
        {
            string result = RemoveHP(input);
            return $"Original String: {input}\nModified String: {result}";
        }
    }
}