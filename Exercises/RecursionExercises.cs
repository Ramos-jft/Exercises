using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class RecursionExercises
    {
        // Exercise 1 - Write a program in C# Sharp to print the first n natural numbers using recursion.
        public static string PrintNaturalNumbers(int n)
        {
            if (n <= 0) return "";
            var result = PrintNaturalNumbers(n - 1);
            return string.IsNullOrEmpty(result) ? n.ToString() : $"{result} {n}";
        }

        // Exercise 2 - Write a program in C# Sharp to print numbers from n to 1 using recursion.
        public static string PrintNumbersFromNTo1(int n)
        {
            if (n <= 0) return "";
            var result = PrintNumbersFromNTo1(n - 1);
            return string.IsNullOrEmpty(result) ? n.ToString() : $"{n} {result}";
        }

        // Exercise 3 - Write a program in C# Sharp to find the sum of the first n natural numbers using recursion.
        public static int SumOfFirstNNaturalNumbers(int n)
        {
            if (n <= 0) return 0;
            return n + SumOfFirstNNaturalNumbers(n - 1);
        }

        // Exercise 4 - Write a program in C# Sharp to display the individual digits of a given number using recursion.
        public static string DisplayIndividualDigits(int number)
        {
            if (number < 10) return number.ToString();
            var result = DisplayIndividualDigits(number / 10);
            return $"{result} {number % 10}";
        }

        // Exercise 5 - Write a program in C# Sharp to count the number of digits in a number using recursion.
        public static int CountDigits(int number)
        {
            if (number == 0) return 0;
            return 1 + CountDigits(number / 10);
        }

        // Exercise 6 - Write a program in C to print even or odd numbers in a given range using recursion.
        public static string PrintEvenNumbers(int start, int end)
        {
            if (start > end) return "";
            var result = PrintEvenNumbers(start + 2, end);
            return string.IsNullOrEmpty(result) ? start.ToString() : $"{start} {result}";
        }

        public static string PrintOddNumbers(int start, int end)
        {
            if (start > end) return "";
            var result = PrintOddNumbers(start + 2, end);
            return string.IsNullOrEmpty(result) ? start.ToString() : $"{start} {result}";
        }

        // Exercise 7 - Write a program in C# Sharp to check whether a number is prime or not using recursion.
        public static bool IsPrime(int number, int divisor = 2)
        {
            if (number <= 1) return false;
            if (divisor * divisor > number) return true;
            if (number % divisor == 0) return false;
            return IsPrime(number, divisor + 1);
        }

        // Exercise 8 - Write a program in C# Sharp to check whether a given string is a palindrome or not using recursion.
        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1) return true;
            if (text[0] != text[text.Length - 1]) return false;
            return IsPalindrome(text.Substring(1, text.Length - 2));
        }

        // Exercise 9 - Write a program in C# Sharp to find the factorial of a given number using recursion.
        public static long Factorial(int number)
        {
            if (number <= 1) return 1;
            return number * Factorial(number - 1);
        }

        // Exercise 10 - Write a program in C# Sharp to find the Fibonacci numbers for a series of n numbers using recursion.
        public static string FibonacciSeries(int n)
        {
            if (n <= 0) return "";
            if (n == 1) return "0";
            if (n == 2) return "0 1";

            var previous = FibonacciSeries(n - 1);
            var numbers = previous.Split(' ');
            var last = int.Parse(numbers[^1]);
            var secondLast = int.Parse(numbers[^2]);
            var next = last + secondLast;

            return $"{previous} {next}";
        }

        // Exercise 11 - Write a program in C# Sharp to generate all possible permutations of an array using recursion.
        public static List<string> GeneratePermutations(int[] arr)
        {
            var result = new List<string>();
            GeneratePermutations(arr, 0, arr.Length - 1, result);
            return result;
        }

        private static void GeneratePermutations(int[] arr, int start, int end, List<string> result)
        {
            if (start == end)
            {
                result.Add(string.Join("", arr));
                return;
            }

            for (var i = start; i <= end; i++)
            {
                Swap(ref arr[start], ref arr[i]);
                GeneratePermutations(arr, start + 1, end, result);
                Swap(ref arr[start], ref arr[i]);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        // Exercise 12 - Write a program in C# Sharp to find the LCM and GCD of two numbers using recursion.
        public static int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        // Exercise 13 - Write a program in C# Sharp to convert a decimal number to binary using recursion.
        public static string DecimalToBinary(int number)
        {
            if (number == 0) return "0";
            if (number == 1) return "1";
            return DecimalToBinary(number / 2) + (number % 2).ToString();
        }

        // Exercise 14 - Write a program in C# Sharp to get the reverse of a string using recursion.
        public static string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            return ReverseString(str.Substring(1)) + str[0];
        }

        // Exercise 15 - Write a program in C# Sharp to calculate the power of any number using recursion.
        public static long CalculatePower(int baseNumber, int exponent)
        {
            if (exponent == 0) return 1;
            return baseNumber * CalculatePower(baseNumber, exponent - 1);
        }
    }
}
