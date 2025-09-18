using Exercises;
using FluentAssertions;

namespace ExercisesTests;

[TestClass]
public class RegularExpressionTests
{
    /* Exercise 1 - Write a C# Sharp program to check whether a given string is a valid Hex code or not.
       Return true if this string is a valid code otherwise false. */
    [TestMethod]
    [DataRow("#CD5C5C", true)]
    [DataRow("#f08080", true)]
    [DataRow("#E9967A", true)]
    [DataRow("#EFFA07A", false)]
    [DataRow("#123456", true)]
    [DataRow("CD5C5C", false)]
    [DataRow("#12345", false)]
    [DataRow("#GHIJKL", false)]
    public void IsValidHexCode_WhenCalled_ReturnsExpectedResult(string code, bool expected)
    {
        var result = RegularExpression.IsValidHexCode(code);
        result.Should().Be(expected);
    }

    // Exercise 2 - Write a C# Sharp program to calculate the average word length in a given string. Round the average length up to two decimal places.
    [TestMethod]
    [DataRow("CPP Exercises.", 6.0)]
    [DataRow("C# syntax is highly expressive, yet it is also simple and easy to learn.", 4.0)]
    [DataRow("C# is an elegant and type-safe object-oriented language", 4.5)]
    [DataRow("Hello World", 5.0)]
    [DataRow("A B C D E", 1.0)]
    public void AverageWordLength_WhenCalled_ReturnsExpectedResult(string text, double expected)
    {
        var result = RegularExpression.AverageWordLength(text);
        result.Should().Be(expected);
    }

    /* Exercise 3 - Write a C# Sharp program to check whether a given string of characters can be transformed into a palindrome.
       Return true otherwise false. */
    [TestMethod]
    [DataRow("amamd", true)]
    [DataRow("pamamd", false)]
    [DataRow("ferre", true)]
    [DataRow("a", true)]
    [DataRow("aa", true)]
    [DataRow("abc", false)]
    [DataRow("aabbcc", true)]
    public void CanFormPalindrome_WhenCalled_ReturnsExpectedResult(string text, bool expected)
    {
        var result = RegularExpression.CanFormPalindrome(text);
        result.Should().Be(expected);
    }

    // Exercise 4 - Write a C# Sharp program to validate a password of length 7 to 16 characters with the following guidelines:
    /* Length between 7 and 16 characters.
       At least one lowercase letter (a-z).
       At least one uppercase letter (A-Z).
       At least one digit (0-9).
       Supported special characters: ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , . */
    [TestMethod]
    [DataRow("Suuu$21g@", true)]
    [DataRow("W#1g@", false)]
    [DataRow("a&&g@", false)]
    [DataRow("sdsd723#$Amid", true)]
    [DataRow("sdsd723#$Amidkiouy", false)]
    [DataRow("Short1@", true)]
    [DataRow("NoSpecialChar123", false)]
    [DataRow("NOLOWER123@", false)]
    public void IsValidPassword_WhenCalled_ReturnsExpectedResult(string password, bool expected)
    {
        var result = RegularExpression.IsValidPassword(password);
        result.Should().Be(expected);
    }

    // Exercise 5 - Write a C# Sharp program to check whether two given strings contain the same character pattern.
    [TestMethod]
    [DataRow("AACC", "PPRR", true)]
    [DataRow("FFGG", "ADAD", false)]
    [DataRow("ABCD", "WXYZ", true)]
    [DataRow("AABB", "CCDD", true)]
    [DataRow("ABC", "XYZ", true)]
    [DataRow("ABC", "XY", false)]
    [DataRow("ABA", "XYX", true)]
    public void HaveSamePattern_WhenCalled_ReturnsExpectedResult(string text1, string text2, bool expected)
    {
        var result = RegularExpression.HaveSamePattern(text1, text2);
        result.Should().Be(expected);
    }

    // Exercise 6 - Write a C# Sharp program to check for repeated occurrences of words in a given string.
    [TestMethod]
    [DataRow("C# C# syntax is highly expressive, yet it is is also simple and easy to to learn learn.", 3)]
    [DataRow("Red Green Green Black Black Green.", 2)]
    [DataRow("Hello Hello world", 1)]
    [DataRow("No repeated words here", 0)]
    [DataRow("Test test test test", 2)]
    public void CountRepeatedWords_WhenCalled_ReturnsExpectedCount(string text, int expected)
    {
        var result = RegularExpression.CountRepeatedWords(text);
        result.Should().Be(expected);
    }

    /* Exercise 7 - Write a C# Sharp program to check whether a given string represents a currency
       value or has the correct format to represent a currency value. */
    [TestMethod]
    [DataRow("-42", true)]
    [DataRow("19.99", true)]
    [DataRow("0.001", false)]
    [DataRow("100 USD", false)]
    [DataRow(".34", true)]
    [DataRow("0.34", true)]
    [DataRow("1,052.21", false)]
    [DataRow("$10.62", true)]
    [DataRow("+1.43", true)]
    [DataRow("-$0.23", true)]
    public void IsCurrencyValue_WhenCalled_ReturnsExpectedResult(string value, bool expected)
    {
        var result = RegularExpression.IsCurrencyValue(value);
        result.Should().Be(expected);
    }

    /* Exercise 8 - Write a C# Sharp program to remove special characters from given text.
       Return the updated string which allows alphanumeric characters, spaces, underscores _ and dashes - . */
    [TestMethod]
    [DataRow("AA@%^&CC", "AACC")]
    [DataRow("Python", "Python")]
    [DataRow("w3resource.com", "w3resourcecom")]
    [DataRow("Hello_World-123", "Hello_World-123")]
    [DataRow("Test with spaces", "Test with spaces")]
    [DataRow("Special!@#$%Chars", "SpecialChars")]
    public void RemoveSpecialCharacters_WhenCalled_ReturnsExpectedString(string text, string expected)
    {
        var result = RegularExpression.RemoveSpecialCharacters(text);
        result.Should().Be(expected);
    }

    /* Exercise 9 - Write a C# Sharp program to locate the word “C#” in a given string. If the word "C#" is found,
       return “C# document found.” otherwise return “Sorry no C# document!”. */
    [TestMethod]
    [DataRow("C# Exercises", "C# document found.")]
    [DataRow("Python Exercises", "Sorry no C# document!")]
    [DataRow("Tutorial on c#", "C# document found.")]
    [DataRow("CSharp Programming", "Sorry no C# document!")]
    [DataRow("Learning C# Basics", "C# document found.")]
    [DataRow("Java Tutorial", "Sorry no C# document!")]
    public void FindCSharpDocument_WhenCalled_ReturnsExpectedResult(string text, string expected)
    {
        var result = RegularExpression.FindCSharpDocument(text);
        result.Should().Be(expected);
    }
}
