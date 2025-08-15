namespace Basic
{
    public class Exercise07
    {
        public static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public static int SubtractTwoNumbers(int a, int b)
        {
            return a - b;
        }

        public static int MultiplyTwoNumbers(int a, int b)
        {
            return a * b;
        }

        public static int DivideTwoNumbers(int a, int b)
        {
            return a / b;
        }

        public static int ModulusTwoNumbers(int a, int b)
        {
            return a % b;
        }

        public static string GetOperationResults(int a, int b)
        {
            return $"{a} + {b} = {AddTwoNumbers(a, b)}\r\n" +
                   $"{a} - {b} = {SubtractTwoNumbers(a, b)}\r\n" +
                   $"{a} x {b} = {MultiplyTwoNumbers(a, b)}\r\n" +
                   $"{a} / {b} = {DivideTwoNumbers(a, b)}\r\n" +
                   $"{a} mod {b} = {ModulusTwoNumbers(a, b)}";
        }
    }
}
