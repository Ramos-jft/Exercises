using System.Data;
using System.Text;

namespace Exercises
{
    public class Basic
    {
        // Exercise 1 - Print Hello and Name
        public static string Message(string name)
        {
            return $"Hello\n{name}";
        }

        // Exercise 2 - Sum of Two Numbers
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        // Exercise 3 - Divide Two Numbers
        public static int Divide(int n1, int n2)
        {
            return n1 / n2;
        }

        // Exercise04 4 -  Specified Operations Results
        public static double Calculate(string operation)
        {
            operation = operation.Replace(" ", "");

            using (DataTable dt = new DataTable())
            {
                var result = dt.Compute(operation, null);
                double resultDouble = Convert.ToDouble(result);
                return Math.Round(resultDouble, 2);
            }
        }

        // Exercise 5 - Swap Two Numbers
        public static void Swap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        // Exercise 6 - Multiply Three Numbers
        public static int MultiplyThreeNumbers(int n1, int n2, int n3)
        {
            return n1 * n2 * n3;
        }

        // Exercise 7 - Arithmetic Operations
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

        // Exercise 8 - Multiplication Table
        public static string GenerateMultiplicationTable(int number)
        {
            string table = "";
            for (int i = 0; i <= 10; i++)
            {
                table += $"{number} * {i} = {number * i}";
                if (i < 10)
                {
                    table += "\r\n";
                }
            }
            return table;
        }

        // Exercise 9 - Average of Four Numbers
        public static double CalculateAverage(int num1, int num2, int num3, int num4)
        {
            return (num1 + num2 + num3 + num4) / 4.0;
        }

        //Exercise 10 - Specified Formula with Three Numbers
        public static int CalculateFirstFormula(int x, int y, int z)
        {
            return (x + y) * z;
        }

        public static int CalculateSecondFormula(int x, int y, int z)
        {
            return x * y + y * z;
        }

        public static string GetFormulasOutput(int x, int y, int z)
        {
            return $"Result of specified formulas:\r\n" +
                   $"(x + y).z = {CalculateFirstFormula(x, y, z)}\r\n" +
                   $"x.y + y.z = {CalculateSecondFormula(x, y, z)}";
        }

        // Exercise 11 - Print Age Message
        public static string GetAgeMessage(int age)
        {
            return $"You look older than {age}";
        }

        // Exercise 12 - Repeat Number in Rows
        public static string GetNumberPattern(int number)
        {
            string spaced = string.Format("{0} {0} {0} {0}", number);
            string unspaced = string.Format("{0}{0}{0}{0}", number);

            return $"{spaced}\r\n{unspaced}\r\n{spaced}\r\n{unspaced}";
        }

        // Exercise 13 - Rectangle Pattern with Number
        public static string GetRectanglePattern(int number)
        {
            string solidLine = new string(char.Parse(number.ToString()), 3);
            string hollowLine = $"{number} {number}";

            return $"{solidLine}\r\n{hollowLine}\r\n{hollowLine}\r\n{hollowLine}\r\n{solidLine}";
        }

        // Exercise 14 - Celsius to Kelvin and Fahrenheit
        public static double ConvertToKelvin(double celsius)
        {
            return celsius + 273;
        }

        public static double ConvertToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public static string GetTemperatureConversions(double celsius)
        {
            return $"Kelvin = {ConvertToKelvin(celsius)}\r\nFahrenheit = {ConvertToFahrenheit(celsius)}";
        }

        // Exercise 15 - Remove Character by Index
        public static string RemoveCharacterAtIndex(string input, int index)
        {
            return input.Remove(index, 1);
        }

        // Exercise 16 - Swap First and Last Characters
        public static string SwapFirstLastCharacters(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
                return input;

            char first = input[0];
            char last = input[input.Length - 1];

            return last + input.Substring(1, input.Length - 2) + first;
        }

        // Exercise 17 - Add First Character to Front and Back
        public static string AddFirstCharFrontAndBack(string input)
        {
            char firstChar = input[0];
            return firstChar + input + firstChar;
        }

        // Exercise 18 - Check Positive and Negative Pair
        public static bool CheckPositiveNegativePair(int first, int second)
        {
            return (first < 0 && second > 0) || (first > 0 && second < 0);
        }

        // Exercise 19 - Sum or Triple Sum of Integers
        public static int ComputeSum(int a, int b)
        {
            int result;
            return result = a == b ? (a + b) * 3 : a + b;
        }

