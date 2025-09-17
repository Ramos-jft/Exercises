
using System.Collections;
using System.Globalization;

namespace Exercises
{
    public class StringOperations
    {
        // Exercise 1 - Write a program in C# Sharp to input a string and print it.
        public static string GetInputString(string input)
        {
            return input;
        }

        // Exercise 2 - Write a C# Sharp program to find the length of a string without using a library function.
        public static int GetStringLength(string input)
        {
            var length = 0;
            foreach (var c in input)
            {
                length++;
            }
            return length;
        }

        // Exercise 3 - Write a C# Sharp program to separate individual characters from a string.
        public static string SeparateCharacters(string input)
        {
            var result = "";
            foreach (var c in input)
            {
                result += c + " ";
            }
            return result.Trim();
        }

        // Exercise 4 - Write a program in C# Sharp to print individual characters of the string in reverse order.
        public static string ReverseCharacters(string input)
        {
            var result = "";
            for (var i = input.Length - 1; i >= 0; i--)
            {
                result += input[i] + " ";
            }
            return result.Trim();
        }

        // Exercise 5 - Write a program in C# Sharp to count the total number of words in a string.
        public static int CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            var wordCount = 0;
            var inWord = false;

            foreach (var c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    inWord = false;
                }
                else if (!inWord)
                {
                    wordCount++;
                    inWord = true;
                }
            }

