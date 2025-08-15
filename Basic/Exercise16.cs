namespace Basic
{
    public class Exercise16
    {
        public static string SwapFirstLastCharacters(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
                return input;

            char first = input[0];
            char last = input[input.Length - 1];

            return last + input.Substring(1, input.Length - 2) + first;
        }
    }
}