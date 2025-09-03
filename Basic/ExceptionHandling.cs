using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Net.Http;

namespace Exercises
{
    public class ExceptionHandling
    {
        /* Exercise 1 - Write a C# program that prompts the user to input two numbers and divides them. 
       Handle an exception when the user enters non-numeric values.*/
        public static double DivideNumbers(string firstInput, string secondInput)
        {
            try
            {
                var number1 = Convert.ToDouble(firstInput);
                var number2 = Convert.ToDouble(secondInput);

                if (number2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                return number1 / number2;
            }
            catch (FormatException)
            {
                throw new FormatException("Non-numeric value entered.");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Value is too large or too small.");
            }
        }

        /* Exercise 2 - Write a C# program to implement a method that takes an integer as input 
        and throws an exception if the number is negative.Handle the exception in the calling code.*/
        public static void ValidatePositiveNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException("Negative number not allowed.");
            }
        }

        public static void ValidatePositiveNumber(string input)
        {
            try
            {
                var number = Convert.ToInt32(input);
                ValidatePositiveNumber(number);
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid input. Please enter an integer.");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Value is too large or too small for an integer.");
            }
        }

        public class NegativeNumberException : Exception
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        /*Exercise 3 - Write a C# program that reads a file path from the user and tries to open the file. 
        Handle exceptions if the file does not exist.*/
        public static void OpenFile(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty.");
            }

            using (var reader = new StreamReader(filePath))
            {
                // File opened successfully
            }
        }

        public static string ReadFileContent(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path cannot be null or empty.");
            }

            using (var reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }

        /* Exercise 4 - Write a C# program that prompts the user to input a numeric integer and throws an exception 
        if the number is less than 0 or greater than 1000.*/
        public static void ValidateNumberInRange(int number)
        {
            if (number < 0 || number > 1000)
            {
                throw new ArgumentOutOfRangeException("Number must be between 0 and 1000.");
            }
        }

        public static void ValidateNumberInRange(string input)
        {
            try
            {
                var number = Convert.ToInt32(input);
                ValidateNumberInRange(number);
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid input. Please enter an integer.");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Value is too large or too small for an integer.");
            }
        }

        /* Exercise 5 - Write a C# program that implements a method that takes an array of 
        integers as input and calculates the average value. Handle the exception if the array is empty.*/
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers), "Array cannot be null.");
            }

            if (numbers.Length == 0)
            {
                throw new EmptyArrayException("Array is empty. Cannot calculate average.");
            }

            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return (double)sum / numbers.Length;
        }
        public class EmptyArrayException : Exception
        {
            public EmptyArrayException(string message) : base(message) { }
        }

        /* Exercise 6 - Write a C# program that reads a string from the user and converts it to an integer. 
        Handle the exception if the input cannot be parsed into an integer.*/
        public static int ConvertToInt(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or empty.");
            }

            return int.Parse(input);
        }

        public static bool TryConvertToInt(string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        /* Exercise 7 - Write a C# program that reads a list of integers from the user. 
        Handle the exception that occurs if the user enters a value outside the range of Int32.*/
        public static int ConvertToInt32(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or empty.");
            }

            return int.Parse(input);
        }

        public static List<int> ReadIntegersFromInput(List<string> inputs)
        {
            var numbers = new List<int>();

            foreach (var input in inputs)
            {
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var number = ConvertToInt32(input);
                numbers.Add(number);
            }

            return numbers;
        }

        /* Exercise 8 - Write a C# program that implements a method that divides two numbers.
        Handle the DivideByZeroException that occurs if the denominator is 0.*/
        public static int DivideNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return numerator / denominator;
        }

        public static double DivideNumbersDouble(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return (double)numerator / denominator;
        }

        /* Exercise 9 - Write a C# program that creates a method that reads a date from the user in the format "dd/mm/yyyy" 
        and converts it to a DateTime object. Handle an exception if the input format is invalid.*/
        public static DateTime ConvertToDate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or empty.");
            }

            var format = "dd/MM/yyyy";
            return DateTime.ParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None);
        }

        public static bool TryConvertToDate(string input, out DateTime result)
        {
            result = DateTime.MinValue;

            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            var format = "dd/MM/yyyy";
            return DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
        }

        /* Exercise 10 - Write a C# program that reads a number from the user and calculates its square root. 
        Handle the exception if the number is negative.*/
        public static double CalculateSquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be negative.");
            }

            return Math.Sqrt(number);
        }

        public static double CalculateSquareRoot(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be null or empty.");
            }

            try
            {
                var number = Convert.ToDouble(input);
                return CalculateSquareRoot(number);
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid input. Please input a valid number.");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Value is too large or too small.");
            }
        }

        public static bool TryCalculateSquareRoot(string input, out double result)
        {
            result = 0;

            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            if (!double.TryParse(input, out var number))
            {
                return false;
            }

            if (number < 0)
            {
                return false;
            }

            result = Math.Sqrt(number);
            return true;
        }

        /* Exercise 11 - Write a C# program that creates a method that takes a string as input and converts it to uppercase. 
        Handle the NullReferenceException that occurs if the input string is null.*/
        public static string ConvertToUppercase(string input)
        {
            if (input == null)
            {
                throw new NullReferenceException("Input string is null.");
            }

            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string is null or empty.");
            }

            return input.ToUpper();
        }

        public static bool TryConvertToUppercase(string input, out string result)
        {
            result = null;

            if (input == null || string.IsNullOrEmpty(input))
            {
                return false;
            }

            result = input.ToUpper();
            return true;
        }

        /* Exercise 12 - Write a C# program that creates a method that calculates the factorial of a given number. 
        Handle the OverflowException that occurs if the result exceeds the Int32 maximum value.*/
        public static int CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                checked
                {
                    factorial *= i;
                }
            }

            return factorial;
        }

        public static long CalculateFactorialLong(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }

            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                checked
                {
                    factorial *= i;
                }
            }

            return factorial;
        }

        public static bool TryCalculateFactorial(int number, out int result)
        {
            result = 0;

            if (number < 0)
            {
                return false;
            }

            try
            {
                result = CalculateFactorial(number);
                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }

        /* Exercise 13 - Write a C# program that reads a list of URLs from the user and downloads the content of each URL. 
        Handle the exception if any URL is inaccessible.*/
        public static string DownloadContent(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("URL cannot be null or empty.");
            }

            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                throw new ArgumentException("Invalid URL format.");
            }

            using (var webClient = new WebClient())
            {
                try
                {
                    return webClient.DownloadString(uri);
                }
                catch (WebException ex)
                {
                    throw new WebException($"Error accessing URL '{url}': {ex.Message}", ex);
                }
            }
        }

        public static List<string> DownloadContents(List<string> urls)
        {
            var results = new List<string>();

            foreach (var url in urls)
            {
                try
                {
                    var content = DownloadContent(url);
                    results.Add($"Success: {url}\nContent: {content}\n");
                }
                catch (Exception ex)
                {
                    results.Add($"Error: {url} - {ex.Message}");
                }
            }

            return results;
        }

        public static async Task<string> DownloadContentAsync(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("URL cannot be null or empty.");
            }

            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri))
            {
                throw new ArgumentException("Invalid URL format.");
            }

            using (var webClient = new WebClient())
            {
                try
                {
                    return await webClient.DownloadStringTaskAsync(uri);
                }
                catch (WebException ex)
                {
                    throw new WebException($"Error accessing URL '{url}': {ex.Message}", ex);
                }
            }
        }
    }
}