        // Exercise 20 - Absolute Difference or Double It
        public static int CalculateDifference(int a, int b)
        {
            int difference = a - b;
            return a > b ? Math.Abs(difference) * 2 : Math.Abs(difference);
        }

        // Exercise 21 - Check for 20 or Sum Equals 20
        public static bool CheckFor20(int a, int b)
        {
            return a == 20 || b == 20 || (a + b) == 20;
        }

        // Exercise 22 - Check Within 20 of 100 or 200
        public static bool CheckWithin20(int number)
        {
            return (Math.Abs(number - 100) <= 20) ||
                   (Math.Abs(number - 200) <= 20);
        }

        public static string GetCheckResult(int number)
        {
            bool result = CheckWithin20(number);
            return $"Check result: {result}";
        }

        // Exercise01 23 - Convert String to Lowercase
        public static string ConvertToLower(string input)
        {
            return input.ToLower();
        }

        public static string GetLowercaseResult(string input)
        {
            string result = ConvertToLower(input);
            return $"Lowercase result: {result}";
        }

        // Exercise 24 - Find Longest Word in String
        public static string FindLongestWord(string input)
        {
            // Split into words, removing punctuation
            var words = input.Split(' ')
                           .Select(w => new string(w.Where(c => char.IsLetter(c)).ToArray()));

            return words.OrderByDescending(w => w.Length).First();
        }

        // Exercise 25 - Print Odd Numbers 1 to 99
        public static string GetOddNumbers()
        {
            StringBuilder sb = new StringBuilder();
            // Adiciona os primeiros 5 números
            for (int i = 1; i <= 9; i += 2)
            {
                sb.AppendLine(i.ToString());
            }
            // Adiciona "..."
            sb.AppendLine("...");
            // Adiciona os últimos 3 números
            for (int i = 95; i <= 99; i += 2)
            {
                sb.AppendLine(i.ToString());
            }
            return sb.ToString();
        }

        public static void PrintOddNumbers()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            Console.Write(GetOddNumbers());
        }

        // Exercise 26 - Sum of First 500 Primes
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Sqrt(number);

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static long SumOfFirst500Primes()
        {
            int count = 0;
            int number = 2;
            long sum = 0;

            while (count < 500)
            {
                if (IsPrime(number))
                {
                    sum += number;
                    count++;
                }
                number++;
            }

            return sum;
        }

        public static string GetPrimeSumResult()
        {
            long sum = SumOfFirst500Primes();
            return $"Sum of the first 500 prime numbers:\n{sum}";
        }

        // Exercise 27 - Sum of Digits in Integer
        public static int SumDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            if (number == 0)
            {
                return 0;
            }

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        // Exercise 28 - Reverse Words in Sentence
        public static string ReverseWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return sentence;

            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public static string GetReversedSentenceResult(string sentence)
        {
            string reversed = ReverseWords(sentence);
            return $"Original String: {sentence}\nReverse String: {reversed}";
        }

        // Exercise 29 - File Size in Bytes
        public static long GetFileSize(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found: {filePath}");

            return new FileInfo(filePath).Length;
        }

        public static string GetFileSizeResult(string filePath)
        {
            try
            {
                long size = GetFileSize(filePath);
                return $"Size of a file: {size}";
            }
            catch (FileNotFoundException ex)
            {
                return ex.Message;
            }
        }

        // Exercise 30 - Hexadecimal to Decimal
        public static int HexToDecimal(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }

        public static string GetConversionResult(string hex)
        {
            int decimalNumber = HexToDecimal(hex);
            return $"Hexadecimal number: {hex}\nConvert to-\nDecimal number: {decimalNumber}";
        }

        // Exercise 31 - Multiply Two Arrays
        public static int[] MultiplyArrays(int[] array1, int[] array2)
        {
            return array1.Zip(array2, (a, b) => a * b).ToArray();
        }

        public static string GetMultiplicationResult(int[] array1, int[] array2)
        {
            int[] result = MultiplyArrays(array1, array2);
            return $"Array1: [{string.Join(", ", array1)}]\n" +
                   $"Array2: [{string.Join(", ", array2)}]\n" +
                   "Multiply corresponding elements of two arrays:\n" +
                   string.Join(" ", result);
        }

