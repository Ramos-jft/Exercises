namespace Basic
{
    public class Exercise35
    {
        public static bool CheckNumbers(int num1, int num2)
        {
            return num1 < 100 && num2 > 200;
        }

        public static string GetCheckResult(int num1, int num2)
        {
            bool result = CheckNumbers(num1, num2);
            return $"Input a first number(<100): {num1}\n" +
                   $"Input a second number(>200): {num2}\n" +
                   $"{result}";
        }
    }
}