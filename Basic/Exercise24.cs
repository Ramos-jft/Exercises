using System.Linq;

namespace Basic
{
    public class Exercise24
    {
        public static string FindLongestWord(string input)
        {
            // Split into words, removing punctuation
            var words = input.Split(' ')
                           .Select(w => new string(w.Where(c => char.IsLetter(c)).ToArray()));

            return words.OrderByDescending(w => w.Length).First();
        }
    }
}