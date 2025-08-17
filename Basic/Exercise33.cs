namespace Basic
{
    public class Exercise33
    {
        public static bool IsMultipleOf3Or7(int number)
        {
            if (number <= 0)
                return false;

            return number % 3 == 0 || number % 7 == 0;
        }

        public static string GetCheckResult(int number)
        {
            bool result = IsMultipleOf3Or7(number);
            return $"Input first integer:\n{number}\n{result}";
        }
    }
}