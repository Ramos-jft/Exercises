namespace Basic
{
    public class Exercise12
    {
        public static string GetNumberPattern(int number)
        {
            string spaced = string.Format("{0} {0} {0} {0}", number);
            string unspaced = string.Format("{0}{0}{0}{0}", number);

            return $"{spaced}\r\n{unspaced}\r\n{spaced}\r\n{unspaced}";
        }
    }
}
