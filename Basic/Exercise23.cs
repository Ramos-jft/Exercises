namespace Basic
{
    public class Exercise23
    {
        public static string ConvertToLower(string input)
        {
            return input.ToLower();
        }

        public static string GetLowercaseResult(string input)
        {
            string result = ConvertToLower(input);
            return $"Lowercase result: {result}";
        }
    }
}