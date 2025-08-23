using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class BasicAlgorithm
    {
        // Exercise 1 - Triple Sum for Equal Integers
        public static int TripleSumForEqualIntegers(int a, int b)
        {
            return a == b ? 3 * (a + b) : a + b;
        }

        // Exercise 2 - Absolute Difference with Triple for Greater
        public static int AbsoluteDifferenceWithTriple(int n)
        {
            const int baseValue = 51;
            int difference = Math.Abs(n - baseValue);

            return n > baseValue ? 3 * difference : difference;
        }

        // Exercise 3 - Check 30 or Sum Equals 30
        public static bool Check30OrSumEquals30(int a, int b)
        {
            return a == 30 || b == 30 || a + b == 30;
        }

        // Exercise 4 - Within 10 of 100 or 200
        public static bool Within10Of100Or200(int n)
        {
            return Math.Abs(100 - n) <= 10 || Math.Abs(200 - n) <= 10;
        }

        // Exercise 5 - Add 'if' to String if Absent
        public static string AddIfToString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "if";
            }

            if (input.TrimStart().StartsWith("if", StringComparison.OrdinalIgnoreCase))
            {
                return input;
            }

            return "if " + input;
        }

        // Exercise 6 - Remove Character at Position
        public static string RemoveCharacterAtPosition(string input, int position)
        {
            if (string.IsNullOrEmpty(input) || position < 0 || position >= input.Length)
            {
                return input;
            }

            return input.Remove(position, 1);
        }

        // Exercise 7 - Exchange First and Last Characters
        public static string ExchangeFirstLastCharacters(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
            {
                return input;
            }

            char firstChar = input[0];
            char lastChar = input[input.Length - 1];
            string middle = input.Substring(1, input.Length - 2);

            return lastChar + middle + firstChar;
        }

        // Exercise 8 - Four Copies of First Two Characters
        public static string FourCopiesOfFirstTwoCharacters(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                return input;
            }

            string firstTwoChars = input.Substring(0, 2);
            return string.Concat(Enumerable.Repeat(firstTwoChars, 4));
        }

        // Exercise 9 - Last Character at Front and Back
        public static string LastCharacterAtFrontAndBack(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char lastChar = input[input.Length - 1];
            return lastChar + input + lastChar;
        }

        // Exercise 10 - Multiple of 3 or 7
        public static bool MultipleOf3Or7(int number)
        {
            if (number <= 0)
            {
                return false;
            }

            return number % 3 == 0 || number % 7 == 0;
        }

        // Exercise 11 - First Three Characters Front and Back
        public static string FirstThreeCharsFrontBack(string str)
        {
            if (str.Length < 3)
            {
                return str + str + str;
            }

            string firstThree = str.Substring(0, 3);
            return firstThree + str + firstThree;
        }

        // Exercise 12 - Starts with 'C#'
        public static bool StartsWithCSharp(string str)
        {
            return str.StartsWith("C#");
        }

        // Exercise 13 - Temperature Comparison
        public static bool CheckTemperatures(int temp1, int temp2)
        {
            return (temp1 < 0 && temp2 > 100) || (temp1 > 100 && temp2 < 0);
        }

        // Exercise 14 - One Integer in Range 100-200
        public static bool IsOneInRange100To200(int num1, int num2)
        {
            return (num1 >= 100 && num1 <= 200) || (num2 >= 100 && num2 <= 200);
        }

        //Exercise 15 - Check Integers in Range 20-50
        public static bool CheckIntegersInRange20To50(int num1, int num2, int num3)
        {
            return (num1 >= 20 && num1 <= 50) ||
                   (num2 >= 20 && num2 <= 50) ||
                   (num3 >= 20 && num3 <= 50);
        }

        // Exercise 16 - One of Two Integers in Range 20-50
        public static bool IsOneOfTwoInRange20To50(int num1, int num2)
        {
            return (num1 >= 20 && num1 <= 50) || (num2 >= 20 && num2 <= 50);
        }

        // Exercise 17 - Remove 'yt' at Index 1
        public static string RemoveYtIfAtPosition1(string str)
        {
            if (str.Length >= 3 && str.Substring(1, 2) == "yt")
            {
                return str.Remove(1, 2);
            }
            return str;
        }

        // Exercise 18 - Largest Among Three Integers
        public static int LargestAmongThree(int num1, int num2, int num3)
        {
            return Math.Max(Math.Max(num1, num2), num3);
        }

        // Exercise 19 - Closest to 100 Between Two
        public static int ClosestTo100(int num1, int num2)
        {
            if (num1 == num2)
                return 0;

            int diff1 = Math.Abs(100 - num1);
            int diff2 = Math.Abs(100 - num2);

            if (diff1 == diff2)
                return Math.Min(num1, num2); // Return the smaller number when equally distant

            return diff1 < diff2 ? num1 : num2;
        }

        // Exercise 20 - Both Integers in Ranges 40-50 or 50-60
        public static bool BothInRanges40To50Or50To60(int num1, int num2)
        {
            bool bothIn40To50 = (num1 >= 40 && num1 <= 50) && (num2 >= 40 && num2 <= 50);
            bool bothIn50To60 = (num1 >= 50 && num1 <= 60) && (num2 >= 50 && num2 <= 60);

            return bothIn40To50 || bothIn50To60;
        }

        // Exercise 21 - Largest in Range 20-30
        public static int LargestInRange20To30(int num1, int num2)
        {
            bool num1InRange = num1 >= 20 && num1 <= 30;
            bool num2InRange = num2 >= 20 && num2 <= 30;

            if (!num1InRange && !num2InRange)
                return 0;

            if (num1InRange && num2InRange)
                return Math.Max(num1, num2);

            return num1InRange ? num1 : num2;
        }

        // Exercise 22 - Contains 2-4 'z' Characters
        public static bool ContainsTwoToFourZ(string str)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (c == 'z')
                    count++;
            }

            return count >= 2 && count <= 4;
        }

        // Exercise 23 - Same Last Digit for Two Integers
        public static bool HaveSameLastDigit(int num1, int num2)
        {
            return num1 % 10 == num2 % 10;
        }

        // Exercise 24 - Uppercase Last Three Characters
        public static string UppercaseLastThreeChars(string str)
        {
            if (str.Length < 3)
                return str.ToUpper();

            string firstPart = str.Substring(0, str.Length - 3);
            string lastThree = str.Substring(str.Length - 3).ToUpper();

            return firstPart + lastThree;
        }

        // Exercise 25 - n Copies of String
        public static string NCopiesOfString(string str, int n)
        {
            if (n <= 0)
                return "";

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }

        // Exercise 26 - n Copies of First Three Characters
        public static string NCopiesOfFirstThreeChars(string str, int n)
        {
            if (n <= 0)
                return "";

            string source = str.Length < 3 ? str : str.Substring(0, 3);

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(source);
            }
            return result.ToString();
        }

        // Exercise 27 - Count 'aa' in String
        public static int CountAaInString(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'a' && str[i + 1] == 'a')
                {
                    count++;
                }
            }

            return count;
        }

        // Exercise 28 - First 'a' Followed by Another 'a'
        public static bool FirstAIsFollowedByAnotherA(string str)
        {
            int firstAIndex = str.IndexOf('a');

            if (firstAIndex == -1 || firstAIndex == str.Length - 1)
                return false;

            return str[firstAIndex + 1] == 'a';
        }

        // Exercise 29 - Every Other Character in String
        public static string EveryOtherCharacter(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i += 2)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        // Exercise 30 - Cumulative Substrings
        public static string CumulativeSubstrings(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                result.Append(str.Substring(0, i + 1));
            }

            return result.ToString();
        }

        // Exercise 31 - Count Substring Matching Last Two Characters
        public static int CountSubstringMatchingLastTwo(string str)
        {
            if (str.Length < 3)
                return 0;

            string lastTwo = str.Substring(str.Length - 2);
            int count = 0;

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == lastTwo)
                {
                    count++;
                }
            }

            return count;
        }

        // Exercise 32 - Check if Element Present in Array
        public static bool IsElementPresent(int[] numbers, int target)
        {
            return numbers.Contains(target);
        }

        // Exercise 33 - Element in First 4 Positions of Array
        public static bool IsElementInFirstFour(int[] numbers, int target)
        {
            int lengthToCheck = Math.Min(4, numbers.Length);

            for (int i = 0; i < lengthToCheck; i++)
            {
                if (numbers[i] == target)
                    return true;
            }

            return false;
        }

        // Exercise 34 - Check Sequence 1, 2, 3 in Array
        public static bool ContainsSequence123(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                    return true;
            }
            return false;
        }

        // Exercise 35 - Count Matching Substrings in Two Strings
        public static int CountMatchingSubstrings(string str1, string str2)
        {
            HashSet<string> substrings1 = new HashSet<string>();
            HashSet<string> substrings2 = new HashSet<string>();

            // Get all unique 2-character substrings from str1
            for (int i = 0; i < str1.Length - 1; i++)
            {
                substrings1.Add(str1.Substring(i, 2));
            }

            // Get all unique 2-character substrings from str2
            for (int i = 0; i < str2.Length - 1; i++)
            {
                substrings2.Add(str2.Substring(i, 2));
            }

            // Count intersections
            substrings1.IntersectWith(substrings2);
            return substrings1.Count;
        }

        // Exercise 36 - Remove Character Except First and Last
        public static string RemoveCharExceptFirstAndLast(string str, char targetChar)
        {
            if (str.Length <= 2)
                return str;

            StringBuilder result = new StringBuilder();
            result.Append(str[0]); // Always keep first character

            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] != targetChar)
                {
                    result.Append(str[i]);
                }
            }

            result.Append(str[str.Length - 1]); // Always keep last character
            return result.ToString();
        }

        // Exercise 37 - Characters at Index 0,1,4,5,...
        public static string CharactersAtSpecialIndexes(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 4 == 0 || i % 4 == 1)
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }

        // Exercise 38 - Count 5's Next to Each Other
        public static int CountFivesNextToEachOther(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 5 && (numbers[i + 1] == 5 || numbers[i + 1] == 6))
                {
                    count++;
                }
            }

            return count;
        }

        // Exercise 39 - Check Triple in Array
        public static bool HasTriple(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    return true;
                }
            }
            return false;
        }

        // Exercise 40 - Sum in Range 10-20 Returns 30
        public static int SumWithSpecialRule(int a, int b)
        {
            int sum = a + b;

            if (sum >= 10 && sum <= 20)
                return 30;

            return sum;
        }

        // Exercise 41 - Check for 5 or Sum/Difference Equals 5
        public static bool CheckFiveOrSumDiffFive(int a, int b)
        {
            return a == 5 || b == 5 || a + b == 5 || Math.Abs(a - b) == 5;
        }

        // Exercise 42 - Multiple of 13 or 1 More
        public static bool IsMultipleOf13OrOneMore(int number)
        {
            return number % 13 == 0 || number % 13 == 1;
        }

        // Exercise 43 - Multiple of 3 or 7 but Not Both
        public static bool IsMultipleOf3Or7ButNotBoth(int number)
        {
            bool multipleOf3 = number % 3 == 0;
            bool multipleOf7 = number % 7 == 0;

            return (multipleOf3 || multipleOf7) && !(multipleOf3 && multipleOf7);
        }

        // Exercise 44 - Within 2 of Multiple of 10
        public static bool Within2OfMultipleOf10(int number)
        {
            return number % 10 <= 2 || number % 10 >= 8;
        }

        // Exercise 45 - Sum is 18 if One Value in 10-20 Range
        public static int SumWithSpecialRules(int a, int b)
        {
            // Check if either number is in range 10-20 inclusive
            bool aInRange = a >= 10 && a <= 20;
            bool bInRange = b >= 10 && b <= 20;

            if (aInRange || bInRange)
                return 18;

            return a + b;
        }

        // Exercise 46 - Fizz, Buzz, FizzBuzz
        public static string FizzBuzzCheck(string str)
        {
            bool startsWithF = str.StartsWith("F");
            bool endsWithB = str.EndsWith("B");

            if (startsWithF && endsWithB)
                return "FizzBuzz";
            if (startsWithF)
                return "Fizz";
            if (endsWithB)
                return "Buzz";

            return str;
        }

        // Exercise 47 - Sum of Two Equals Third
        public static bool SumOfTwoEqualsThird(int a, int b, int c)
        {
            return a + b == c || a + c == b || b + c == a;
        }

        // Exercise 48 - Strict Increasing Order for Three Numbers
        public static bool IsStrictlyIncreasing(int x, int y, int z)
        {
            return y > x && z > y;
        }

        // Exercise 49 - Strictly Increasing or Equal if Flag True
        public static bool CheckIncreasingOrder(int a, int b, int c, bool allowEquality)
        {
            if (allowEquality)
            {
                return a <= b && b <= c;
            }
            else
            {
                return a < b && b < c;
            }
        }

        // Exercise 50 - Same Rightmost Digit in Two or More Integers
        public static bool SameRightmostDigit(params int[] numbers)
        {
            if (numbers.Length < 2)
                return false;

            HashSet<int> lastDigits = new HashSet<int>();

            foreach (int num in numbers)
            {
                int lastDigit = num % 10;
                if (lastDigits.Contains(lastDigit))
                {
                    return true;
                }
                lastDigits.Add(lastDigit);
            }

            return false;
        }
    }
}
