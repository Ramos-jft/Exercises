using System.Globalization;

namespace Exercises
{
    public class ForLoop
    {
        // Exercise 1 - Write a program in C# Sharp to display the first 10 natural numbers.
        public static List<int> GetFirst10NaturalNumbers()
        {
            var numbers = new List<int>();
            for (var i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        // Exercise 2 - Write a C# Sharp program to find the sum of the first 10 natural numbers.
        public static int SumFirst10NaturalNumbers()
        {
            var sum = 0;
            for (var i = 1; i <= 10; i++)
            {
                sum += i;
            }
            return sum;
        }

        // Exercise 3 - Write a C# Sharp program that displays the sum of n natural numbers.
        public static int SumNaturalNumbers(int n)
        {
            var sum = 0;
            for (var i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        // Exercise 4 - Write a C# Sharp program to read 10 numbers and find their average and sum.
        public static (int Sum, double Average) CalculateSumAndAverage(int[] numbers)
        {
            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            var average = (double)sum / numbers.Length;
            return (sum, average);
        }

        // Exercise 5 - Write a C# Sharp program to display the cube of an integer up to given number.
        public static List<int> GetCubes(int n)
        {
            var cubes = new List<int>();
            for (var i = 1; i <= n; i++)
            {
                cubes.Add(i * i * i);
            }
            return cubes;
        }

        // Exercise 6 - Write a program in C# Sharp to display the multiplication table of a given integer.
        public static List<int> GetMultiplicationTable(int number)
        {
            var table = new List<int>();
            for (var i = 1; i <= 10; i++)
            {
                table.Add(number * i);
            }
            return table;
        }

        // Exercise 7 - Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
        public static List<List<int>> GetVerticalMultiplicationTable(int n)
        {
            var table = new List<List<int>>();

            for (var i = 1; i <= 10; i++)
            {
                var row = new List<int>();
                for (var j = 1; j <= n; j++)
                {
                    row.Add(j * i);
                }
                table.Add(row);
            }

            return table;
        }

        // Exercise 8 - Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
        public static (List<int> OddNumbers, int Sum) GetOddNumbersAndSum(int n)
        {
            var oddNumbers = new List<int>();
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                var oddNumber = 2 * i - 1;
                oddNumbers.Add(oddNumber);
                sum += oddNumber;
            }

            return (oddNumbers, sum);
        }

        // Exercise 9 - Write a program in C# Sharp to display a right angle triangle with an asterisk.
        public static List<string> GenerateRightAngleTriangle(int rows)
        {
            var triangle = new List<string>();
            for (var i = 1; i <= rows; i++)
            {
                triangle.Add(new string('*', i));
            }
            return triangle;
        }

        // Exercise 10 - Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
        public static List<string> GenerateNumberTriangle(int rows)
        {
            var triangle = new List<string>();
            for (var i = 1; i <= rows; i++)
            {
                var row = "";
                for (var j = 1; j <= i; j++)
                {
                    row += j;
                }
                triangle.Add(row);
            }
            return triangle;
        }

        // Exercise 11 - Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
        public static List<string> GenerateRepeatingNumberTriangle(int rows)
        {
            var triangle = new List<string>();
            for (var i = 1; i <= rows; i++)
            {
                triangle.Add(new string(char.Parse(i.ToString()), i));
            }
            return triangle;
        }

        // Exercise 12 - Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
        public static List<List<int>> GenerateIncreasingNumberTriangle(int rows)
        {
            var triangle = new List<List<int>>();
            var currentNumber = 1;

            for (var i = 1; i <= rows; i++)
            {
                var row = new List<int>();
                for (var j = 1; j <= i; j++)
                {
                    row.Add(currentNumber);
                    currentNumber++;
                }
                triangle.Add(row);
            }

            return triangle;
        }

        // Exercise 13 - Write a program in C# Sharp to make such a pattern like a pyramid with numbers increasing by 1.
        public static List<string> GenerateNumberPyramid(int rows)
        {
            var pyramid = new List<string>();
            var currentNumber = 1;

            for (var i = 1; i <= rows; i++)
            {
                var spaces = new string(' ', rows - i);
                var rowNumbers = new List<string>();

                for (var j = 1; j <= i; j++)
                {
                    rowNumbers.Add(currentNumber.ToString());
                    currentNumber++;
                }

                pyramid.Add(spaces + string.Join(" ", rowNumbers));
            }

            return pyramid;
        }

        // Exercise 14 - Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
        public static List<string> GenerateAsteriskPyramid(int rows)
        {
            var pyramid = new List<string>();

            for (var i = 1; i <= rows; i++)
            {
                var spaces = new string(' ', rows - i);
                var asterisks = new string('*', i).Replace("*", "* ").TrimEnd();
                pyramid.Add(spaces + asterisks);
            }

            return pyramid;
        }

        // Exercise 15 - Write a C# Sharp program to calculate the factorial of a given number.
        public static int CalculateFactorial(int number)
        {
            var factorial = 1;
            for (var i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        // Exercise 16 - Write a program in C# Sharp to display the n terms of even natural number and their sum.
        public static (List<int> EvenNumbers, int Sum) GetEvenNumbersAndSum(int n)
        {
            var evenNumbers = new List<int>();
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                var evenNumber = 2 * i;
                evenNumbers.Add(evenNumber);
                sum += evenNumber;
            }

            return (evenNumbers, sum);
        }

        // Exercise 17 - Write a program in C# Sharp to make such a pattern like a pyramid with a number which will repeat the number in the same row.
        public static List<string> GenerateRepeatingNumberPyramid(int rows)
        {
            var pyramid = new List<string>();

            for (var i = 1; i <= rows; i++)
            {
                var spaces = new string(' ', rows - i);
                var numbers = new string(char.Parse(i.ToString()), i).Replace(i.ToString(), i + " ").TrimEnd();
                pyramid.Add(spaces + numbers);
            }

            return pyramid;
        }

        // Exercise 18 - Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........].
        public static double CalculateSeriesSum(double x, int n)
        {
            var sum = 1.0;
            var term = 1.0;

            for (var i = 1; i < n; i++)
            {
                var denominator = (2 * i) * (2 * i - 1);
                term = -term * x * x / denominator;
                sum += term;
            }

            return sum;
        }

        // Exercise 19 - Write a program in C# Sharp to display the n terms of harmonic series and their sum.
        public static double CalculateHarmonicSeriesSum(int n)
        {
            var sum = 0.0;
            for (var i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }

        // Exercise 20 - Write a program in C# Sharp to display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks.
        public static List<string> GenerateOddAsteriskPyramid(int rows)
        {
            var pyramid = new List<string>();

            for (var i = 1; i <= rows; i++)
            {
                var spaces = new string(' ', rows - i);
                var asterisks = new string('*', 2 * i - 1);
                pyramid.Add(spaces + asterisks);
            }

            return pyramid;
        }

        // Exercise 21 - Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
        public static (List<long> Series, long Sum) CalculateNineSeries(int n)
        {
            var series = new List<long>();
            long term = 9;
            long sum = 0;

            for (var i = 1; i <= n; i++)
            {
                series.Add(term);
                sum += term;
                term = term * 10 + 9;
            }

            return (series, sum);
        }

        // Exercise 22 - Write a program in C# Sharp to print Floyd's Triangle.
        public static List<string> GenerateFloydsTriangle(int rows)
        {
            var triangle = new List<string>();

            for (var i = 1; i <= rows; i++)
            {
                var row = "";
                for (var j = 1; j <= i; j++)
                {
                    row += (i + j) % 2 == 0 ? "1" : "0";
                }
                triangle.Add(row);
            }

            return triangle;
        }

        // Exercise 23 - Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....].
        public static double CalculateExponentialSeries(double x, int n)
        {
            var sum = 1.0;
            var term = 1.0;

            for (var i = 1; i < n; i++)
            {
                term *= x / i;
                sum += term;
            }

            return sum;
        }

        // Exercise 24 - Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....].
        public static double CalculateAlternatingPowerSeries(double x, int n)
        {
            var sum = 0.0;
            var term = 1.0;
            var power = 1;

            for (var i = 1; i <= n; i++)
            {
                var currentTerm = term * Math.Pow(x, power);
                sum += currentTerm;
                term *= -1;
                power += 2;
            }

            return sum;
        }

        // Exercise 25 - Write a C# Sharp program that displays the n terms of square natural numbers and their sum.
        public static (List<int> Squares, int Sum) CalculateSquareNumbers(int n)
        {
            var squares = new List<int>();
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {
                var square = i * i;
                squares.Add(square);
                sum += square;
            }

            return (squares, sum);
        }

        // Exercise 26 - Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
        public static (long Sum, List<long> Terms) CalculateOnesSeries(int n)
        {
            var terms = new List<long>();
            long term = 1;
            long sum = 0;

            for (var i = 1; i <= n; i++)
            {
                terms.Add(term);
                sum += term;
                term = term * 10 + 1;
            }

            return (sum, terms);
        }

        // Exercise 27 - Write a C# Sharp program for checking if a number is a perfect number.
        public static (List<int> Divisors, int Sum, bool IsPerfect) CheckPerfectNumber(int number)
        {
            var divisors = new List<int>();
            var sum = 0;

            for (var i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                    sum += i;
                }
            }

            var isPerfect = sum == number;
            return (divisors, sum, isPerfect);
        }

        // Exercise 28 - Write a C# Sharp program to find the ‘perfect’ numbers within a given number range.
        public static List<int> FindPerfectNumbersInRange(int start, int end)
        {
            var perfectNumbers = new List<int>();

            for (var n = start; n <= end; n++)
            {
                var sum = 0;
                for (var i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == n)
                {
                    perfectNumbers.Add(n);
                }
            }

            return perfectNumbers;
        }

        // Exercise 29 - Write a C# Sharp program to check whether a given number is an Armstrong number or not.
        public static bool IsArmstrongNumber(int number)
        {
            var sum = 0;
            var temp = number;
            var digits = number.ToString().Length;

            for (; number != 0; number /= 10)
            {
                var digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
            }

            return sum == temp;
        }

        // Exercise 30 - Write a C# Sharp program to find the Armstrong number for a given range of numbers.
        public static List<int> FindArmstrongNumbersInRange(int start, int end)
        {
            var armstrongNumbers = new List<int>();

            for (var num = start; num <= end; num++)
            {
                var sum = 0;
                var temp = num;
                var digits = num.ToString().Length;

                while (temp != 0)
                {
                    var digit = temp % 10;
                    sum += (int)Math.Pow(digit, digits);
                    temp /= 10;
                }

                if (sum == num)
                {
                    armstrongNumbers.Add(num);
                }
            }

            return armstrongNumbers;
        }

        // Exercise 31 - Write a program in C# Sharp to display the pattern like a diamond.
        public static List<string> GenerateDiamondPattern(int halfRows)
        {
            var diamond = new List<string>();

            // Upper part of the diamond
            for (var i = 1; i <= halfRows; i++)
            {
                var spaces = new string(' ', halfRows - i);
                var asterisks = new string('*', 2 * i - 1);
                diamond.Add(spaces + asterisks);
            }

            // Lower part of the diamond (excluding the middle row)
            for (var i = halfRows - 1; i >= 1; i--)
            {
                var spaces = new string(' ', halfRows - i);
                var asterisks = new string('*', 2 * i - 1);
                diamond.Add(spaces + asterisks);
            }

            return diamond;
        }

        // Exercise 32 - Write a C# Sharp program to determine whether a given number is prime or not.
        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
                return false;

            for (var i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        // Exercise 33 - Write a C# Sharp program to display Pascal's triangle.
        public static List<List<int>> GeneratePascalsTriangle(int rows)
        {
            var triangle = new List<List<int>>();

            for (var i = 0; i < rows; i++)
            {
                var row = new List<int>();
                for (var j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        var value = triangle[i - 1][j - 1] + triangle[i - 1][j];
                        row.Add(value);
                    }
                }
                triangle.Add(row);
            }

            return triangle;
        }

        // Exercise 34 - Write a program in C# Sharp to find prime numbers within a range of numbers.
        public static List<int> FindPrimeNumbersInRange(int start, int end)
        {
            var primeNumbers = new List<int>();

            for (var num = start; num <= end; num++)
            {
                if (IsPrime(num))
                {
                    primeNumbers.Add(num);
                }
            }

            return primeNumbers;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (var i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        // Exercise 35 - Write a program in C# Sharp to display the first n terms of Fibonacci series.
        public static List<int> GenerateFibonacciSeries(int n)
        {
            var fibonacciSeries = new List<int>();

            if (n >= 1)
                fibonacciSeries.Add(0);
            if (n >= 2)
                fibonacciSeries.Add(1);

            for (var i = 3; i <= n; i++)
            {
                var nextTerm = fibonacciSeries[i - 2] + fibonacciSeries[i - 3];
                fibonacciSeries.Add(nextTerm);
            }

            return fibonacciSeries;
        }

        // Exercise 36 - Write a program in C# Sharp to display such a pattern for n number of rows using a number starting with the number 1. The first and last number of each row will be 1.
        public static List<string> GenerateNumbersPyramid(int rows)
        {
            var pyramid = new List<string>();

            for (var i = 1; i <= rows; i++)
            {
                var spaces = new string(' ', rows - i);
                var numbers = "";

                // Ascending numbers
                for (var j = 1; j <= i; j++)
                {
                    numbers += j;
                }

                // Descending numbers (excluding the last number to avoid duplication)
                for (var j = i - 1; j >= 1; j--)
                {
                    numbers += j;
                }

                pyramid.Add(spaces + numbers);
            }

            return pyramid;
        }

        // Exercise 37 - Write a program in C# Sharp to display a number in reverse order.
        public static int ReverseNumber(int number)
        {
            var reversed = 0;
            var temp = number;

            while (temp != 0)
            {
                var digit = temp % 10;
                reversed = reversed * 10 + digit;
                temp /= 10;
            }

            return reversed;
        }

        // Exerceise 38 - Write a program in C# Sharp to check whether a number is a palindrome or not.
        public static bool IsPalindrome(int number)
        {
            var original = number;
            var reversed = 0;
            var temp = number;

            while (temp != 0)
            {
                var digit = temp % 10;
                reversed = reversed * 10 + digit;
                temp /= 10;
            }

            return original == reversed;
        }

        // Exercise 39 - Write a C# Sharp program to find the number and sum of all integers between 100 and 200 divisible by 9.
        public static (List<int> Numbers, int Sum) FindNumbersDivisibleBy9(int start, int end)
        {
            var numbers = new List<int>();
            var sum = 0;

            for (var i = start; i <= end; i++)
            {
                if (i % 9 == 0)
                {
                    numbers.Add(i);
                    sum += i;
                }
            }

            return (numbers, sum);
        }

        // Exercise 40 - Write a C# Sharp Program to display the following pattern using the alphabet.
        public static List<string> GenerateAlphabetPyramid(int n)
        {
            var pyramid = new List<string>();

            for (var i = 1; i <= n; i++)
            {
                var row = "";

                // Ascending letters
                for (var j = 0; j < i; j++)
                {
                    row += (char)('A' + j) + " ";
                }

                // Descending letters (excluding the last letter to avoid duplication)
                for (var j = i - 2; j >= 0; j--)
                {
                    row += (char)('A' + j) + " ";
                }

                pyramid.Add(row.Trim());
            }

            return pyramid;
        }

        // Exercise 41 - Write a program in C# Sharp to convert a decimal number into binary without using an array.
        public static long ConvertDecimalToBinary(int decimalNumber)
        {
            long binaryNumber = 0;
            int position = 1;
            var n = decimalNumber;

            while (n > 0)
            {
                var remainder = n % 2;
                binaryNumber += remainder * position;
                position *= 10;
                n /= 2;
            }

            return binaryNumber;
        }

        // Exercise 42 - Write a program in C# Sharp to convert a binary number into a decimal number without using array, function and while loop.
        public static int ConvertBinaryToDecimal(int binaryNumber)
        {
            var decimalNumber = 0;
            var power = 1;
            var temp = binaryNumber;

            for (var i = temp; i > 0; i /= 10)
            {
                var digit = i % 10;
                decimalNumber += digit * power;
                power *= 2;
            }

            return decimalNumber;
        }

        // Exercise 43 - Write a C# Sharp program to find the HCF (Highest Common Factor) of two numbers.
        public static int FindHCF(int num1, int num2)
        {
            var smaller = Math.Min(num1, num2);
            var hcf = 1;

            for (var i = 1; i <= smaller; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    hcf = i;
                }
            }

            return hcf;
        }

        // Exercise 44 - Write a program in C# Sharp to find the LCM of any two numbers using HCF.
        public static int FindLCM(int num1, int num2)
        {
            var hcf = FindHCF1(num1, num2);
            return (num1 * num2) / hcf;
        }

        private static int FindHCF1(int num1, int num2)
        {
            var smaller = Math.Min(num1, num2);
            var hcf = 1;

            for (var i = 1; i <= smaller; i++)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    hcf = i;
                }
            }

            return hcf;
        }

        // Exercise 45 - Write a program in C# Sharp to find the LCM of any two numbers.
        public static int FindLCM1(int num1, int num2)
        {
            var max = Math.Max(num1, num2);

            for (var i = max; ; i += max)
            {
                if (i % num1 == 0 && i % num2 == 0)
                {
                    return i;
                }
            }
        }

        // Exercise 46 - Write a C# Sharp program to convert a binary number into a decimal number using the math function.
        public static int ConvertsBinaryToDecimal(int binaryNumber)
        {
            var decimalNumber = 0;
            var power = 0;
            var temp = binaryNumber;

            while (temp > 0)
            {
                var digit = temp % 10;
                decimalNumber += digit * (int)Math.Pow(2, power);
                temp /= 10;
                power++;
            }

            return decimalNumber;
        }

        // Exercise 47 - Write a C# Sharp program to check whether a number is a Strong Number or not.
        public static bool IsStrongNumber(int number)
        {
            var original = number;
            var sum = 0;

            while (number > 0)
            {
                var digit = number % 10;
                sum += CalculatesFactorial(digit);
                number /= 10;
            }

            return sum == original;
        }

        private static int CalculatesFactorial(int n)
        {
            var factorial = 1;
            for (var i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        // Exercise 48 - Write a C# Sharp program to find Strong Numbers within a range of numbers.
        public static List<int> FindStrongNumbersInRange(int start, int end)
        {
            var strongNumbers = new List<int>();

            for (var number = start; number <= end; number++)
            {
                if (IsStrongNumbers(number))
                {
                    strongNumbers.Add(number);
                }
            }

            return strongNumbers;
        }

        private static bool IsStrongNumbers(int number)
        {
            var original = number;
            var sum = 0;

            while (number > 0)
            {
                var digit = number % 10;
                sum += CalculateFactorial1(digit);
                number /= 10;
            }

            return sum == original;
        }

        private static int CalculateFactorial1(int n)
        {
            var factorial = 1;
            for (var i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        // Exercise 49 - Write a C# Sharp program to find out the sum of the Arithmetic Progress series.
        public static (List<int> Series, int Sum) CalculateArithmeticProgression(int start, int count, int difference)
        {
            var series = new List<int>();
            var sum = 0;
            var current = start;

            for (var i = 0; i < count; i++)
            {
                series.Add(current);
                sum += current;
                current += difference;
            }

            return (series, sum);
        }

        // Exercise 50 - Write a program in C# Sharp to convert a decimal number into octal without using an array.
        public static long ConvertDecimalToOctal(int decimalNumber)
        {
            long octalNumber = 0;
            int position = 1;
            var n = decimalNumber;

            while (n > 0)
            {
                var remainder = n % 8;
                octalNumber += remainder * position;
                position *= 10;
                n /= 8;
            }

            return octalNumber;
        }

        // Exercise 51 - Write a program in C# Sharp to convert an octal number to decimal without using an array.
        public static string ConvertOctalToDecimal(string octalNumber)
        {
            if (string.IsNullOrEmpty(octalNumber))
                return "Invalid input";

            int dec = 0;
            int power = 1;

            for (int i = octalNumber.Length - 1; i >= 0; i--)
            {
                char digitChar = octalNumber[i];

                if (digitChar < '0' || digitChar > '7')
                    return "Invalid octal number";

                int digit = digitChar - '0';
                dec += digit * power;
                power *= 8;
            }

            return $"The Octal Number : {octalNumber}\nThe equivalent Decimal Number : {dec}";
        }

        // Exercise 52 - Write a C# Sharp program to find the sum of the Geometric Progress series.
        public static string CalculateGPSeries(int firstTerm, int numberOfTerms, int commonRatio)
        {
            var series = "";
            double sum = 0;
            double currentTerm = firstTerm;

            for (int i = 0; i < numberOfTerms; i++)
            {
                series += $"{currentTerm} ";
                sum += currentTerm;
                currentTerm *= commonRatio;
            }

            double lastTerm = firstTerm * Math.Pow(commonRatio, numberOfTerms - 1);

            return string.Format(CultureInfo.InvariantCulture,
             "The numbers for the G.P. series:\n{0}\nThe tn terms of G.P. : {1:F6}\nThe Sum of the G.P. series : {2:F6}",
             series.Trim(), lastTerm, sum);
        }

        // Exercise 53 - Write a program in C# Sharp to convert a binary number to octal.
        public static string ConvertBinaryToOctal(string binaryNumber)
        {
            if (string.IsNullOrEmpty(binaryNumber))
                return "Invalid input";

            foreach (char c in binaryNumber)
            {
                if (c != '0' && c != '1')
                    return "Invalid binary number";
            }

            int dec = 0;
            int power = 1;

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if (binaryNumber[i] == '1')
                    dec += power;
                power *= 2;
            }

            int ocno = 0;
            int i2 = 1;

            for (int j = dec; j > 0; j = j / 8)
            {
                ocno = ocno + (j % 8) * i2;
                i2 = i2 * 10;
            }

            return string.Format(CultureInfo.InvariantCulture,
                "The Binary Number : {0}\nThe equivalent Octal Number : {1}",
                binaryNumber, ocno);
        }

        // Exercise 54 -  Write a program in C# Sharp to convert an octal number into binary.
        public static string ConvertOctalToBinary(string octalNumber)
        {
            if (string.IsNullOrEmpty(octalNumber))
                return "Invalid input";

            foreach (char c in octalNumber)
            {
                if (c < '0' || c > '7')
                    return "Invalid octal number";
            }

            int dec = 0;
            int power = 1;

            for (int i = octalNumber.Length - 1; i >= 0; i--)
            {
                int digit = octalNumber[i] - '0';
                dec += digit * power;
                power *= 8;
            }

            string binary = "";

            for (int j = dec; j > 0; j = j / 2)
            {
                binary = (j % 2) + binary;
            }

            if (binary == "") binary = "0";

            return string.Format(CultureInfo.InvariantCulture,
                "The Octal Number : {0}\nThe equivalent Binary Number : {1}",
                octalNumber, binary);
        }

        // Exercise 55 - Write a program in C# Sharp to convert a decimal number to hexadecimal.
        public static string ConvertDecimalToHexadecimal(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "The equivalent Hexadecimal Number : 0";

            string hex = "";
            int temp = decimalNumber;

            while (temp > 0)
            {
                int remainder = temp % 16;

                if (remainder < 10)
                    hex = remainder + hex;
                else
                    hex = (char)(remainder + 55) + hex;

                temp /= 16;
            }

            return string.Format(CultureInfo.InvariantCulture,
                "The equivalent Hexadecimal Number : {0}", hex);
        }

        // Exercise 56 - Write a program in C# Sharp to check whether a number can be expressed as the sum of two prime numbers.
        public static string CheckSumOfTwoPrimes(int number)
        {
            if (number < 4)
                return $"{number} can not be expressed as the sum of two prime numbers.";

            string result = "";
            bool found = false;

            for (int i = 2; i <= number / 2; i++)
            {
                if (IsPrimeNumber(i) && IsPrimeNumber(number - i))
                {
                    result += $"{number} = {i} + {number - i}\n";
                    found = true;
                }
            }

            if (!found)
                return $"{number} can not be expressed as the sum of two prime numbers.";

            return result.Trim();
        }

        private static bool IsPrime1(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Exercise 57 - Write a program in C# Sharp to print a string in reverse order.
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "Reversed string is: ";

            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            return string.Format(CultureInfo.InvariantCulture,
                "Reversed string is: {0}", reversed);
        }

        // Exercise 58 - Write a C# Sharp program to display an alphabet pattern like A with an asterisk.
        public static string DisplayPatternA()
        {
            string pattern = "";

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    if (((column == 1 || column == 5) && row != 0) ||
                        ((row == 0 || row == 3) && (column > 1 && column < 5)))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 59 - Write a C# Sharp program to display an alphabet pattern like B with an asterisk.
        public static string DisplayPatternB()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 5 ||
                       ((row == 0 || row == 3 || row == 6) && (column > 1 && column < 5)) ||
                       (column == 1 && (row != 0 && row != 3 && row != 6)))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 60 - Write a C# Sharp program to display an alphabet pattern like C with an asterisk.
        public static string DisplayPatternC()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if ((column == 1 && (row > 0 && row < 6)) ||
                        ((row == 0 || row == 6) && (column > 1 && column < 5)) ||
                        (column == 5 && (row == 1 || row == 5)))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 61 - Write a C# Sharp program to display an alphabet pattern like D with an asterisk.
        public static string DisplayPatternD()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 1 ||
                        ((row == 0 || row == 6) && (column > 1 && column < 5)) ||
                        (column == 5 && (row != 0 && row != 6)))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 62 - Write a C# Sharp program to display an alphabet pattern like E with an asterisk.
        public static string DisplayPatternE()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 1 ||
                        ((row == 0 || row == 6) && (column > 1 && column < 6)) ||
                        (row == 3 && column > 1 && column < 5))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 63 - Write a C# Sharp program to display an alphabet pattern like F with an asterisk.
        public static string DisplayPatternF()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 1 ||
                        (row == 0 && column > 1 && column < 6) ||
                        (row == 3 && column > 1 && column < 5))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 64 - Write a C# Sharp program to display an alphabet pattern like G with an asterisk.
        public static string DisplayPatternG()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if ((column == 1 && row != 0 && row != 6) ||
                        ((row == 0 || row == 6) && column > 1 && column < 5) ||
                        (row == 3 && column > 2 && column < 6) ||
                        (column == 5 && row != 0 && row != 2 && row != 6))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 65 - Write a C# Sharp program to display an alphabet pattern like H with an asterisk.
        public static string DisplayPatternH()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if ((column == 1 || column == 5) || (row == 3 && column > 1 && column < 6))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 66 - Write a C# Sharp program to display an alphabet pattern like I with an asterisk.
        public static string DisplayPatternI()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 67 - Write a C# Sharp program to display an alphabet pattern like J with an asterisk.
        public static string DisplayPatternJ()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if ((column == 4 && row != 6) || (row == 0 && column > 2 && column < 6) || (row == 6 && column == 3) || (row == 5 && column == 2))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 68 - Write a C# Sharp program to display an alphabet pattern like K with an asterisk.
        public static string DisplayPatternK()
        {
            string pattern = "";
            int j = 5, i = 0;

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == column + 1) && column != 0))
                    {
                        pattern += "*";
                    }
                    else if (row == i && column == j)
                    {
                        pattern += "*";
                        i = i + 1;
                        j = j - 1;
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 69 - Write a C# Sharp program to display an alphabet pattern like L with an asterisk.
        public static string DisplayPatternL()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 1 || (row == 6 && column != 0 && column < 6))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 70 - Write a C# Sharp program to display an alphabet pattern like M with an asterisk.
        public static string DisplayPatternM()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 ||
                        (row == 2 && (column == 2 || column == 4)) ||
                        (row == 3 && column == 3))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 71 - Write a C# Sharp program to display an alphabet pattern like N with an asterisk.
        public static string DisplayPatternN()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 72 - Write a C# Sharp program to display an alphabet pattern like O with an asterisk.
        public static string DisplayPatternO()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 73 - Write a C# Sharp program to display an alphabet pattern like P with an asterisk.
        public static string DisplayPatternP()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3) && column > 0 && column < 5) || ((column == 5 || column == 1) && (row == 1 || row == 2)))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 74 - Write a C# Sharp program to display an alphabet pattern like Q with an asterisk.
        public static string DisplayPatternQ()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if ((column == 1 && row != 0 && row != 6) ||
                        (row == 0 && column > 1 && column < 5) ||
                        (column == 5 && row != 0 && row != 5) ||
                        (row == 6 && column > 1 && column < 4) ||
                        (column == row - 1 && row > 3))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 75 - Write a C# Sharp program to display an alphabet pattern like R with an asterisk.
        public static string DisplayPatternR()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if ((column == 1) ||
                        ((row == 0 || row == 3) && column > 1 && column < 5) ||
                        (column == 5 && row != 0 && row < 3) ||
                        (column == row - 1 && row > 2))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 76 - Write a C# Sharp program to display an alphabet pattern like S with an asterisk.
        public static string DisplayPatternS()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) ||
                        (column == 1 && (row == 1 || row == 2 || row == 6)) ||
                        (column == 5 && (row == 0 || row == 4 || row == 5)))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 77 - Write a C# Sharp program to display an alphabet pattern like T with an asterisk.
        public static string DisplayPatternT()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 78 - Write a C# Sharp program to display an alphabet pattern like U with an asterisk.
        public static string DisplayPatternU()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row != 6) || (row == 6 && column > 1 && column < 5))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 79 - Write a C# Sharp program to display an alphabet pattern like V with an asterisk.
        public static string DisplayPatternV()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 5) || (row == 6 && column == 3) || (row == 5 && (column == 2 || column == 4)))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }


        // Exercise 80 - Write a C# Sharp program to display an alphabet pattern like W with an asterisk.
        public static string DisplayPatternW()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 6) || ((row == 5 || row == 4) && column == 3) || (row == 6 && (column == 2 || column == 4)))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 81 - Write a C# Sharp program to display an alphabet pattern like X with an asterisk.
        public static string DisplayPatternX()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && (row > 4 || row < 2)) || row == column && column > 0 && column < 6 || (column == 2 && row == 4) || (column == 4 && row == 2))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 82 - Write a C# Sharp program to display an alphabet pattern like Y with an asterisk.
        public static string DisplayPatternY()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (((column == 1 || column == 5) && row < 2) || row == column && column > 0 && column < 4 || (column == 4 && row == 2) || ((column == 3) && row > 3))
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }

        // Exercise 83 - Write a C# Sharp program to display an alphabet pattern like Z with an asterisk.
        public static string DisplayPatternZ()
        {
            string pattern = "";

            for (int row = 0; row <= 6; row++)
            {
                for (int column = 0; column <= 6; column++)
                {
                    if (((row == 0 || row == 6) && column >= 0 && column <= 6) || row + column == 6)
                    {
                        pattern += "*";
                    }
                    else
                    {
                        pattern += " ";
                    }
                }
                pattern += "\n";
            }

            return pattern;
        }
    }
}