        // Exercise 32 - Four Copies of Last Four Characters
        public static string GetLastFourCopies(string input)
        {
            string lastFour = input.Substring(input.Length - 4);
            return string.Concat(lastFour, lastFour, lastFour, lastFour);
        }

        // Exercise 33 - Check Multiple of 3 or 7
        public static bool IsMultipleOf3Or7(int number)
        {
            if (number <= 0)
                return false;

            return number % 3 == 0 || number % 7 == 0;
        }

        public static string GetCheckResult0(int number)
        {
            bool result = IsMultipleOf3Or7(number);
            return $"Input first integer:\n{number}\n{result}";
        }

        // Exercise 34 - Check String Starts with Word
        public static bool StartsWithHello(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            return input.TrimStart().StartsWith("Hello", StringComparison.OrdinalIgnoreCase);
        }

        public static string GetCheckResult(string input)
        {
            bool result = StartsWithHello(input);
            return $"Input a string : {input}\n{result}";
        }

        // Exercise 35 - Check Numbers Less than 100 & Greater than 200
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

        // Exercise 36 - Check Integer in Range -10 to 10
        public static bool CheckInRange(int num1, int num2)
        {
            return (num1 >= -10 && num1 <= 10) || (num2 >= -10 && num2 <= 10);
        }

        public static string GetCheckResult1(int num1, int num2)
        {
            bool result = CheckInRange(num1, num2);
            return $"Input a first number: {num1}\n" +
                   $"Input a second number: {num2}\n" +
                   $"{result}";
        }

        // Exercise 37 - Remove 'HP' from String
        public static string RemoveHP(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 3)
                return input;

