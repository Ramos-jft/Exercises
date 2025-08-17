using System;
using System.Linq;

namespace Basic
{
    public class Exercise28
    {
        public static string ReverseWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return sentence;

            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public static string GetReversedSentenceResult(string sentence)
        {
            string reversed = ReverseWords(sentence);
            return $"Original String: {sentence}\nReverse String: {reversed}";
        }
    }
}