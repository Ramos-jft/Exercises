namespace Basic
{
    public class Exercise27
    {
        public static int SumOfDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        public static string GetDigitSumResult(int number)
        {
            int sum = SumOfDigits(number);
            return $"Sum of the digits of the said integer: {sum}";
        }
    }
}