            if (input.Substring(1, 2).Equals("HP", StringComparison.OrdinalIgnoreCase))
            {
                return input.Remove(1, 2);
            }
            return input;
        }

        public static string GetModifiedString(string input)
        {
            string result = RemoveHP(input);
            return $"Original String: {input}\nModified String: {result}";
        }

        // Exercise 38 - Extract 'PH' from String
        public static string ExtractPH(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
                return string.Empty;

            if (input[0] == 'P' && input[1] == 'H')
                return "PH";

            return string.Empty;
        }

        public static string GetExtractionResult(string input)
        {
            string result = ExtractPH(input);
            return $"Test Data: {input}\nExtracted: {result}";
        }

        // Exercise 39 - Largest and Lowest of Three Integers
        public static (int largest, int lowest) FindLargestAndLowest(int num1, int num2, int num3)
        {
            int largest = Math.Max(Math.Max(num1, num2), num3);
            int lowest = Math.Min(Math.Min(num1, num2), num3);

            return (largest, lowest);
        }

        public static string GetComparisonResult(int num1, int num2, int num3)
        {
            var (largest, lowest) = FindLargestAndLowest(num1, num2, num3);
            return $"Largest of three: {largest}\nLowest of three: {lowest}";
        }

        // Exercise 40 - Nearest to 20 or Return 0
        public static int FindNearestTo20(int num1, int num2)
        {

            if (num1 == num2)
            {
                return 0;
            }

            int diff1 = Math.Abs(num1 - 20);
            int diff2 = Math.Abs(num2 - 20);

            if (diff1 == diff2)
            {
                return 0;
            }

            return diff1 < diff2 ? num1 : num2;
        }

        public static string GetNearestResult(int num1, int num2)
        {
            int result = FindNearestTo20(num1, num2);
            return $"Input first integer:\n{num1}\n" +
                   $"Input second integer:\n{num2}\n" +
                   $"Nearest to 20: {result}";
        }

        // Exercise 41 - Check 'w' Appears 1-3 Times
        public static bool CheckWCount(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            int wCount = input.Count(c => c == 'w' || c == 'W');
            return wCount >= 1 && wCount <= 3;
        }

        public static string GetCheckResult2(string input)
        {
            bool result = CheckWCount(input);
            return $"Input a string (contains at least one 'w' char) : {input}\n" +
                   "Test the string contains 'w' character between 1 and 3 times:\n" +
                   $"{result}";
        }

        // Exercise 42 - First 4 Chars Lowercase, Rest Uppercase
        public static string TransformString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            if (input.Length < 4)
                return input.ToUpper();

            string firstFour = input.Substring(0, 4).ToLower();
            string rest = input.Length > 4 ? input.Substring(4).ToUpper() : "";

            return firstFour + rest;
        }

        public static string GetTransformedResult(string input)
        {
            string result = TransformString(input);
            return $"Input a string: {input}\n{result}";
        }

        // Exercise 43 - Check String Starts with 'www'
        public static bool CheckWWWStart(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 3)
                return false;

            return input.StartsWith("w") &&
                   input.Substring(1, 2) == "ww";
        }

        public static string GetCheckResult3(string input)
        {
            bool result = CheckWWWStart(input);
            return $"Input a string : {input}\n{result}";
        }

        // Exercise 44 - Every Other Character in String
        public static string GetEveryOtherCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i += 2)
            {
                result.Append(input[i]);
            }
            return result.ToString();
        }

        public static string GetResultString(string input)
        {
            string result = GetEveryOtherCharacter(input);
            return $"Input a string : {input}\n{result}";
        }

        // Exercise 45 - Count Specific Number in Array
        public static int CountNumberInArray(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            return numbers.Count(n => n == target);
        }

        public static string GetCountResult(int[] numbers, int target)
        {
            int count = CountNumberInArray(numbers, target);
            return $"Number of {target} present in the said array: {count}";
        }

        // Exercise 46 - Check Number First or Last in Array
        public static bool CheckFirstOrLast(int[] array, int number)
        {
            return array[0] == number || array[array.Length - 1] == number;
        }

        public static string GetCheckResult(int[] array, int number)
        {
            bool result = CheckFirstOrLast(array, number);
            return $"Input an integer: {number}\n{result}";
        }

        // Exercise 47 - Sum of Array Elements
        public static int CalculateSum(int[] numbers)
        {
            return numbers.Sum();
        }

        public static string GetSumResult(int[] numbers)
        {
            int sum = CalculateSum(numbers);
            return $"Array1: [{string.Join(", ", numbers)}]\nSum: {sum}";
        }

        // Exercise 48 - First and Last Element Equal in Array
        public static bool CheckFirstLastEqual(int[] array)
        {
            return array[0] == array[array.Length - 1];
        }

        public static string GetCheckResult(int[] array)
        {
            bool result = CheckFirstLastEqual(array);
            return $"Array1: [{string.Join(", ", array)}]\n{result}";
        }

        // Exercise01 49 - First or Last Element Equal in Two Arrays
        public static bool CheckFirstOrLastEqual(int[] array1, int[] array2)
        {
            return array1[0] == array2[0] || array1[array1.Length - 1] == array2[array2.Length - 1];
        }

        public static string GetCheckResult(int[] array1, int[] array2)
        {
            bool result = CheckFirstOrLastEqual(array1, array2);
            return $"Array1: [{string.Join(", ", array1)}]\n" +
                   $"Array2: [{string.Join(", ", array2)}]\n" +
                   $"Check if the first element or the last element of the two arrays are equal:\n" +
                   $"{result}";
        }

        // Exercise 50 - Rotate Array Left
        public static int[] RotateLeft(int[] array)
        {
            return new int[] { array[1], array[2], array[0] };
        }

        public static string GetRotatedResult(int[] array)
        {
            int[] rotated = RotateLeft(array);
            return $"Array1: [{string.Join(", ", array)}]\n" +
                   $"After rotating array becomes: [{string.Join(", ", rotated)}]";
        }

        // Exercise 51 - Max of First and Last in Array
        public static int GetMaxOfFirstAndLast(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }

            int first = array[0];
            int last = array[array.Length - 1];

            return Math.Max(first, last);
        }

        // Exercise 52 - Middle Elements of Three Arrays
        public int[] GetMiddleElements(int[] array1, int[] array2, int[] array3)
        {
            if (array1 == null || array2 == null || array3 == null)
            {
                throw new ArgumentException("Arrays cannot be null");
            }

            if (array1.Length != 3 || array2.Length != 3 || array3.Length != 3)
            {
                throw new ArgumentException("All arrays must have length 3");
            }

            int middle1 = array1[1];
            int middle2 = array2[1];
            int middle3 = array3[1];

            return new int[] { middle1, middle2, middle3 };
        }

        // Exercise 53 - Check Odd Number in Array
        public bool ContainsOddNumber(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return false;
            }

            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        // Exercise 54 - Find Century of Year
        public int GetCentury(int year)
        {
            if (year <= 0)
            {
                throw new ArgumentException("Year must be greater than 0");
            }

            int century = (year - 1) / 100 + 1;

            return century;
        }

        // Exercise 55 - Max Product of Adjacent Elements
        public int MaxAdjacentProduct(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array cannot be null");
            }

            if (array.Length < 2)
            {
                throw new ArgumentException("Array must have at least 2 elements");
            }

            int maxProduct = int.MinValue;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int product = array[i] * array[i + 1];

                if (product > maxProduct)
                {
                    maxProduct = product;
                }
            }

            return maxProduct;
        }

        // Exercise 56 - Check Palindrome String
        public bool IsPalindrome(string input)
        {
            if (input == null)
            {
                return false;
            }

            if (input.Length <= 1)
            {
                return true;
            }

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }

        // Exercise 57 - Max Product of Adjacent Integers
        public static int ArrayAdjacentElementsProduct(int[] inputArray)
        {
            int arrayIndex = 0;

            int product = inputArray[arrayIndex] * inputArray[arrayIndex + 1];

            arrayIndex++;

            while (arrayIndex + 1 < inputArray.Length)
            {
                product = ((inputArray[arrayIndex] * inputArray[arrayIndex + 1]) > product) ?
                            (inputArray[arrayIndex] * inputArray[arrayIndex + 1]) :
                            product;

                arrayIndex++;
            }

            return product;
        }

        // Exercise 58 - Complete Missing Numbers in Range
        public static int CountMissingNumbersInRange(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            if (numbers.Length == 1)
                return 0;

            int min = numbers.Min();
            int max = numbers.Max();

            HashSet<int> existingNumbers = new HashSet<int>(numbers);
            int missingCount = 0;

            for (int i = min + 1; i < max; i++)
            {
                if (!existingNumbers.Contains(i))
                {
                    missingCount++;
                }
            }

            return missingCount;
        }

        public static List<int> GetMissingNumbersInRange(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return new List<int>();

            if (numbers.Length == 1)
                return new List<int>();

            int min = numbers.Min();
            int max = numbers.Max();

            HashSet<int> existingNumbers = new HashSet<int>(numbers);
            List<int> missingNumbers = new List<int>();

            for (int i = min + 1; i < max; i++)
            {
                if (!existingNumbers.Contains(i))
                {
                    missingNumbers.Add(i);
                }
            }

            return missingNumbers;
        }

        public static string GetMissingNumbersResult(int[] numbers)
        {

            int missingCount = CountMissingNumbersInRange(numbers);
            List<int> missingNumbers = GetMissingNumbersInRange(numbers);

            return $"Input: [{string.Join(", ", numbers)}]\n" +
                   $"Range: {numbers.Min()} to {numbers.Max()}\n" +
                   $"Missing numbers: [{string.Join(", ", missingNumbers)}]\n" +
                   $"Count of missing numbers: {missingCount}";
        }

        // Exercise 59 - Check Strictly Increasing Sequence
        public static bool CanBecomeStrictlyIncreasing(int[] sequence)
        {
            if (sequence == null || sequence.Length <= 1)
                return true;

            int removalsNeeded = 0;
            int last = sequence[0];
            int prev = int.MinValue;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] <= last)
                {
                    removalsNeeded++;

                    if (removalsNeeded > 1)
                        return false;

                    if (sequence[i] > prev)
                    {
                        last = sequence[i];
                    }
                }
                else
                {
                    prev = last;
                    last = sequence[i];
                }
            }

            return true;
        }

        public static string GetStrictlyIncreasingResult(int[] sequence)
        {
            bool result = CanBecomeStrictlyIncreasing(sequence);

            return $"Sequence: [{string.Join(", ", sequence)}]\n" +
                   $"Can become strictly increasing: {result}";
        }

        // Exercise 60 - Sum of Matrix with Zero Condition
        public static int SumMatrixWithZeroCondition(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return 0;

            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int sum = 0;

            // Track which columns have zeros above
            bool[] columnHasZeroAbove = new bool[cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        columnHasZeroAbove[j] = true;
                    }
                    else if (!columnHasZeroAbove[j])
                    {
                        sum += matrix[i][j];
                    }
                }
            }

            return sum;
        }

        public static string GetMatrixSumResult(int[][] matrix)
        {
            int sum = SumMatrixWithZeroCondition(matrix);
            string matrixStr = MatrixToString(matrix);

            return $"Matrix:\n{matrixStr}\nSum: {sum}";
        }

        private static string MatrixToString(int[][] matrix)
        {
            if (matrix == null) return "null";

            return string.Join("\n", matrix
                .Select(row => $"[{string.Join(", ", row)}]"));
        }

        // Exercise 61 - Sort Integers Keeping -5 Fixed
        public static int[] SortKeepingMinusFiveFixedEfficient(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return numbers;

            // Extract and sort non-minus-five numbers
            var nonMinusFive = numbers.Where(x => x != -5).OrderBy(x => x).ToArray();

            int nonMinusFiveIndex = 0;
            int[] result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == -5)
                {
                    result[i] = -5;
                }
                else
                {
                    result[i] = nonMinusFive[nonMinusFiveIndex++];
                }
            }

            return result;
        }

        public static string GetSortedArrayResult(int[] numbers)
        {
            int[] sorted = SortKeepingMinusFiveFixedEfficient(numbers);

            return $"Original: [{string.Join(", ", numbers)}]\n" +
                   $"Sorted:   [{string.Join(", ", sorted)}]";
        }

        // Exercises 62 - Reverse Strings in Parentheses
        public static string ReverseStringsInParentheses(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            int lastOpenParen = input.LastIndexOf('(');
            if (lastOpenParen == -1)
                return input;

            int matchingCloseParen = input.IndexOf(')', lastOpenParen);
            if (matchingCloseParen == -1)
                return input;

            string before = input.Substring(0, lastOpenParen);
            string inside = input.Substring(lastOpenParen + 1, matchingCloseParen - lastOpenParen - 1);
            string after = input.Substring(matchingCloseParen + 1);

            // Reverse the inside part and recursively process any nested parentheses
            char[] insideArray = inside.ToCharArray();
            Array.Reverse(insideArray);
            string reversedInside = new string(insideArray);

            return ReverseStringsInParentheses(before + reversedInside + after);
        }

        public static string GetReversedParenthesesResult(string input)
        {
            string result = ReverseStringsInParentheses(input);

            return $"Input: {input}\n" +
                   $"Output: {result}";
        }

        // Exercise 63 - Check Number in Array
        public static bool CheckNumberInArray(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return false;

            return numbers.Contains(target);
        }
        public static bool CheckNumberInArrayBinarySearch(int[] numbers, int target)
        {
            if (numbers == null || numbers.Length == 0)
                return false;

            Array.Sort(numbers); // Ensure array is sorted for binary search
            return Array.BinarySearch(numbers, target) >= 0;
        }

        public static string GetNumberCheckResult(int[] numbers, int target)
        {
            bool result = CheckNumberInArray(numbers, target);

            return $"Array: [{string.Join(", ", numbers)}]\n" +
                   $"Target: {target}\n" +
                   $"Present: {result}";
        }

        // Exercise 64 - Get File Name from Path
        public static string GetFileNameFromPath(string path)
        {
            if (string.IsNullOrEmpty(path))
                return path;

            return Path.GetFileName(path);
        }
        public static string GetFileNameResult(string path)
        {
            string fileName = GetFileNameFromPath(path);

            return $"Path: {path}\n" +
                   $"File Name: {fileName}";
        }

        // Exercise 65 - Multiply Array Elements by Length
        public static int[] MultiplyArrayElementsByLength(int[] numbers)
        {
            if (numbers == null)
                return null;

            int length = numbers.Length;
            return numbers.Select(x => x * length).ToArray();
        }

        // Exercise 66 - Min Value from Two String Numbers
        public static int MinValueFromStrings(string num1, string num2)
        {
            int number1 = int.Parse(num1);
            int number2 = int.Parse(num2);

            return Math.Min(number1, number2);
        }

        // Exercises 67 -  Coded String Conversion
        public static string ConvertToCodedString(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                switch (c)
                {
                    case 'P': result.Append('9'); break;
                    case 'T': result.Append('0'); break;
                    case 'S': result.Append('1'); break;
                    case 'H': result.Append('6'); break;
                    case 'A': result.Append('8'); break;
                    default: result.Append(c); break;
                }
            }

            return result.ToString();
        }

        // Exercise 68 - Count Specific Character in String
        public static int CountCharacter(string input, char character)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            return input.Count(c => char.ToLower(c) == char.ToLower(character));
        }

        // Exercise 69 - Check All Uppercase or Lowercase
        public static bool IsAllUpperOrLowerCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return input.All(char.IsUpper) || input.All(char.IsLower);
        }

        // Exercises 70 - Remove First and Last Characters
        public static string RemoveFirstAndLast(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length <= 2)
                return "";

            return input.Substring(1, input.Length - 2);
        }

        // Exercise 71 - Check Consecutive Similar Letters
        public static bool HasConsecutiveSimilarLetters(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
                return false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                    return true;
            }

            return false;
        }

        // Exercises 72 - Check Array Average as Whole Number
        public static bool IsAverageWholeNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;

            double average = numbers.Average();
            return average % 1 == 0;
        }

        // Exercise 73 - Alphabetical Order of String Letters
        public static string SortStringAlphabetically(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return new string(input.OrderBy(c => c).ToArray());
        }

        // Exercises 74 - Odd or Even Length of String
        public static string CheckStringLengthOddEven(string input)
        {
            if (input == null)
                return "Even length";

            return input.Length % 2 == 0 ? "Even length" : "Odd length";
        }

        // Exercise 75 - Nth Odd Number
        public static int GetNthOddNumber(int n)
        {
            if (n <= 0)
                throw new ArgumentException("n must be a positive number");

            return 2 * n - 1;
        }

        // Exercise 76 - Get ASCII Value of Character
        public static int GetAsciiValue(char character)
        {
            return (int)character;
        }

        // Exercise 77 - Check Word Plural
        public static bool IsPlural(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            return word.EndsWith("s", StringComparison.OrdinalIgnoreCase);
        }

        // Exercise 78 - Sum of Squares in Array
        public static int SumOfSquares(int[] numbers)
        {
            if (numbers == null)
                return 0;

            return numbers.Sum(x => x * x);
        }

        // Exercise 79 - Integer to String and Vice Versa
        public static string ConvertIntToString(int number)
        {
            return number.ToString();
        }

        public static int ConvertStringToInt(string text)
        {
            return int.Parse(text);
        }

        // Exercise 80 - Convert Array Elements to Strings
        public static string[] ConvertArrayToStrings(object[] array)
        {
            if (array == null)
                return null;

            string[] result = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i]?.ToString() ?? "";
            }

            return result;
        }

        // Exercise 81 - Check Swapped Two-Digit Number
        public static bool IsGreaterThanSwapped(int number)
        {
            if (number < 10 || number > 99)
                throw new ArgumentException("Number must be a two-digit integer");

            int swapped = (number % 10) * 10 + (number / 10);
            return number > swapped;
        }

        // Exercise 82 - Remove Non-Letter Characters
        public static string RemoveNonLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        // Exercise 83 - Remove Vowels from String
        public static string RemoveVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            foreach (char c in input)
            {
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        // Exercise 84 - Indices of Lowercase Letters
        public static int[] GetLowercaseIndices(string input)
        {
            if (string.IsNullOrEmpty(input))
                return Array.Empty<int>();

            List<int> indices = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    indices.Add(i);
                }
            }

            return indices.ToArray();
        }

        // Exercise 85 - Cumulative Sum of Array
        public static double[] GetCumulativeSum(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return Array.Empty<double>();

            double[] cumulativeSum = new double[numbers.Length];
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                cumulativeSum[i] = sum;
            }

            return cumulativeSum;
        }

        // Exercise 86 - Count Letters and Digits in String
        public static (int letters, int digits) CountLettersAndDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
                return (0, 0);

            int letterCount = input.Count(char.IsLetter);
            int digitCount = input.Count(char.IsDigit);

            return (letterCount, digitCount);
        }

        // Exercise 87 - Reverse Boolean Value
        public static bool ReverseBoolean(bool value)
        {
            return !value;
        }

        // Exercise 88 - Sum of Interior Angles in Polygon
        public static int SumOfInteriorAngles(int sides)
        {
            if (sides < 3)
                throw new ArgumentException("A polygon must have at least 3 sides");

            return (sides - 2) * 180;
        }

        // Exercise 89 - Count Positives and Negatives in Array
        public static (int positives, int negatives) CountPositivesAndNegatives(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return (0, 0);

            int positiveCount = numbers.Count(n => n > 0);
            int negativeCount = numbers.Count(n => n < 0);

            return (positiveCount, negativeCount);
        }

        // Exercises 90 -  Count Ones and Zeros in Binary
        public static (int ones, int zeros) CountOnesAndZeros(int number)
        {
            if (number == 0)
                return (0, 1);

            string binary = Convert.ToString(number, 2);
            int ones = binary.Count(c => c == '1');
            int zeros = binary.Count(c => c == '0');

            return (ones, zeros);
        }

        // Exercise 91 - Remove Non-Integer Values from Array
        public static int[] RemoveNonIntegers(object[] array)
        {
            if (array == null)
                return Array.Empty<int>();

            List<int> integers = new List<int>();

            foreach (object item in array)
            {
                if (item is int intValue)
                {
                    integers.Add(intValue);
                }
            }

            return integers.ToArray();
        }

        // Exercise 92 - Find Next Prime Number
        public static int FindNextPrime(int number)
        {
            if (number < 2)
                return 2;

            if (ItsPrime(number))
                return number;

            int nextNumber = number + 1;
            while (true)
            {
                if (ItsPrime(nextNumber))
                    return nextNumber;
                nextNumber++;
            }
        }

        private static bool ItsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // Exercise 93 - Square Root Without Built-In Functions
        public static int SquareRoot(int number)
        {
            if (number <= 1)
                return number;

            int left = 1;
            int right = number;
            int result = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (mid * mid == number)
                    return mid;

                if (mid * mid < number)
                {
                    left = mid + 1;
                    result = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }

        // Exercise 94 - Find Longest Common Prefix
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (string.IsNullOrEmpty(prefix))
                        return "";
                }
            }

            return prefix;
        }

        // Exercise 95 - Validate Brackets in String
        public static bool ValidateBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' },
            { '>', '<' }
        };

            foreach (char c in input)
            {
                if (bracketPairs.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (bracketPairs.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != bracketPairs[c])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        // Exercise 96 - Check All Characters Same in String
        public static bool AllCharactersSame(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            char firstChar = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != firstChar)
                    return false;
            }

            return true;
        }

        // Exercise 97 - Check Numeric String
        public static bool IsNumeric(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            bool hasDecimalPoint = false;
            bool hasDigit = false;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (i == 0 && (c == '-' || c == '+'))
                {
                    continue;
                }

                if (c == '.')
                {
                    if (hasDecimalPoint || !hasDigit)
                        return false;
                    hasDecimalPoint = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else
                {
                    return false;
                }
            }

            return hasDigit;
        }

        // Exercise 98 - Primes in Descending Order
        public static List<int> GetPrimesDescendingDigits(int limit)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i <= limit; i++)
            {
                if (ItsPrime(i) && HasDescendingDigits(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        private static bool ItIsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        private static bool HasDescendingDigits(int n)
        {
            if (n < 10)
                return true;

            string digits = n.ToString();

            for (int i = 0; i < digits.Length - 1; i++)
            {
                int current = digits[i] - '0';
                int next = digits[i + 1] - '0';

                if (current <= next)
                {
                    return false;
                }
            }

            return true;
        }

        // Exercise 99 - Primes in Ascending Order
        public static List<int> GetPrimesAscendingDigits(int limit)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i <= limit; i++)
            {
                if (ItsPrime(i) && HasAscendingDigits(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        private static bool HasAscendingDigits(int n)
        {
            if (n < 10)
                return true;

            string digits = n.ToString();

            for (int i = 0; i < digits.Length - 1; i++)
            {
                int current = digits[i] - '0';
                int next = digits[i + 1] - '0';

                if (current >= next)
                {
                    return false;
                }
            }

            return true;
        }

        // Exercise 100 - Equality of Value and Type
        public static bool AreEqual(object a, object b)
        {
            return a.GetType() == b.GetType() && a.Equals(b);
        }

        // Exercise 101 - Calculate Euler's Number (e)
        public static double CalculateE(int iterations)
        {
            double e = 1.0;
            double factorial = 1.0;

            for (int i = 1; i <= iterations; i++)
            {
                factorial *= i;
                e += 1.0 / factorial;
            }

            return e;
        }

        // Exercise 102 - Create Identity Matrix
        public static int[,] CreateIdentityMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = (i == j) ? 1 : 0;
                }
            }

            return matrix;
        }

        // Exercise 103 - Sort Characters in String
        public static string SortCharacters(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return "Blank string!";

            return new string(input.OrderBy(c => c).ToArray());
        }

        // Exercise 104 - Compare Equality of Three Integers
        public static int CountEqualIntegers(int a, int b, int c)
        {
            if (a == b && b == c)
                return 3;

            if (a == b || a == c || b == c)
                return 2;

            return 0;
        }
    }
}
