using System;

namespace Basic
{
    public class Exercise32
    {
        public static string GetLastFourCopies(string input)
        {
            string lastFour = input.Substring(input.Length - 4);
            return string.Concat(lastFour, lastFour, lastFour, lastFour);
        }
    }
}