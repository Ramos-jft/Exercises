namespace Basic
{
    public class Exercise36
    {
        public static bool CheckInRange(int num1, int num2)
        {
            return (num1 >= -10 && num1 <= 10) || (num2 >= -10 && num2 <= 10);
        }

        public static string GetCheckResult(int num1, int num2)
        {
            bool result = CheckInRange(num1, num2);
            return $"Input a first number: {num1}\n" +
                   $"Input a second number: {num2}\n" +
                   $"{result}";
        }
    }
}