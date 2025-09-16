
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

    }
}
