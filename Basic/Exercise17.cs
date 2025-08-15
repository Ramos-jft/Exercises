namespace Basic
{
    public class Exercise17
    {
        public static string AddFirstCharFrontAndBack(string input)
        {
            char firstChar = input[0];
            return firstChar + input + firstChar;
        }
    }
}