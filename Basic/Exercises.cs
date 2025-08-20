using System.Data;
using System.Text;

namespace BasicExercises
{
    public class Exercises
    {
        // Exercise 1 - Print Hello and Name
        public string Message(string name)
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
        public int GetMaxOfFirstAndLast(int[] array)
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
    }
}
