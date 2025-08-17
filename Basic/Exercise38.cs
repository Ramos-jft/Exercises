using System;

namespace Basic
{
    public class Exercise38
    {
        public static string ExtractPH(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
                return string.Empty;

            if (input[0] == 'P' && input[1] == 'H')
                return "PH";

            return string.Empty;
        }

        public static string GetExtractionResult(string input)
        {
            string result = ExtractPH(input);
            return $"Test Data: {input}\nExtracted: {result}";
        }
    }
}