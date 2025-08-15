namespace Basic
{
    public class Exercise13
    {
        public static string GetRectanglePattern(int number)
        {
            string solidLine = new string(char.Parse(number.ToString()), 3);
            string hollowLine = $"{number} {number}";

            return $"{solidLine}\r\n{hollowLine}\r\n{hollowLine}\r\n{hollowLine}\r\n{solidLine}";
        }
    }
}
