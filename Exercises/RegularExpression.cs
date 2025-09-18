using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercises
{
    public class RegularExpression
    {
        /* Exercise 1 - Write a C# Sharp program to check whether a given string is a valid Hex code or not.
           Return true if this string is a valid code otherwise false. */
        public static bool IsValidHexCode(string code)
        {
            return Regex.IsMatch(code, @"^#[0-9A-Fa-f]{6}$");
        }

        // Exercise 2 - Write a C# Sharp program to calculate the average word length in a given string. Round the average length up to two decimal places.
        public static double AverageWordLength(string text)
        {
            var words = Regex.Matches(text, @"\b[A-Za-z]+\b").Cast<Match>().Select(m => m.Value);
            var average = words.Average(w => w.Length);
            return System.Math.Round(average, 2);
        }

        public static bool CanFormPalindrome(string text)
        {
            var charCounts = text.GroupBy(c => c).Select(g => g.Count() % 2);
            return charCounts.Count(c => c == 1) <= 1;
        }

        // Exercise 4 - Write a C# Sharp program to validate a password of length 7 to 16 characters with the following guidelines:
        /* Length between 7 and 16 characters.
           At least one lowercase letter (a-z).
           At least one uppercase letter (A-Z).
           At least one digit (0-9).
           Supported special characters: ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , . */
        public static bool IsValidPassword(string password)
        {
            if (password.Length < 7 || password.Length > 16) return false;
            if (!Regex.IsMatch(password, "[a-z]")) return false;
            if (!Regex.IsMatch(password, "[A-Z]")) return false;
            if (!Regex.IsMatch(password, @"\d")) return false;
            if (!Regex.IsMatch(password, @"[!@#$%^&*()+=_\-{}\[\]:;""'?<>,.]")) return false;
            return !Regex.IsMatch(password, @"[^a-zA-Z0-9!@#$%^&*()+=_\-{}\[\]:;""'?<>,.]");
        }

        // Exercise 5 - Write a C# Sharp program to check whether two given strings contain the same character pattern.
        public static bool HaveSamePattern(string text1, string text2)
        {
            if (text1.Length != text2.Length) return false;

            for (var i = 0; i < text1.Length; i++)
            {
                if (text1.IndexOf(text1[i]) != text2.IndexOf(text2[i]))
                    return false;
            }

            return true;
        }

        // Exercise 6 - Write a C# Sharp program to check for repeated occurrences of words in a given string.
        public static int CountRepeatedWords(string text)
        {
            var regex = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.IgnoreCase);
            return regex.Matches(text).Count;
        }

        /* Exercise 7 - Write a C# Sharp program to check whether a given string represents a currency
           value or has the correct format to represent a currency value. */
        public static bool IsCurrencyValue(string value)
        {
            var nfi = new CultureInfo("en-US", false).NumberFormat;
            var pattern = @"^\s*[" + Regex.Escape(nfi.PositiveSign + nfi.NegativeSign) + @"]?\s?";
            pattern += Regex.Escape(nfi.CurrencySymbol) + @"?\s?";
            pattern += @"(\d*" + Regex.Escape(nfi.CurrencyDecimalSeparator) + @"?";
            pattern += @"\d{" + nfi.CurrencyDecimalDigits + @"}?){1}$";

            return Regex.IsMatch(value, pattern);
        }

        /* Exercise 8 - Write a C# Sharp program to remove special characters from given text.
           Return the updated string which allows alphanumeric characters, spaces, underscores _ and dashes - . */
        public static string RemoveSpecialCharacters(string text)
        {
            return Regex.Replace(text, @"[^0-9A-Za-z _-]", "");
        }

        /* Exercise 9 - Write a C# Sharp program to locate the word “C#” in a given string. If the word "C#" is found,
           return “C# document found.” otherwise return “Sorry no C# document!”. */
        public static string FindCSharpDocument(string text)
        {
            return Regex.IsMatch(text, @"C#", RegexOptions.IgnoreCase)
                ? "C# document found."
                : "Sorry no C# document!";
        }
    }
}
