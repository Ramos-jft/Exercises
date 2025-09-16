using Exercises;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTests;

[TestClass]
public class StringOperationsTests
{
    // Exercise 1 - Write a program in C# Sharp to input a string and print it.
    [TestMethod]
    [DataRow("Welcome, w3resource", "Welcome, w3resource")]
    [DataRow("w3resource is very easy tutorial", "w3resource is very easy tutorial")]
    [DataRow("", "")]
    [DataRow("Hello World", "Hello World")]
    public void GetInputString_ShouldReturnSameString(string input, string expected)
    {
        var result = StringOperations.GetInputString(input);
        result.Should().Be(expected);
    }

    // Exercise 2 - Write a C# Sharp program to find the length of a string without using a library function.
    [TestMethod]
    [DataRow("w3resource.com", 14)]
    [DataRow("w3resource", 10)]
    [DataRow("", 0)]
    [DataRow("Hello World", 11)]
    [DataRow("C#", 2)]
    public void GetStringLength_ShouldReturnCorrectLength(string input, int expected)
    {
        var result = StringOperations.GetStringLength(input);
        result.Should().Be(expected);
    }

    // Exercise 3 - Write a C# Sharp program to separate individual characters from a string.
    [TestMethod]
    [DataRow("w3resource.com", "w 3 r e s o u r c e . c o m")]
    [DataRow("abc", "a b c")]
    [DataRow("", "")]
    [DataRow("Hello", "H e l l o")]
    public void SeparateCharacters_ShouldReturnSeparatedString(string input, string expected)
    {
        var result = StringOperations.SeparateCharacters(input);
        result.Should().Be(expected);
    }

    // Exercise 4 - Write a program in C# Sharp to print individual characters of the string in reverse order.
    [TestMethod]
    [DataRow("w3resource.com", "m o c . e c r u o s e r 3 w")]
    [DataRow("abc", "c b a")]
    [DataRow("", "")]
    [DataRow("Hello", "o l l e H")]
    public void ReverseCharacters_ShouldReturnReversedString(string input, string expected)
    {
        var result = StringOperations.ReverseCharacters(input);
        result.Should().Be(expected);
    }

    // Exercise 5 - Write a program in C# Sharp to count the total number of words in a string.
    [TestMethod]
    [DataRow("This is w3resource.com", 3)]
    [DataRow("w3resource is a tutorial", 4)]
    [DataRow("", 0)]
    [DataRow("Hello", 1)]
    [DataRow("   Multiple   spaces   ", 2)]
    [DataRow("Single", 1)]
    public void CountWords_ShouldReturnCorrectWordCount(string input, int expected)
    {
        var result = StringOperations.CountWords(input);
        result.Should().Be(expected);
    }

    // Exercise 6 - Write a program in C# Sharp to compare two strings without using a string library functions.
    [TestMethod]
    [DataRow("This is first string", "This is first string", true, 0)]
    [DataRow("This is first string", "This is second string", false, -1)]
    [DataRow("Short", "Longer string", false, -1)]
    [DataRow("Longer string", "Short", false, 1)]
    [DataRow("", "", true, 0)]
    [DataRow("Hello", "hello", false, 0)]
    public void CompareStrings_ShouldReturnCorrectResult(string str1, string str2, bool expectedEqual, int expectedLengthComparison)
    {
        var result = StringOperations.CompareStrings(str1, str2);
        result.areEqual.Should().Be(expectedEqual);
        result.lengthComparison.Should().Be(expectedLengthComparison);
    }

    // Exercise 7 - Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.
    [TestMethod]
    [DataRow("Welcome to w3resource.com", 21, 1, 3)]
    [DataRow("Hello123!", 5, 3, 1)]
    [DataRow("", 0, 0, 0)]
    [DataRow("123456", 0, 6, 0)]
    [DataRow("!@#$%", 0, 0, 5)]
    [DataRow("ABCabc", 6, 0, 0)]
    public void CountCharacters_ShouldReturnCorrectCounts(string input, int expectedAlphabets, int expectedDigits, int expectedSpecialChars)
    {
        var result = StringOperations.CountCharacters(input);
        result.alphabets.Should().Be(expectedAlphabets);
        result.digits.Should().Be(expectedDigits);
        result.specialChars.Should().Be(expectedSpecialChars);
    }

    // Exercise 8 - Write a program in C# Sharp to copy one string to another string.
    [TestMethod]
    [DataRow("This is a string to be copied.", "This is a string to be copied.", 30)]
    [DataRow("w3resource.com", "w3resource.com", 14)]
    [DataRow("", "", 0)]
    [DataRow("Hello", "Hello", 5)]
    [DataRow("123", "123", 3)]
    public void CopyString_ShouldReturnCopiedStringAndCount(string input, string expectedString, int expectedCount)
    {
        var result = StringOperations.CopyString(input);
        result.copiedString.Should().Be(expectedString);
        result.characterCount.Should().Be(expectedCount);
    }

    // Exercise 9 - Write a C# Sharp program to count the number of vowels or consonants in a string.
    [TestMethod]
    [DataRow("Welcome to w3resource.com", 9, 12)]
    [DataRow("Hello World", 3, 7)]
    [DataRow("", 0, 0)]
    [DataRow("AEIOUaeiou", 10, 0)]
    [DataRow("BCDFGbcdfg", 0, 10)]
    [DataRow("123!@#", 0, 0)]
    public void CountVowelsAndConsonants_ShouldReturnCorrectCounts(string input, int expectedVowels, int expectedConsonants)
    {
        var result = StringOperations.CountVowelsAndConsonants(input);
        result.vowels.Should().Be(expectedVowels);
        result.consonants.Should().Be(expectedConsonants);
    }

    // Exercise 10 - Write a C# Sharp program to find the maximum number of characters in a string.
    [TestMethod]
    [DataRow("Welcome to w3resource.com", 'e', 4)]
    [DataRow("Hello World", 'l', 3)]
    [DataRow("", '\0', 0)]
    [DataRow("aaaa", 'a', 4)]
    [DataRow("a b c d e", 'a', 1)]
    [DataRow("test string", 't', 3)]
    public void FindMaxCharacterFrequency_ShouldReturnCorrectCharacterAndCount(string input, char expectedChar, int expectedCount)
    {
        var result = StringOperations.FindMaxCharacterFrequency(input);
        result.character.Should().Be(expectedChar);
        result.count.Should().Be(expectedCount);
    }

    // Exercise 11 - Write a C# Sharp program to sort a string array in ascending order.
    [TestMethod]
    [DataRow("this is a string", "   aghiiinrssstt")]
    [DataRow("w3resource", "3ceeorrsuw")]
    [DataRow("", "")]
    [DataRow("hello", "ehllo")]
    [DataRow("abc", "abc")]
    [DataRow("cba", "abc")]
    public void SortStringAscending_ShouldReturnSortedString(string input, string expected)
    {
        var result = StringOperations.SortStringAscending(input);
        result.Should().Be(expected);
    }

    // Exercise 12 - Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.

}
