namespace Exercises
{
    public class FunctionExercises
    {
        // Exercise 1 - Write a program in C# Sharp to create a user defined function.
        public static void Welcome()
        {
            System.Console.WriteLine("Welcome Friends!");
        }

        public static void HaveAnice()
        {
            System.Console.WriteLine("Have a nice day!");
        }

        // Exercise 2 - Write a program in C# Sharp to create a user defined function with parameters.
        public static void Welcome(string name)
        {
            System.Console.WriteLine($"Welcome friend {name} !");
        }

        public static void HaveNiceDay()
        {
            System.Console.WriteLine("Have a nice day!");
        }

        // Exercise 3 - Write a program in C# Sharp to create a function for the sum of two numbers.
        public static int SumTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        // Exercise 4 - Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.
        public static int CountSpaces(string str)
        {
            var spaceCount = 0;
            foreach (var character in str)
            {
                if (character == ' ')
                    spaceCount++;
            }
            return spaceCount;
        }

        // Exercise 5 - Write a program in C# Sharp to calculate the sum of elements in an array.
        public static int SumArrayElements(int[] arr)
        {
            var total = 0;
            foreach (var element in arr)
            {
                total += element;
            }
            return total;
        }

        // Exercises 6 - Write a program in C# Sharp to create a function to swap two integer numbers.
        public static void SwapNumbers(ref int num1, ref int num2)
        {
            var temp = num1;
            num1 = num2;
            num2 = temp;
        }

        // Exercise 7 - Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
        public static int CalculatePower(int num, int exp)
        {
            var result = 1;
            for (var i = 0; i < exp; i++)
            {
                result *= num;
            }
            return result;
        }

        // Exercise 8 - Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            var a = 0;
            var b = 1;

            for (var i = 2; i <= n; i++)
            {
                var temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        // Exercise 9 - Write a program in C# Sharp to create a function to check whether a number is prime or not.
        public static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (var i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        // Exercise 10 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        public static int SumDigits(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        // Exercise 11 - Write a program in C# Sharp to create a recursive function to find the factorial of a given number.
        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        // Exercise 12 - Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
        public static int FibonacciRecursive(int n)
        {
            if (n <= 2)
                return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