            return wordCount;
        }

        // Exercise 6 - Write a program in C# Sharp to compare two strings without using a string library functions.
        public static (bool areEqual, int lengthComparison) CompareStrings(string str1, string str2)
        {
            var l1 = GetLength(str1);
            var l2 = GetLength(str2);

            var lengthComparison = l1.CompareTo(l2);

            if (l1 != l2)
            {
                return (false, lengthComparison);
            }

            for (var i = 0; i < l1; i++)
            {
                if (str1[i] != str2[i])
                {
                    return (false, 0);
                }
            }

            return (true, 0);
        }

        private static int GetLength(string str)
        {
            var length = 0;
            foreach (var c in str)
            {
                length++;
            }
            return length;
        }

        // Exercise 7 - Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.
        public static (int alphabets, int digits, int specialChars) CountCharacters(string input)
        {
            var alphabets = 0;
            var digits = 0;
            var specialChars = 0;

            foreach (var c in input)
            {
                if (char.IsLetter(c))
                {
                    alphabets++;
                }
                else if (char.IsDigit(c))
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }

            return (alphabets, digits, specialChars);
        }

        // Exercise 8 - Write a program in C# Sharp to copy one string to another string.
        public static (string copiedString, int characterCount) CopyString(string input)
        {
            var copiedString = "";
            var characterCount = 0;

            foreach (var c in input)
            {
                copiedString += c;
                characterCount++;
            }

            return (copiedString, characterCount);
        }

        // Exercise 9 - Write a C# Sharp program to count the number of vowels or consonants in a string.
        public static (int vowels, int consonants) CountVowelsAndConsonants(string input)
        {
            var vowels = 0;
            var consonants = 0;

            foreach (var c in input)
            {
                if (char.IsLetter(c))
                {
                    var lowerChar = char.ToLower(c);
                    if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            return (vowels, consonants);
        }

        // Exercise 10 - Write a C# Sharp program to find the maximum number of characters in a string.
        public static (char character, int count) FindMaxCharacterFrequency(string input)
        {
            if (string.IsNullOrEmpty(input))
                return ('\0', 0);

            var frequency = new int[256];

            foreach (var c in input)
            {
                if (c < 256)
                {
                    frequency[c]++;
                }
            }

            var maxChar = '\0';
            var maxCount = 0;

            for (var i = 0; i < 256; i++)
            {
                if (frequency[i] > maxCount && i != ' ')
                {
                    maxCount = frequency[i];
                    maxChar = (char)i;
                }
            }

            return (maxChar, maxCount);
        }

        // Exercise 11 - Write a C# Sharp program to sort a string array in ascending order.
        public static string SortStringAscending(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var chars = input.ToCharArray();

            for (var i = 0; i < chars.Length - 1; i++)
            {
                for (var j = 0; j < chars.Length - i - 1; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        (chars[j], chars[j + 1]) = (chars[j + 1], chars[j]);
                    }
                }
            }

            return new string(chars);
        }

        // Exercise 12 - Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.
        public static string[] SortStrings(string[] strings)
        {
            var arr = strings;
            var n = arr.Length;

            for (var i = 0; i < n - 1; i++)
            {
                for (var j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        // Exercise 13 - Write a program in C# Sharp to extract a substring from a given string without using the library function.
        public static string ExtractSubstring(string input, int startPosition, int length)
        {
            var result = "";

            for (var i = 0; i < length; i++)
            {
                var index = startPosition - 1 + i;
                if (index < input.Length)
                {
                    result += input[index];
                }
            }

            return result;
        }

        // Exercise 14 - Write a C# Sharp program to check whether a given substring is present in the given string.
        public static bool ContainsSubstring(string input, string substring)
        {
            if (substring.Length == 0) return true;

            for (var i = 0; i <= input.Length - substring.Length; i++)
            {
                var found = true;

                for (var j = 0; j < substring.Length; j++)
                {
                    if (input[i + j] != substring[j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found) return true;
            }

            return false;
        }

        // Exercise 15 - Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.
        public static string SwapCase(string input)
        {
            var result = "";

            foreach (var c in input)
            {
                if (char.IsLower(c))
                {
                    result += char.ToUpper(c);
                }
                else
                {
                    result += char.ToLower(c);
                }
            }

            return result;
        }

        // Exercise 16 - Write a program in C# Sharp to check the username and password.
        public static string ValidateCredentials(string username, string password)
        {
            const string validUsername = "abcd";
            const string validPassword = "1234";

            return username == validUsername && password == validPassword
                ? "Password entered successfully!"
                : "Invalid credentials!";
        }

        // Exercise 17 - Write a program in C# Sharp to search for the position of a substring within a string.
        public static int FindSubstringPosition(string input, string substring)
        {
            if (substring.Length == 0) return 0;

            for (var i = 0; i <= input.Length - substring.Length; i++)
            {
                var match = true;

                for (var j = 0; j < substring.Length; j++)
                {
                    if (input[i + j] != substring[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match) return i;
            }

            return -1;
        }

        // Exercise 18 - Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.
        public static string CheckCharacterType(char character)
        {
            if (!char.IsLetter(character))
                return "The entered character is not an alphabetic character.";

            return char.IsUpper(character)
                ? "The character is uppercase."
                : "The character is lowercase.";
        }

        // Exercise 19 - Write a program in C# Sharp to find the number of times a substring appears in a given string.
        public static int CountSubstringOccurrences(string input, string substring)
        {
            if (substring.Length == 0) return 0;

            var count = 0;
            var index = 0;

            while ((index = input.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }

            return count;
        }

        // Exercise 20 - Write a program in C# Sharp to insert a substring before the first occurrence of a string.
        public static string InsertBeforeFirstOccurrence(string input, string search, string insert)
        {
            var index = input.IndexOf(search);
            if (index == -1) return input;

            return input.Insert(index, insert.Trim() + " ");
        }

        // Exercise 21 - Write a C# Sharp program to compare (less than, greater than, equal to) two substrings.
        public static string CompareSubstrings(string str1, int start1, string str2, int start2, int length)
        {
            var substring1 = str1.Substring(start1, Math.Min(length, str1.Length - start1));
            var substring2 = str2.Substring(start2, Math.Min(length, str2.Length - start2));

            var result = string.Compare(substring1, substring2);

            return result < 0 ? "less than" : result > 0 ? "greater than" : "equal to";
        }

        /* Exercise 22 - Write a C# Sharp program to compare two substrings that only differ in case.
        The first comparison ignores case and the second comparison considers case.*/
        public static (string ignoreCaseResult, string honorCaseResult) CompareSubstringsWithCase(string str1, string str2, int start, int length)
        {
            var ignoreCase = string.Compare(str1, start, str2, start, length, StringComparison.OrdinalIgnoreCase);
            var honorCase = string.Compare(str1, start, str2, start, length, StringComparison.Ordinal);

            var ignoreCaseStr = ignoreCase < 0 ? "less than" : ignoreCase > 0 ? "greater than" : "equal to";
            var honorCaseStr = honorCase < 0 ? "less than" : honorCase > 0 ? "greater than" : "equal to";

            return (ignoreCaseStr, honorCaseStr);
        }

        // Exercise 23 - Write a C# Sharp program to compare two substrings using different cultures and ignore the substring case.
        public static (string turkishResult, string invariantResult) CompareSubstringsWithCultures(string str1, string str2, int start, int length)
        {
            var turkishCulture = new CultureInfo("tr-TR");
            var invariantCulture = CultureInfo.InvariantCulture;

            var turkishResult = string.Compare(str1, start, str2, start, length, true, turkishCulture);
            var invariantResult = string.Compare(str1, start, str2, start, length, true, invariantCulture);

            var turkishStr = turkishResult < 0 ? "less than" : turkishResult > 0 ? "greater than" : "equal to";
            var invariantStr = invariantResult < 0 ? "less than" : invariantResult > 0 ? "greater than" : "equal to";

            return (turkishStr, invariantStr);
        }

        // Exercise 24 - Write a C# Sharp program to compare the last names of two people. It then lists them in alphabetical order.
        public static string[] SortByLastName(string name1, string name2)
        {
            var lastName1 = name1.Substring(name1.LastIndexOf(' ') + 1);
            var lastName2 = name2.Substring(name2.LastIndexOf(' ') + 1);

            var comparison = string.Compare(lastName1, lastName2, StringComparison.OrdinalIgnoreCase);

            return comparison <= 0
                ? new[] { name1, name2 }
                : new[] { name2, name1 };
        }

        /* Exercise 25 - Write a C# Sharp program to compare four sets of words by using each member of the string comparison enumeration.
        The comparisons use the conventions of the English (United States) and Sami (Upper Sweden) cultures.*/
        public static bool[] CompareStringsWithAllComparisons(string str1, string str2, CultureInfo culture)
        {
            var comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));
            var results = new bool[comparisons.Length];

            for (var i = 0; i < comparisons.Length; i++)
            {
                results[i] = string.Equals(str1, str2, comparisons[i]);
            }

            return results;
        }

        /* Exercise 26 - Write C# Sharp program to demonstrate that the Compare(String, String, Boolean)
        method is equivalent to using ToUpper or ToLower when comparing strings.*/
        public static (bool toUpperEqual, bool ignoreCaseEqual) CompareWithCaseMethods(string str1, string str2)
        {
            var toUpperEqual = string.Compare(str1.ToUpper(), str2.ToUpper()) == 0;
            var ignoreCaseEqual = string.Compare(str1, str2, true) == 0;

            return (toUpperEqual, ignoreCaseEqual);
        }

        // Exercise 27 - Write a C# Sharp program to demonstrate how culture affects comparisons.
        public static string CompareWithCulture(string str1, string str2, string cultureName)
        {
            var culture = new CultureInfo(cultureName);
            var result = string.Compare(str1, str2, false, culture);

            return result < 0 ? "<" : result > 0 ? ">" : "=";
        }

        // Exercise 28 - Write a C# Sharp program to compare two strings in following three different ways produce three different results.
        public static (string linguistic, string caseInsensitive, string ordinal) CompareStringsThreeWays(string str1, string str2)
        {
            var culture = new CultureInfo("en-US");

            var linguisticResult = String.Compare(str1, str2, culture, CompareOptions.None);
            var caseInsensitiveResult = String.Compare(str1, str2, culture, CompareOptions.IgnoreCase);
            var ordinalResult = String.CompareOrdinal(str1, str2);

            var linguisticRelation = linguisticResult > 0 ? "comes after" : linguisticResult == 0 ? "is the same as" : "comes before";
            var caseInsensitiveRelation = caseInsensitiveResult > 0 ? "comes after" : caseInsensitiveResult == 0 ? "is the same as" : "comes before";
            var ordinalRelation = ordinalResult > 0 ? "comes after" : ordinalResult == 0 ? "is the same as" : "comes before";

            return (linguisticRelation, caseInsensitiveRelation, ordinalRelation);
        }

        /* Exercise 29 - Write a C# Sharp program to compare three versions of the letter "I".
        The results are affected by culture choice, whether the case is ignored, and whether an ordinal comparison is performed.*/
        public static string GetComparisonResult(StringComparison comparison, string char1, string char2, string name1, string name2)
        {
            var cmpValue = string.Compare(char1, char2, comparison);
            var result = cmpValue < 0 ? "less than" : cmpValue > 0 ? "greater than" : "equal to";
            return $"{name1} is {result} {name2}";
        }

        // Exercise 30 - Write a C# Sharp program to demonstrate that you compare ordinals and compare using different sort orders.
        public static (string ordinalResult, string cultureResult) CompareCharacters(string str1, int pos1, string str2, int pos2)
        {
            var ordinalX = string.CompareOrdinal(str1, pos1, str2, pos2, 1);
            var ordinalResult = ordinalX < 0 ? "less than" : ordinalX > 0 ? "greater than" : "equal to";

            var cultureX = string.Compare(str1, pos1, str2, pos2, 1, false, new CultureInfo("en-US"));
            var cultureResult = cultureX < 0 ? "less than" : cultureX > 0 ? "greater than" : "equal to";

            return (ordinalResult, cultureResult);
        }

        // Exercise 31 - Write a C# Sharp program to perform an ordinal comparison of two strings that only differ in case.
        public static string CompareOrdinalStrings(string str1, string str2)
        {
            var result = string.CompareOrdinal(str1, str2);
            return result < 0 ? "less than" : result > 0 ? "greater than" : "equal to";
        }

        // Exercise 32 - Write a C# Sharp program to compare a given string with a set of strings.
        public static (int? result, string error) CompareWithObject(string str, object obj)
        {
            try
            {
                var comparisonResult = str.CompareTo(obj);
                return (comparisonResult, null);
            }
            catch (ArgumentException)
            {
                return (null, $"Bad argument: {obj} (type {obj.GetType().Name})");
            }
        }

        // Exercise 33 - Write a C# Sharp program to compare the current string instance with another string.
        public static string CompareToString(string str1, string str2)
        {
            var cmpVal = str1.CompareTo(str2);

            if (cmpVal == 0)
                return "The strings occur in the same position in the sort order.";
            else if (cmpVal > 0)
                return "The first string precedes the second in the sort order.";
            else
                return "The first string follows the second in the sort order.";
        }

        // Exercise 34 - Write a C# Sharp program to concatenate three objects, objects with a variable and a 3-element object array.
        public static string ConcatObjects(object obj1, object obj2, object obj3)
        {
            return string.Concat(obj1, obj2, obj3);
        }

        public static string ConcatObjectArray(object[] objects)
        {
            return string.Concat(objects);
        }

        // Exercise 35 - Write a C# Sharp program to concatenate a list of variable parameters.
        public static string ScrambleWord(string word)
        {
            var keys = new double[word.Length];
            var letters = new string[word.Length];
            var rnd = new Random();

            for (var i = 0; i < word.Length; i++)
            {
                keys[i] = rnd.NextDouble();
                letters[i] = word[i].ToString();
            }

            Array.Sort(keys, letters, 0, word.Length, Comparer.Default);
            return string.Concat(letters);
        }

        // Exercise 36 - Write a C# Sharp program to concatenate three strings and display the result.
        public static string ConcatenateStrings(string[] strings)
        {
            return string.Concat(strings);
        }

        // Exercise 38 - Write a C# Sharp program to determine whether the string "birds" is a substring of a familiar string.
        public static (bool contains, int position) CheckSubstringPosition(string mainString, string substring)
        {
            var index = mainString.IndexOf(substring);
            return (index >= 0, index + 1);
        }

        // Exercise 39 - Write a C# Sharp program to create two string objects with different values.
        public static (string s1, string s2, bool referenceEquals, bool equals) CopyStrings(string original)
        {
            var s1 = original;
            var s2 = string.Copy(original);
            return (s1, s2, object.ReferenceEquals(s1, s2), object.Equals(s1, s2));
        }

        public static (string s1, string s2, bool referenceEquals, bool equals) AssignString(string original)
        {
            var s1 = original;
            var s2 = s1;
            return (s1, s2, object.ReferenceEquals(s1, s2), object.Equals(s1, s2));
        }

        // Exercise 40 - Write a C# Sharp program to demonstrate the CopyTo method.
        public static char[] CopyToDestination(string source, int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            source.CopyTo(sourceIndex, destination, destinationIndex, count);
            return destination;
        }

        // Exercise 41 - Write a C# Sharp program to indicate whether each string in an array ends with a period (".").
        public static bool EndsWithPeriod(string input)
        {
            return input.EndsWith(".");
        }

        // Exercise 42 - Write C# Sharp program to check whether a string occurs at the end of another string.
        public static bool EndsWithCulture(string source, string value, bool ignoreCase, CultureInfo culture)
        {
            return source.EndsWith(value, ignoreCase, culture);
        }

        // Exercise 43 - Write a C# Sharp program to determine whether a string ends with a particular substring.
        public static bool EndsWithComparison(string source, string value, StringComparison comparison)
        {
            return source.EndsWith(value, comparison);
        }

        // Exercise 44 - Write a C# Sharp program to get the longest Palindromic substring from a given string.
        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;

            var n = s.Length;
            var maxLength = 1;
            var start = 0;

            for (var i = 0; i < n; i++)
            {
                for (var j = i; j < n; j++)
                {
                    var isPalindrome = true;
                    var length = j - i + 1;

                    for (var k = 0; k < length / 2; k++)
                    {
                        if (s[i + k] != s[j - k])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    if (isPalindrome && length > maxLength)
                    {
                        maxLength = length;
                        start = i;
                    }
                }
            }

            return s.Substring(start, maxLength);
        }

        // Exercise 45 - Write a C# Sharp program to reverse a given string in uppercase.
        public static string ReverseAndUppercase(string text)
        {
            return new string(text.Reverse().ToArray()).ToUpper();
        }

        // Exercise 46 - Write a C# Sharp program to remove duplicate characters from a given string.
        public static string RemoveDuplicateChars(string str)
        {
            var seen = new HashSet<char>();
            var result = new List<char>();

            foreach (var c in str)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result.Add(c);
                }
            }

            return new string(result.ToArray());
        }

        // Exercise 47 - Write a C# Sharp program to find the length of the longest substring without repeating characters in a given string.
        public static int LongestSubstringWithoutRepeating(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            var charIndexMap = new Dictionary<char, int>();
            var maxLength = 0;
            var start = 0;

            for (var end = 0; end < s.Length; end++)
            {
                var currentChar = s[end];

                if (charIndexMap.ContainsKey(currentChar) && charIndexMap[currentChar] >= start)
                {
                    start = charIndexMap[currentChar] + 1;
                }

                charIndexMap[currentChar] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }

        // Exercise 48 - Write a C# Sharp program to reverse the case (upper->lower, lower->upper) of all the characters in a given string.
        public static string ReverseCase(string text)
        {
            return string.Concat(text.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
        }

        /*Exercise 49 - Write a C# Sharp program to find the central character(s) in a given string.
        Return the middle character if the string length is odd and return two middle characters if the string length is even.*/
        public static string GetMiddleCharacters(string text)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;

            var mid = text.Length / 2;
            return text.Length % 2 == 0 ? text.Substring(mid - 1, 2) : text[mid].ToString();
        }

        // Exercise 50 - Write a C# Sharp program to find the maximum and minimum number from a given string of numbers separated by a single space.
        public static (int max, int min) FindMaxMinNumbers(string numbers)
        {
            var nums = numbers.Split(' ').Select(int.Parse).ToArray();
            return (nums.Max(), nums.Min());
        }

        // Exercise 51 - Write a C# Sharp program to check whether a given string is an “isograms” or not. Return True or False.
        public static bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count() == str.Length;
        }

        // Exercise 52 - Write a C# Sharp program to convert the first character of each word in a given string to uppercase.
        public static string CapitalizeFirstLetter(string input)
        {
            return string.Join(" ", input.Split(' ').Select(word =>
                word.Length > 0 ? char.ToUpper(word[0]) + word.Substring(1) : word));
        }

        // Exercise 53 - Write a C# Sharp program to find the position of a specified word in a given string.
        public static int FindWordPosition(string text, string word)
        {
            var words = text.Split(' ');
            return Array.IndexOf(words, word) + 1;
        }

        // Exercise 54 - Write a C# Sharp program to alternate the case of each letter in a given string. The first letter of this string must be uppercase.
        public static string AlternateCase(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            var chars = str.ToCharArray();
            var toUpper = true;

            for (var i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    chars[i] = toUpper ? char.ToUpper(chars[i]) : char.ToLower(chars[i]);
                    toUpper = !toUpper;
                }
            }

            return new string(chars);
        }

        // Exercise 55 - Write a C# Sharp program to reverse all the words of a given string with even length.
        public static string ReverseEvenLengthWords(string text)
        {
            return string.Join(" ", text.Split(' ')
                .Select(word => word.Length % 2 == 0 ? new string(word.Reverse().ToArray()) : word));
        }

        // Exercise 56 - Write a C# Sharp program to find the longest common ending between two given strings.
        public static string FindLongestCommonEnding(string str1, string str2)
        {
            var minLength = Math.Min(str1.Length, str2.Length);
            for (var i = 1; i <= minLength; i++)
            {
                var end1 = str1.Substring(str1.Length - i);
                var end2 = str2.Substring(str2.Length - i);
                if (end1 != end2)
                {
                    return str1.Substring(str1.Length - i + 1);
                }
            }
            return str1.Length <= str2.Length ? str1 : str2;
        }

        // Exercise 57 - Write a C# Sharp program that takes a string and reverses the words of three or more lengths in a string.
        public static string ReverseLongWords(string text)
        {
            return string.Join(" ", text.Split(' ')
                .Select(word => word.Length >= 3 ? new string(word.Reverse().ToArray()) : word));
        }

        // Exercise 58 - Write a C# Sharp program to check if two given strings are anagrams or not.
        public static bool AreAnagrams(string text1, string text2)
        {
            if (text1.Length != text2.Length) return false;

            var sorted1 = string.Concat(text1.ToUpper().OrderBy(c => c));
            var sorted2 = string.Concat(text2.ToUpper().OrderBy(c => c));

            return sorted1 == sorted2;
        }

        // Exercise 59 - Write a C# Sharp program to reverse a positive integer and add the reversed number to the original number.
        public static string ReverseAndAdd(int number)
        {
            if (number <= 0) return "Input a positive number.";

            var numberStr = number.ToString();
            var reversedStr = new string(numberStr.Reverse().ToArray());
            return numberStr + reversedStr;
        }

        /* Exercise 60 - Write a C# Sharp program to count the number of duplicate characters
        (case sensitive) including spaces in a given string. If there are no duplicates, return 0. */
        public static int CountDuplicateCharacters(string text)
        {
            return text.GroupBy(c => c).Count(g => g.Count() >= 2);
        }

        // Exercise 61 - Write a C# Sharp program to count a specific string (case sensitive) in given text.
        public static int CountStringOccurrences(string text, string searchStr)
        {
            if (string.IsNullOrEmpty(searchStr)) return 0;

            var count = 0;
            var index = 0;

            while ((index = text.IndexOf(searchStr, index)) != -1)
            {
                count++;
                index += searchStr.Length;
            }

            return count;
        }

        // Exercise 62 - Write a C# Sharp program that displays all the characters with their respective numbers from a string.
        public static string GetAlphabetPositions(string text)
        {
            return string.Join(" ", text.ToLower()
                .Where(char.IsLetter)
                .Select(c => (c - 'a' + 1).ToString()));
        }

        // Exercise 63 - Write a C# Sharp program that takes a string that repeats a substring. Count the number of times the substring appears.
        public static int CountSubstringRepetitions(string text)
        {
            if (string.IsNullOrEmpty(text)) return 0;

            var firstChar = text[0];
            return text.Split(firstChar).Length - 1;
        }

        // Exercise 64 - Write a C# Sharp program to find the longest abecedarian word in a given array of words.
        public static string FindLongestAbecedarian(string[] words)
        {
            if (words == null || words.Length == 0) return "Empty array!";

            return words
                .Where(word => word.SequenceEqual(word.OrderBy(c => c)))
                .OrderByDescending(word => word.Length)
                .FirstOrDefault() ?? "Empty array!";
        }

        // Exercise 65 - Write a C# Sharp program to find the century of a given year.
        public static string GetCentury(int year)
        {
            var century = (year - 1) / 100 + 1;

            if (century % 100 >= 11 && century % 100 <= 13)
                return $"{century}th century";

            var lastDigit = century % 10;
            switch (lastDigit)
            {
                case 1: return $"{century}st century";
                case 2: return $"{century}nd century";
                case 3: return $"{century}rd century";
                default: return $"{century}th century";
            }
        }

        // Exercise 66 - Write a C# Sharp program to calculate the highest frequency of the character(s) in the words of a given string.
        public static string GetHighestFrequencyCharacters(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";

            var groups = text.GroupBy(c => c)
                            .OrderByDescending(g => g.Count());

            var maxCount = groups.First().Count();

            if (maxCount == 1) return "All unique characters";

            var maxChars = groups.Where(g => g.Count() == maxCount)
                                .Select(g => g.Key.ToString());

            return string.Join(", ", maxChars);
        }

        public static string ConvertAsciiToHex(string text)
        {
            return string.Join(" ", text.Select(c => ((int)c).ToString("X2"))).ToLower();
        }


        /* Exercise 68 - Write a C# Sharp program to check whether all characters in a given string are unique. If all the characters are distinct,
        return “There is no similarity between any of the characters!” otherwise if not unique, then:. */
        public static string CheckUniqueCharacters(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "There is no similarity between any of the characters!";

            var duplicateGroups = text.Select((ch, i) => new { Character = ch, Index = i })
                                    .GroupBy(x => x.Character)
                                    .Where(g => g.Count() > 1)
                                    .ToList();

            if (!duplicateGroups.Any())
                return "There is no similarity between any of the characters!";

            var firstDuplicate = duplicateGroups.First();
            var indices = string.Join(", ", firstDuplicate.Select(x => x.Index));
            return $"Character '{firstDuplicate.Key}' appears at positions: {indices}";
        }
    }
}
