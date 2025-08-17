using System;
using System.Text;

namespace Basic
{
    public class Exercise44
    {
        public static string GetEveryOtherCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i += 2)
            {
                result.Append(input[i]);
            }
            return result.ToString();
        }

        public static string GetResultString(string input)
        {
            string result = GetEveryOtherCharacter(input);
            return $"Input a string : {input}\n{result}";
        }
    }
}