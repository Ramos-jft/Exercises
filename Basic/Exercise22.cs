namespace Basic
{
    public class Exercise22
    {
        public static bool CheckWithin20(int number)
        {
            return (Math.Abs(number - 100) <= 20) ||
                   (Math.Abs(number - 200) <= 20);
        }

        public static string GetCheckResult(int number)
        {
            bool result = CheckWithin20(number);
            return $"Check result: {result}";
        }
    }
}