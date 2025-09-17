using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class MathExercises
    {
        /* Exercise 1 -  Write a C# Sharp program to get the absolute value of a number of Decimal values,
           Double values, Int16 values, Int32 values and Int64 values. */
        public static decimal GetDecimalAbs(decimal value)
        {
            return Math.Abs(value);
        }

        public static double GetDoubleAbs(double value)
        {
            return Math.Abs(value);
        }

        public static short GetInt16Abs(short value)
        {
            return Math.Abs(value);
        }

        public static int GetInt32Abs(int value)
        {
            return Math.Abs(value);
        }

        public static long GetInt64Abs(long value)
        {
            return Math.Abs(value);
        }

        // Exercise 2 - Write a C# Sharp program to find the maximum and smallest value of two variables.
        public static byte MaxByte(byte a, byte b) => Math.Max(a, b);
        public static short MaxInt16(short a, short b) => Math.Max(a, b);
        public static int MaxInt32(int a, int b) => Math.Max(a, b);
        public static long MaxInt64(long a, long b) => Math.Max(a, b);
        public static float MaxSingle(float a, float b) => Math.Max(a, b);
        public static double MaxDouble(double a, double b) => Math.Max(a, b);
        public static decimal MaxDecimal(decimal a, decimal b) => Math.Max(a, b);

        public static byte MinByte(byte a, byte b) => Math.Min(a, b);
        public static short MinInt16(short a, short b) => Math.Min(a, b);
        public static int MinInt32(int a, int b) => Math.Min(a, b);
        public static long MinInt64(long a, long b) => Math.Min(a, b);
        public static float MinSingle(float a, float b) => Math.Min(a, b);
        public static double MinDouble(double a, double b) => Math.Min(a, b);
        public static decimal MinDecimal(decimal a, decimal b) => Math.Min(a, b);

        // Exercise 3 - Write a C# Sharp program to calculate the value that results from raising 3 to a power ranging from 0 to 32.
        public static long CalculatePowerOfThree(int exponent)
        {
            return (long)Math.Pow(3, exponent);
        }

        /* Exercise 4 - Write a C# Sharp program to calculate true mean value,
           mean with rounding away from zero and mean with rounding to the nearest of some specified decimal values. */
        public static decimal CalculateTrueMean(decimal[] values)
        {
            decimal sum = 0;
            foreach (var value in values)
                sum += value;
            return Math.Round(sum / values.Length, 2);
        }

        public static decimal CalculateMeanAwayFromZero(decimal[] values)
        {
            decimal sum = 0;
            foreach (var value in values)
                sum += Math.Round(value, 1, MidpointRounding.AwayFromZero);
            return Math.Round(sum / values.Length, 2);
        }

        public static decimal CalculateMeanToNearest(decimal[] values)
        {
            decimal sum = 0;
            foreach (var value in values)
                sum += Math.Round(value, 1, MidpointRounding.ToEven);
            return Math.Round(sum / values.Length, 2);
        }

        // Exercise 5 - Write a C# Sharp program to determine the sign of a single value and display it on the console.
        public static int GetSign(byte value) => Math.Sign(value);
        public static int GetSign(short value) => Math.Sign(value);
        public static int GetSign(int value) => Math.Sign(value);
        public static int GetSign(long value) => Math.Sign(value);
        public static int GetSign(float value) => Math.Sign(value);
        public static int GetSign(double value) => Math.Sign(value);
        public static int GetSign(decimal value) => Math.Sign(value);

        // Exercise 6 - Write a C# Sharp program to calculate each city's square area based on the given area of some cities in the United States.
        public static double CalculateSquareSide(double area)
        {
            return Math.Round(Math.Sqrt(area), 2);
        }

        // Exercise 7 - Write a C# Sharp program to find the whole number and fractional part from a positive and negative Decimal number, Double number.
        public static decimal GetWholePart(decimal number) => Math.Truncate(number);
        public static decimal GetFractionalPart(decimal number) => number - Math.Truncate(number);

        public static double GetWholePart(double number) => Math.Truncate(number);
        public static double GetFractionalPart(double number) => number - Math.Truncate(number);

        // Exercise 8 - Write a C# Sharp program to calculate the quotient of two 32-bit signed integers and return the remainder as an output parameter.
        public static int DivideWithRemainder(int dividend, int divisor, out int remainder)
        {
            return Math.DivRem(dividend, divisor, out remainder);
        }

        // Exercise 9 - Write a C# Sharp program to calculate the full product of two 32-bit numbers.
        public static long MultiplyInt32(int a, int b)
        {
            return Math.BigMul(a, b);
        }

        // Exercise 10 - Write a C# Sharp program to reverse the digits of a 32-bit signed integer.
        public static int ReverseInteger(int x)
        {
            var result = 0;
            var maxVal = int.MaxValue / 10;
            var minVal = int.MinValue / 10;

            while (x != 0)
            {
                if (result > maxVal || result < minVal)
                    return 0;

                result = result * 10 + x % 10;
                x /= 10;
            }

            return result;
        }

        // Exercise 11 - Write a C# Sharp program to convert a given string value to a 32-bit signed integer.
        public static int StringToInteger(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0;

            var index = 0;
            var isNegative = false;

            while (index < str.Length && str[index] == ' ')
                index++;

            if (index < str.Length && str[index] == '-')
            {
                isNegative = true;
                index++;
            }
            else if (index < str.Length && str[index] == '+')
            {
                index++;
            }

            var maxDiv10 = int.MaxValue / 10;
            var result = 0;

            for (; index < str.Length; index++)
            {
                var digit = str[index] - '0';
                if (digit < 0 || digit > 9)
                    break;

                if (result > maxDiv10 || (result == maxDiv10 && digit > 7))
                    return isNegative ? int.MinValue : int.MaxValue;

                result = result * 10 + digit;
            }

            return isNegative ? -result : result;
        }

        /* Exercise 12 - Write a C# Sharp program to check whether a given integer is a palindrome integer or not.
           Return true if the number is a palindrome, otherwise return false. */
        public static bool IsPalindrome(int number)
        {
            if (number < 0)
                return false;
            if (number < 10)
                return true;

            var original = number;
            var reversed = 0;

            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            return original == reversed;
        }

        // Exercise 13 - Write a C# Sharp program to convert a given integer value to Roman numerals.
        public static string IntegerToRoman(int n)
        {
            string[] romanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            var roman = new StringBuilder();
            var index = 0;

            while (n > 0)
            {
                if (n >= values[index])
                {
                    roman.Append(romanSymbols[index]);
                    n -= values[index];
                }
                else
                {
                    index++;
                }
            }

            return roman.ToString();
        }

        /* Exercise 14 - Write a C# Sharp program to calculate the largest integral value less than or equal to
           and the smallest integral value greater than or equal to a given number. */
        public static double GetCeiling(double value) => Math.Ceiling(value);
        public static double GetFloor(double value) => Math.Floor(value);

        // Exercise 15 - Write a C# Sharp program to convert a given Roman numeral value to an integer value.
        public static int RomanToInteger(string roman)
        {
            var result = 0;
            for (var i = 0; i < roman.Length; i++)
            {
                if (i > 0 && GetRomanValue(roman[i]) > GetRomanValue(roman[i - 1]))
                {
                    result += GetRomanValue(roman[i]) - GetRomanValue(roman[i - 1]) * 2;
                }
                else
                {
                    result += GetRomanValue(roman[i]);
                }
            }
            return result;
        }

        private static int GetRomanValue(char c)
        {
            return c switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0
            };
        }

        /* Exercise 16 - Write a C# program to divide two given integers (dividend and divisor)
           and get the quotient without using multiplication, division and the mod operator. */
        public static int DivideWithoutOperators(int dividend, int divisor)
        {
            if (divisor == 0) return int.MaxValue;
            if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

            uint x = dividend > 0 ? (uint)dividend : (uint)-dividend;
            uint y = divisor > 0 ? (uint)divisor : (uint)-divisor;

            uint result = 0;
            while (x >= y)
            {
                uint temp = y;
                uint count = 1;
                while (x >= (temp << 1) && (temp << 1) > temp)
                {
                    temp <<= 1;
                    count <<= 1;
                }
                x -= temp;
                result += count;
            }

            return (dividend ^ divisor) < 0 ? -(int)result : (int)result;
        }

        /* Exercise 17 - Write a C# program to return the string representation of the product of two non-negative integers n1 and n2,
           given two non-negative integers n1 and n2. */
        public static string MultiplyStrings(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";

            var result = new int[num1.Length + num2.Length];

            for (var i = num1.Length - 1; i >= 0; i--)
            {
                for (var j = num2.Length - 1; j >= 0; j--)
                {
                    var product = (num1[i] - '0') * (num2[j] - '0');
                    var sum = product + result[i + j + 1];

                    result[i + j + 1] = sum % 10;
                    result[i + j] += sum / 10;
                }
            }

            var sb = new StringBuilder();
            var start = 0;
            while (start < result.Length && result[start] == 0)
                start++;

            for (var i = start; i < result.Length; i++)
                sb.Append(result[i]);

            return sb.Length == 0 ? "0" : sb.ToString();
        }

        // Exercise 18 - Write a C# Sharp program to compute the sum of the positive and negative numbers of an array of integers and display the largest sum.
        public static int FindLargestSum(int[] nums)
        {
            var positiveSum = nums.Where(x => x > 0).Sum();
            var negativeSum = nums.Where(x => x < 0).Sum();

            return System.Math.Abs(positiveSum) > System.Math.Abs(negativeSum) ? positiveSum : negativeSum;
        }

        // Exercise 19 - Write a C# Sharp program to find PI value up to n (given number) decimal places.
        public static decimal GetPiValue(int decimalPlaces)
        {
            return decimal.Round((decimal)Math.PI, decimalPlaces);
        }

        /* Exercise 20 - Write a C# Sharp program to find the Least Common Multiple (LCM) of more than two numbers.
           Take numbers from a given array of positive integers. */
        public static int CalculateLCM(int[] numbers)
        {
            return numbers.Aggregate((a, b) => a * b / GCD(a, b));
        }

        private static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        // Exercise 21 - Write a C# Sharp program to get the nth tetrahedral number from a given integer(n) value.
        public static int GetTetrahedralNumber(int n)
        {
            return n * (n + 1) * (n + 2) / 6;
        }

        // Exercise 22 - Write a C# Sharp program to sort a given positive number in descending/ascending order.
        public static int SortDescending(int number)
        {
            return int.Parse(string.Concat(number.ToString().OrderByDescending(x => x)));
        }

        public static int SortAscending(int number)
        {
            return int.Parse(string.Concat(number.ToString().OrderBy(x => x)));
        }

        // Exercise 23 - Write a C# Sharp program to check whether a given number (integer) is oddish or evenish.
        public static string CheckOddishEvenish(int number)
        {
            var sum = 0;
            var str = number.ToString();

            foreach (var digit in str)
            {
                sum += digit - '0';
            }

            return sum % 2 == 0 ? "Evenish" : "Oddish";
        }

        /* Exercise 24 - Write a C# Sharp program to reverse the binary representation of a
           given number and convert the reversed binary number into an integer. */
        public static int ReverseBinary(int number)
        {
            var binary = Convert.ToString(number, 2);
            var reversedBinary = new string(binary.Reverse().ToArray());
            return Convert.ToInt32(reversedBinary, 2);
        }

        /* Exercise 25 - Write a C# Sharp program to find the closest palindrome number of an integer.
           If there are two palindrome numbers in absolute distance return the smallest number. */
        public static int FindClosestPalindrome(int num)
        {
            if (IsNumberPalindrome(num)) return num;

            for (var i = 1; i <= num; i++)
            {
                if (IsNumberPalindrome(num - i)) return num - i;
                if (IsNumberPalindrome(num + i)) return num + i;
            }
            return 0;
        }

        private static bool IsNumberPalindrome(int n)
        {
            var numStr = n.ToString();
            var left = 0;
            var right = numStr.Length - 1;

            while (left < right)
            {
                if (numStr[left] != numStr[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        // Exercise 26 - Write a C# Sharp program that takes an integer and determines whether it is uban or not.
        public static bool IsUbanNumber(int n)
        {
            if (n > 999 && n <= 999999)
                return false;

            if (n > 999999)
                return true;

            if (n > 99)
                return false;

            return n % 10 != 4;
        }
    }
}
