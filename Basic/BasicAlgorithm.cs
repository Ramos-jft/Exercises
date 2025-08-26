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

        // Exercise 51 - Check if One Integer 20 Less Than Another
        public static bool CheckInteger20Less(int a, int b, int c)
        {
            return (a <= b - 20) || (a <= c - 20) ||
                   (b <= a - 20) || (b <= c - 20) ||
                   (c <= a - 20) || (c <= b - 20);
        }

        // Exercise 52 - Largest of Two Integers or Smallest if Same Remainder by 7
        public static int LargestOrSmallestBy7(int a, int b)
        {
            if (a == b) return 0;

            if (a % 7 == b % 7)
                return a < b ? a : b;

            return a > b ? a : b;
        }

        // Exercise 53 - Digit Appears in Both Integers
        public static bool DigitAppearsInBoth(int a, int b)
        {
            int aTens = a / 10;
            int aUnits = a % 10;
            int bTens = b / 10;
            int bUnits = b % 10;

            return aTens == bTens || aTens == bUnits ||
                   aUnits == bTens || aUnits == bUnits;
        }

        // Exercise 54 - Sum of Integers with Same Digit Count
        public static int SumIfSameDigitCount(int x, int y)
        {
            int sum = x + y;

            // Conta dígitos de x e da soma
            int digitCountX = x == 0 ? 1 : (int)Math.Floor(Math.Log10(x)) + 1;
            int digitCountSum = sum == 0 ? 1 : (int)Math.Floor(Math.Log10(sum)) + 1;

            return digitCountSum == digitCountX ? sum : x;
        }

        // Exercise 55 - Sum of Three Integers or Return Third if Two Match
        public static int SumOrThirdIfTwoMatch(int a, int b, int c)
        {
            if (a == b)
                return c;
            else
                return a + b + c;
        }

        // Exercise 56 - Sum of Three Integers Ignoring 13 and Right
        public static int SumIgnoring13AndRight(int a, int b, int c)
        {
            if (a == 13)
                return 0;
            else if (b == 13)
                return a;
            else if (c == 13)
                return a + b;
            else
                return a + b + c;
        }

        // Exercise 57 - Sum Ignoring 10-20 Except 13, 17
        public static int SumIgnoring10To20Except13And17(int a, int b, int c)
        {
            int AdjustValue(int value)
            {
                if (value >= 10 && value <= 20)
                {
                    return (value == 13 || value == 17) ? value : 0;
                }
                return value;
            }

            return AdjustValue(a) + AdjustValue(b) + AdjustValue(c);
        }

        // Exercise 58 - Nearest to 13 Without Crossing
        public static int NearestTo13WithoutCrossing(int a, int b)
        {
            if (a > 13 && b > 13)
                return 0;

            if (a > 13)
                return b;
            if (b > 13)
                return a;

            int diffA = 13 - a;
            int diffB = 13 - b;

            return diffA <= diffB ? a : b;
        }

        // Exercise 59 - Check Equal Differences in Three Integers
        public static bool CheckEqualDifferences(int a, int b, int c)
        {
            int small = Math.Min(Math.Min(a, b), c);
            int large = Math.Max(Math.Max(a, b), c);
            int medium = a + b + c - small - large;

            int diff1 = medium - small;
            int diff2 = large - medium;

            return diff1 == diff2;
        }

        // Exercise 60 - String Format s1s2s2s1
        public static string CreateS1S2S2S1String(string s1, string s2)
        {
            return s1 + s2 + s2 + s1;
        }

        // Exercise 61 - Insert String into Middle of Another
        public static string InsertIntoMiddle(string outer, string inner)
        {
            if (outer.Length != 4)
                return outer; 

            return outer.Substring(0, 2) + inner + outer.Substring(2);
        }

        // Exercise 62 - Three Copies of Last Two Characters
        public static string ThreeCopiesOfLastTwoChars(string str)
        {
            if (str.Length < 2)
                return str;

            string lastTwo = str.Substring(str.Length - 2);
            return lastTwo + lastTwo + lastTwo;
        }

        // Exercise 63 - First Two Characters or Original String
        public static string FirstTwoCharsOrOriginal(string str)
        {
            if (str.Length < 2)
                return str;

            return str.Substring(0, 2);
        }

        // Exercise 64 - First Half of Even-Length String
        public static string FirstHalfOfEvenString(string str)
        {
            if (str.Length % 2 != 0)
                return str; 

            return str.Substring(0, str.Length / 2);
        }

        // Exercise 65 - Remove First and Last Character
        public static string RemoveFirstAndLastChar(string str)
        {
            if (str.Length < 2)
                return str;

            return str.Substring(1, str.Length - 2);
        }

        // Exercise 66 - Format Long+Short+Long Strings
        public static string FormatLongShortLong(string a, string b)
        {
            if (a.Length >= b.Length)
                return a + b + a;
            else
                return b + a + b;
        }

        // Exercise 67 - Combine Strings After Removing First Char
        public static string CombineAfterRemovingFirstChar(string a, string b)
        {
            if (a.Length < 1 || b.Length < 1)
                return a + b;

            return a.Substring(1) + b.Substring(1);
        }

        // Exercise 68 - Move First Two Characters to End
        public static string MoveFirstTwoToEnd(string str)
        {
            if (str.Length < 2)
                return str;

            return str.Substring(2) + str.Substring(0, 2);
        }

        // Exercise 69 - Move Last Two Characters to Start
        public static string MoveLastTwoToStart(string str)
        {
            if (str.Length < 2)
                return str;

            string lastTwo = str.Substring(str.Length - 2);
            string remaining = str.Substring(0, str.Length - 2);

            return lastTwo + remaining;
        }

        // Exercise 70 - Remove First and Last Char
        public static string RemoveFirstAndLastChars(string str)
        {
            if (str.Length <= 2)
                return "";

            return str.Substring(1, str.Length - 2);
        }

        // Exercise 71 - Two Middle Characters of Even-Length String
        public static string TwoMiddleChars(string str)
        {
            if (str.Length < 2 || str.Length % 2 != 0)
                return str;

            int middle = str.Length / 2;
            return str.Substring(middle - 1, 2);
        }

        // Exercise 72 - Ends with 'on'
        public static bool EndsWithOn(string str)
        {
            return str.EndsWith("on");
        }

        // Exercise 73 - First and Last n Characters of String
        public static string FirstLastNChars(string str, int n)
        {
            if (str.Length < n)
                return str;

            return str.Substring(0, n) + str.Substring(str.Length - n);
        }

        // Exercise 74 - Two Characters Starting at Index
        public static string TwoCharsFromIndex(string str, int index)
        {
            if (index + 2 > str.Length)
                return str.Substring(index);

            return str.Substring(index, 2);
        }

        // Exercise 75 - Three Characters from Middle of String
        public static string ThreeCharsFromMiddle(string str)
        {
            if (str.Length <= 3)
                return str;

            int middle = str.Length / 2;
            int start = middle - 1;

            return str.Substring(start, 3);
        }

        // Exercise 76 - First Two Characters with Missing '#' if Short
        public static string FirstTwoCharsWithHash(string str)
        {
            if (str.Length >= 2)
                return str.Substring(0, 2);

            if (str.Length == 1)
                return str + "#";

            return "##";
        }

        // Exercise 77 - First and Last Char of Two Strings
        public static string FirstAndLastChar(string a, string b)
        {
            char firstChar = a.Length > 0 ? a[0] : '#';
            char lastChar = b.Length > 0 ? b[b.Length - 1] : '#';

            return $"{firstChar}{lastChar}";
        }

        // Exercise 78 - Combine Strings Removing Duplicates
        public static string CombineRemoveDuplicates(string a, string b)
        {
            if (string.IsNullOrEmpty(a)) return b;
            if (string.IsNullOrEmpty(b)) return a;

            if (a[a.Length - 1] == b[0])
                return a + b.Substring(1);

            return a + b;
        }

        // Exercise 79 - Swap Last Two Characters
        public static string SwapLastTwoChars(string str)
        {
            if (str.Length < 2)
                return str;

            char[] chars = str.ToCharArray();
            char temp = chars[chars.Length - 1];
            chars[chars.Length - 1] = chars[chars.Length - 2];
            chars[chars.Length - 2] = temp;

            return new string(chars);
        }

        // Exercise 80 - Starts with 'abc' or 'xyz'
        public static string StartsWithAbcOrXyz(string str)
        {
            if (str.StartsWith("abc"))
                return "abc";
            if (str.StartsWith("xyz"))
                return "xyz";

            return "";
        }

        // Exercise 81 - First Two and Last Two Characters Same
        public static bool FirstTwoLastTwoSame(string str)
        {
            if (str.Length < 2)
                return false;

            string firstTwo = str.Substring(0, 2);
            string lastTwo = str.Substring(str.Length - 2);

            return firstTwo == lastTwo;
        }

        // Exercise 82 - Combine Strings After Adjusting Lengths
        public static string CombineAdjustLengths(string a, string b)
        {
            int minLength = Math.Min(a.Length, b.Length);
            return a.Substring(0, minLength) + b.Substring(0, minLength);
        }

        // Exercise 83 - Three Copies of First Two Characters
        public static string ThreeCopiesFirstTwo(string str)
        {
            string baseString = str.Length < 2 ? str : str.Substring(0, 2);
            return baseString + baseString + baseString;
        }

        // Exercise 84 - Remove First Two if Start and End Match
        public static string RemoveFirstTwoIfEndsMatch(string str)
        {
            if (str.Length >= 2 && str[0] == str[str.Length - 1])
                return str.Substring(2);

            return str;
        }

        // Exercise 85 - Remove First Two Except 'p' and 'y'
        public static string RemoveFirstTwoExceptPY(string str)
        {
            if (str.Length < 2)
                return str;

            string result = "";
            if (str[0] == 'p')
                result += 'p';

            if (str[1] == 'y')
                result += 'y';

            return result + str.Substring(2);
        }

        // Exercise 86 - Remove 'a' if at Start or End
        public static string RemoveAIfAtStartOrEnd(string str)
        {
            if (str.Length == 0)
                return str;

            string result = str;

            if (str[0] == 'a')
                result = result.Substring(1);

            if (result.Length > 0 && result[result.Length - 1] == 'a')
                result = result.Substring(0, result.Length - 1);

            return result;
        }

        // Exercise 87 - Remove First Two 'a's if Present
        public static string RemoveFirstTwoAs(string str)
        {
            string result = str;

            if (result.Length > 0 && result[0] == 'a')
                result = result.Substring(1);

            if (result.Length > 0 && result[0] == 'a')
                result = result.Substring(1);

            return result;
        }

        // Exercise 88 - 10 as First or Last Element in Array
        public static bool Check10FirstOrLast(int[] nums)
        {
            return nums[0] == 10 || nums[nums.Length - 1] == 10;
        }

        // Exercise 89 - First and Last Array Elements Equal
        public static bool FirstLastEqual(int[] nums)
        {
            return nums[0] == nums[nums.Length - 1];
        }

        // Exercise 90 - Same First or Last Element in Two Arrays
        public static bool SameFirstOrLast(int[] a, int[] b)
        {
            return a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1];
        }

        // Exercise 91 - Sum of Array Elements
        public static int SumArray(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }

        // Exercise 92 - Rotate Array Left
        public static int[] RotateLeft(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            int first = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = first;

            return nums;
        }

        // Exercise 93 - Reverse Array
        public static int[] ReverseArray(int[] nums)
        {
            int[] reversed = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                reversed[i] = nums[nums.Length - 1 - i];
            }
            return reversed;
        }

        // Exercise 94 - Replace All Elements with Max of First/Last
        public static int[] ReplaceWithMax(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = max;
            }
            return nums;
        }

        // Exercise 95 - Middle Elements from Two Arrays
        public static int[] GetMiddleElements(int[] a, int[] b)
        {
            return new int[] { a[2], b[2] };
        }

        // Exercise 96 - First and Last Elements of Array
        public static int[] GetFirstLastElements(int[] nums)
        {
            return new int[] { nums[0], nums[nums.Length - 1] };
        }

        // Exercise 97 - Array of Length 2 Contains 15 or 20
        public static bool Contains15Or20(int[] nums)
        {
            return nums[0] == 15 || nums[0] == 20 || nums[1] == 15 || nums[1] == 20;
        }

        // Exercise 98 - Array of Length 2 Does Not Contain 15 or 20
        public static bool NotContains15Or20(int[] nums)
        {
            return nums[0] != 15 && nums[0] != 20 && nums[1] != 15 && nums[1] != 20;
        }

        // Exercise 99 - Double Length Array with First Element Copied
        public static int[] DoubleLengthArray(int[] nums)
        {
            int[] result = new int[nums.Length * 2];
            result[0] = nums[0];
            return result;
        }

        // Exercise 100 - Check if 10 or 20 Appears Twice in Array
        public static bool Contains10Or20Twice(int[] nums)
        {
            int count10 = 0;
            int count20 = 0;

            foreach (int num in nums)
            {
                if (num == 10) count10++;
                if (num == 20) count20++;
            }

            return count10 == 2 || count20 == 2;
        }

        // Exercise 101 - Set 7 to 1 if Followed by 5
        public static int[] Set7To1IfFollowedBy5(int[] nums)
        {
            int[] result = new int[3];
            Array.Copy(nums, result, 3);

            if (nums[0] == 5 && nums[1] == 7)
                result[1] = 1;
            if (nums[1] == 5 && nums[2] == 7)
                result[2] = 1;

            return result;
        }

        // Exercise 102 - Largest Sum Between Two Arrays
        public static int[] GetLargerSumArray(int[] a, int[] b)
        {
            int sumA = a[0] + a[1] + a[2];
            int sumB = b[0] + b[1] + b[2];

            return sumA >= sumB ? a : b;
        }

        // Exercise 103 - Middle Elements of Even-Length Array
        public static int[] GetMiddleElements(int[] nums)
        {
            int middle = nums.Length / 2;
            return new int[] { nums[middle - 1], nums[middle] };
        }

        // Exercise 104 - Merge Two Arrays of Length 3
        public static int[] MergeArrays(int[] a, int[] b)
        {
            int[] result = new int[6];
            Array.Copy(a, 0, result, 0, 3);
            Array.Copy(b, 0, result, 3, 3);
            return result;
        }

        // Exercise 105 - Swap First and Last Array Elements
        public static int[] SwapFirstLast(int[] nums)
        {
            if (nums.Length < 1)
                return nums;

            int[] result = new int[nums.Length];
            Array.Copy(nums, result, nums.Length);

            int temp = result[0];
            result[0] = result[result.Length - 1];
            result[result.Length - 1] = temp;

            return result;
        }

        // Exercise 106 - Middle Elements in New Array of Length 3
        public static int[] MiddleElementsToNewArray(int[] nums)
        {
            int middle = nums.Length / 2;
            return new int[] { nums[middle - 1], nums[middle], nums[middle + 1] };
        }

        // Exercise 107 - Largest Among First, Middle, and Last Elements
        public static int LargestFirstMiddleLast(int[] nums)
        {
            int first = nums[0];
            int middle = nums[nums.Length / 2];
            int last = nums[nums.Length - 1];

            return Math.Max(Math.Max(first, middle), last);
        }

        // Exercise 108 - First Two Elements or Full Array
        public static int[] FirstTwoElements(int[] nums)
        {
            if (nums.Length < 2)
                return nums;

            return new int[] { nums[0], nums[1] };
        }

        // Exercise 109 - Count Even Elements in Array
        public static int CountEvenElements(int[] nums)
        {
            int count = 0;
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                    count++;
            }
            return count;
        }

        // Exercise 110 - Difference Between Largest and Smallest Values
        public static int DifferenceMaxMin(int[] nums)
        {
            int min = nums[0];
            int max = nums[0];

            foreach (int num in nums)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            return max - min;
        }
    }
}
