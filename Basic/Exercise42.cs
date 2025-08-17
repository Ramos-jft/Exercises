using System;

namespace Basic
{
    public class Exercise42
    {
        public static string TransformString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            if (input.Length < 4)
                return input.ToUpper();

            string firstFour = input.Substring(0, 4).ToLower();
            string rest = input.Length > 4 ? input.Substring(4).ToUpper() : "";

            return firstFour + rest;
        }

        public static string GetTransformedResult(string input)
        {
            string result = TransformString(input);
            return $"Input a string: {input}\n{result}";
        }
    }
}