using Exercises;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

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
    [TestMethod]
    [DataRow(new[] { "abcd", "zxcv", "mnop" }, new[] { "abcd", "mnop", "zxcv" })]
    [DataRow(new[] { "IJKL", "EFGH", "ABCD" }, new[] { "ABCD", "EFGH", "IJKL" })]
    [DataRow(new[] { "z", "a", "m" }, new[] { "a", "m", "z" })]
    [DataRow(new[] { "apple", "banana", "cherry" }, new[] { "apple", "banana", "cherry" })]
    public void SortStrings_WhenCalled_ReturnsSortedArray(string[] input, string[] expected)
    {
        var result = StringOperations.SortStrings(input);

        result.Should().Equal(expected);
    }

    // Exercise 13 - Write a program in C# Sharp to extract a substring from a given string without using the library function.
    [TestMethod]
    [DataRow("This is a test string", 5, 5, " is a")]
    [DataRow("Welcome to w3resource.com", 11, 11, " w3resource")]
    [DataRow("Hello", 1, 5, "Hello")]
    [DataRow("Test", 2, 3, "est")]
    public void ExtractSubstring_WhenCalled_ReturnsCorrectSubstring(string input, int start, int length, string expected)
    {
        var result = StringOperations.ExtractSubstring(input, start, length);

        result.Should().Be(expected);
    }

    // Exercise 14 - Write a C# Sharp program to check whether a given substring is present in the given string.
    [TestMethod]
    [DataRow("This is a Test String", "Test", true)]
    [DataRow("Welcome to w3resource.com", "w3resource", true)]
    [DataRow("Hello World", "test", false)]
    [DataRow("Programming", "gram", true)]
    [DataRow("CSharp", "Java", false)]
    public void ContainsSubstring_WhenCalled_ReturnsCorrectResult(string input, string substring, bool expected)
    {
        var result = StringOperations.ContainsSubstring(input, substring);

        result.Should().Be(expected);
    }

    // Exercise 15 - Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.
    [TestMethod]
    [DataRow("This is a string", "tHIS IS A STRING")]
    [DataRow("w3RESOURCE", "W3resource")]
    [DataRow("Hello World", "hELLO wORLD")]
    [DataRow("C# Programming", "c# pROGRAMMING")]
    [DataRow("AaBbCc", "aAbBcC")]
    public void SwapCase_WhenCalled_ReturnsStringWithSwappedCase(string input, string expected)
    {
        var result = StringOperations.SwapCase(input);

        result.Should().Be(expected);
    }

    // Exercise 16 - Write a program in C# Sharp to check the username and password.
    [TestMethod]
    [DataRow("abcd", "1234", "Password entered successfully!")]
    [DataRow("uesr", "pass", "Invalid credentials!")]
    [DataRow("abcd", "wrong", "Invalid credentials!")]
    [DataRow("wrong", "1234", "Invalid credentials!")]
    [DataRow("", "", "Invalid credentials!")]
    public void ValidateCredentials_WhenCalled_ReturnsCorrectResult(string username, string password, string expected)
    {
        var result = StringOperations.ValidateCredentials(username, password);

        result.Should().Be(expected);
    }

    // Exercise 17 - Write a program in C# Sharp to search for the position of a substring within a string.
    [TestMethod]
    [DataRow("this is a string", "is", 2)]
    [DataRow("Welcome to w3resource.com", "w3resource", 11)]
    [DataRow("hello world", "world", 6)]
    [DataRow("test string", "notfound", -1)]
    [DataRow("abc", "abc", 0)]
    public void FindSubstringPosition_WhenCalled_ReturnsCorrectPosition(string input, string substring, int expected)
    {
        var result = StringOperations.FindSubstringPosition(input, substring);

        result.Should().Be(expected);
    }

    // Exercise 18 - Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.
    [TestMethod]
    [DataRow('Z', "The character is uppercase.")]
    [DataRow('a', "The character is lowercase.")]
    [DataRow('1', "The entered character is not an alphabetic character.")]
    [DataRow('@', "The entered character is not an alphabetic character.")]
    [DataRow('M', "The character is uppercase.")]
    [DataRow('z', "The character is lowercase.")]
    public void CheckCharacterType_WhenCalled_ReturnsCorrectDescription(char input, string expected)
    {
        var result = StringOperations.CheckCharacterType(input);

        result.Should().Be(expected);
    }

    // Exercise 19 - Write a program in C# Sharp to find the number of times a substring appears in a given string.
    [TestMethod]
    [DataRow("this is original string", "str", 1)]
    [DataRow("Welcome to w3resource.com", "w3resource", 1)]
    [DataRow("test test test", "test", 3)]
    [DataRow("hello world", "xyz", 0)]
    [DataRow("aaaaa", "aa", 2)]
    [DataRow("", "test", 0)]
    public void CountSubstringOccurrences_WhenCalled_ReturnsCorrectCount(string input, string substring, int expected)
    {
        var result = StringOperations.CountSubstringOccurrences(input, substring);

        result.Should().Be(expected);
    }

    // Exercise 20 - Write a program in C# Sharp to insert a substring before the first occurrence of a string.
    [TestMethod]
    [DataRow("this is a string", "a", "test", "this is test a string")]
    [DataRow("The string is str", "string", "original", "The original string is str")]
    [DataRow("hello world", "world", "beautiful", "hello beautiful world")]
    [DataRow("test string", "notfound", "insert", "test string")]
    [DataRow("abc", "abc", "prefix", "prefix abc")]
    public void InsertBeforeFirstOccurrence_WhenCalled_ReturnsModifiedString(string input, string search, string insert, string expected)
    {
        var result = StringOperations.InsertBeforeFirstOccurrence(input, search, insert);

        result.Should().Be(expected);
    }

    // Exercise 21 - Write a C# Sharp program to compare (less than, greater than, equal to) two substrings.
    [TestMethod]
    [DataRow("computer", 2, "system", 0, 2, "less than")]
    [DataRow("system", 0, "computer", 2, 2, "greater than")]
    [DataRow("hello", 0, "hello", 0, 5, "equal to")]
    [DataRow("abc", 0, "def", 0, 3, "less than")]
    [DataRow("xyz", 0, "abc", 0, 3, "greater than")]
    public void CompareSubstrings_WhenCalled_ReturnsCorrectComparison(string str1, int start1, string str2, int start2, int length, string expected)
    {
        var result = StringOperations.CompareSubstrings(str1, start1, str2, start2, length);

        result.Should().Be(expected);
    }

    /* Exercise 22 - Write a C# Sharp program to compare two substrings that only differ in case.
    The first comparison ignores case and the second comparison considers case.*/
    [TestMethod]
    [DataRow("COMPUTER", "computer", 2, 2, "equal to", "less than")]
    [DataRow("hello", "HELLO", 0, 5, "equal to", "greater than")]
    [DataRow("abc", "ABC", 0, 3, "equal to", "greater than")]
    [DataRow("Test", "test", 0, 4, "equal to", "less than")]
    public void CompareSubstringsWithCase_WhenCalled_ReturnsCorrectComparisons(string str1, string str2, int start, int length, string expectedIgnoreCase, string expectedHonorCase)
    {
        var result = StringOperations.CompareSubstringsWithCase(str1, str2, start, length);

        Assert.AreEqual(expectedIgnoreCase, result.ignoreCaseResult);
        Assert.AreEqual(expectedHonorCase, result.honorCaseResult);
    }

    // Exercise 23 - Write a C# Sharp program to compare two substrings using different cultures and ignore the substring case.
    [TestMethod]
    [DataRow("COMPUTER", "computer", 4, 2, "equal to", "equal to")]
    public void CompareSubstringsWithCultures_WhenCalled_ReturnsEqualComparisons(string str1, string str2, int start, int length, string expectedTurkish, string expectedInvariant)
    {
        var result = StringOperations.CompareSubstringsWithCultures(str1, str2, start, length);

        Assert.AreEqual(expectedTurkish, result.turkishResult);
        Assert.AreEqual(expectedInvariant, result.invariantResult);
    }

    // Exercise 24 - Write a C# Sharp program to compare the last names of two people. It then lists them in alphabetical order.
    [TestMethod]
    [DataRow("John Peterson", "Michel Jhonson", new[] { "Michel Jhonson", "John Peterson" })]
    [DataRow("Alice Smith", "Bob Adams", new[] { "Bob Adams", "Alice Smith" })]
    [DataRow("Zoe Young", "Anna Zander", new[] { "Zoe Young", "Anna Zander" })]
    public void SortByLastName_WhenCalled_ReturnsNamesSortedByLastName(string name1, string name2, string[] expected)
    {
        var result = StringOperations.SortByLastName(name1, name2);

        CollectionAssert.AreEqual(expected, result);
    }

    /* Exercise 25 - Write a C# Sharp program to compare four sets of words by using each member of the string comparison enumeration.
    The comparisons use the conventions of the English (United States) and Sami (Upper Sweden) cultures.*/
    [TestMethod]
    [DataRow("case", "Case", "en-US")]
    [DataRow("encyclopedia", "encyclopedia", "en-US")]
    [DataRow("Archeology", "ARCHEOLOGY", "en-US")]
    public void CompareStringsWithAllComparisons_WhenCalled_ReturnsCorrectResults(string str1, string str2, string cultureName)
    {
        var culture = CultureInfo.CreateSpecificCulture(cultureName);
        var result = StringOperations.CompareStringsWithAllComparisons(str1, str2, culture);

        var comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

        for (var i = 0; i < comparisons.Length; i++)
        {
            var expected = string.Equals(str1, str2, comparisons[i]);
            Assert.AreEqual(expected, result[i], $"Failed for {comparisons[i]}");
        }
    }

    /* Exercise 26 - Write C# Sharp program to demonstrate that the Compare(String, String, Boolean)
    method is equivalent to using ToUpper or ToLower when comparing strings.*/
    [TestMethod]
    [DataRow("QRS", "qrs", true, true)]
    [DataRow("Hello", "HELLO", true, true)]
    [DataRow("Test", "test", true, true)]
    [DataRow("ABC", "XYZ", false, false)]
    public void CompareWithCaseMethods_WhenCalled_ReturnsCorrectResults(string str1, string str2, bool expectedToUpper, bool expectedIgnoreCase)
    {
        var result = StringOperations.CompareWithCaseMethods(str1, str2);

        Assert.AreEqual(expectedToUpper, result.toUpperEqual);
        Assert.AreEqual(expectedIgnoreCase, result.ignoreCaseEqual);
    }

    // Exercise 27 - Write a C# Sharp program to demonstrate how culture affects comparisons.
    [TestMethod]
    [DataRow("change", "dollar", "en-US", "<")]
    [DataRow("change", "dollar", "cs-CZ", ">")]
    [DataRow("hello", "hello", "en-US", "=")]
    [DataRow("abc", "def", "en-US", "<")]
    public void CompareWithCulture_WhenCalled_ReturnsCorrectComparisonSymbol(string str1, string str2, string cultureName, string expectedSymbol)
    {
        var result = StringOperations.CompareWithCulture(str1, str2, cultureName);

        Assert.AreEqual(expectedSymbol, result);
    }

    // Exercise 28 - Write a C# Sharp program to compare two strings in following three different ways produce three different results.
    [TestMethod]
    [DataRow("sister", "Sister", "comes before", "is the same as", "comes after")]
    public void CompareStringsThreeWays_WhenCalled_ReturnsCorrectRelations(string str1, string str2, string expectedLinguistic, string expectedCaseInsensitive, string expectedOrdinal)
    {
        var result = StringOperations.CompareStringsThreeWays(str1, str2);

        Assert.AreEqual(expectedLinguistic, result.linguistic);
        Assert.AreEqual(expectedCaseInsensitive, result.caseInsensitive);
        Assert.AreEqual(expectedOrdinal, result.ordinal);
    }

    /* Exercise 29 - Write a C# Sharp program to compare three versions of the letter "I".
    The results are affected by culture choice, whether the case is ignored, and whether an ordinal comparison is performed.*/
    [TestMethod]
    [DataRow(StringComparison.CurrentCulture, "\u0069", "\u0131", "LATIN SMALL LETTER I (U+0069)", "LATIN SMALL LETTER DOTLESS I (U+0131)", "less than")]
    [DataRow(StringComparison.CurrentCulture, "\u0069", "\u0049", "LATIN SMALL LETTER I (U+0069)", "LATIN CAPITAL LETTER I (U+0049)", "less than")]
    [DataRow(StringComparison.Ordinal, "\u0069", "\u0049", "LATIN SMALL LETTER I (U+0069)", "LATIN CAPITAL LETTER I (U+0049)", "greater than")]
    [DataRow(StringComparison.OrdinalIgnoreCase, "\u0069", "\u0131", "LATIN SMALL LETTER I (U+0069)", "LATIN SMALL LETTER DOTLESS I (U+0131)", "less than")]
    public void GetComparisonResult_WhenCalled_ReturnsCorrectResult(StringComparison comparison, string char1, string char2, string name1, string name2, string expectedRelation)
    {
        var result = StringOperations.GetComparisonResult(comparison, char1, char2, name1, name2);
        var expectedText = $"{name1} is {expectedRelation} {name2}";

        Assert.AreEqual(expectedText, result);
    }

    // Exercise 30 - Write a C# Sharp program to demonstrate that you compare ordinals and compare using different sort orders.
    [TestMethod]
    [DataRow("xyz", 1, "XYZ", 1, "greater than", "less than")]
    public void CompareCharacters_WhenCalled_ReturnsCorrectResults(string str1, int pos1, string str2, int pos2, string expectedOrdinal, string expectedCulture)
    {
        var result = StringOperations.CompareCharacters(str1, pos1, str2, pos2);

        Assert.AreEqual(expectedOrdinal, result.ordinalResult);
        Assert.AreEqual(expectedCulture, result.cultureResult);
    }

    // Exercise 31 - Write a C# Sharp program to perform an ordinal comparison of two strings that only differ in case.
    [TestMethod]
    [DataRow("JAVA", "python", "less than")]
    [DataRow("python", "JAVA", "greater than")]
    [DataRow("hello", "hello", "equal to")]
    [DataRow("ABC", "abc", "less than")]
    [DataRow("abc", "ABC", "greater than")]
    public void CompareOrdinalStrings_WhenCalled_ReturnsCorrectComparison(string str1, string str2, string expected)
    {
        var result = StringOperations.CompareOrdinalStrings(str1, str2);

        Assert.AreEqual(expected, result);
    }

    // Exercise 32 - Write a C# Sharp program to compare a given string with a set of strings.
    [TestMethod]
    [DataRow("some text", "TestClass", null, -1)]
    [DataRow("some text", 123, "Bad argument: 123 (type Int32)", null)]
    [DataRow("some text", "some text", null, 0)]
    [DataRow("some text", "Some Text", null, -1)]
    public void CompareWithObject_WhenCalled_ReturnsCorrectResult(string str, object obj, string expectedError, int? expectedResult)
    {
        var result = StringOperations.CompareWithObject(str, obj);

        Assert.AreEqual(expectedError, result.error);
        Assert.AreEqual(expectedResult, result.result);
    }

    // Exercise 33 - Write a C# Sharp program to compare the current string instance with another string.
    [TestMethod]
    [DataRow("Goodbye", "Goodbye", "The strings occur in the same position in the sort order.")]
    [DataRow("Goodbye", "Hello", "The first string follows the second in the sort order.")]
    [DataRow("Goodbye", "a small string", "The first string precedes the second in the sort order.")]
    [DataRow("Goodbye", "goodbye", "The first string precedes the second in the sort order.")]
    [DataRow("goodbye", "Goodbye", "The first string follows the second in the sort order.")]
    public void CompareToString_WhenCalled_ReturnsCorrectComparison(string str1, string str2, string expected)
    {
        var result = StringOperations.CompareToString(str1, str2);

        Assert.AreEqual(expected, result);
    }

    // Exercise 34 - Write a C# Sharp program to concatenate three objects, objects with a variable and a 3-element object array.
    [TestMethod]
    [DataRow(-123, -456, -789, "-123-456-789")]
    [DataRow("hello", " ", "world", "hello world")]
    [DataRow('a', 'b', 'c', "abc")]
    public void ConcatObjects_WhenCalled_ReturnsConcatenatedString(object obj1, object obj2, object obj3, string expected)
    {
        var result = StringOperations.ConcatObjects(obj1, obj2, obj3);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(new object[] { -123, -456, -789 }, "-123-456-789")]
    [DataRow(new object[] { "test", 123, '!' }, "test123!")]
    public void ConcatObjectArray_WhenCalled_ReturnsConcatenatedString(object[] objects, string expected)
    {
        var result = StringOperations.ConcatObjectArray(objects);

        Assert.AreEqual(expected, result);
    }

    // Exercise 35 - Write a C# Sharp program to concatenate a list of variable parameters.
    [TestMethod]
    [DataRow("abcd", 4)]
    [DataRow("efgh", 4)]
    [DataRow("ijkl", 4)]
    [DataRow("mnop", 4)]
    public void ScrambleWord_WhenCalled_ReturnsStringOfSameLength(string word, int expectedLength)
    {
        var result = StringOperations.ScrambleWord(word);

        Assert.AreEqual(expectedLength, result.Length);
    }

    [TestMethod]
    [DataRow("a", "a")]
    [DataRow("ab", 2)]
    [DataRow("abc", 3)]
    public void ScrambleWord_WhenCalled_ReturnsStringWithSameCharacters(string word, object expected)
    {
        var result = StringOperations.ScrambleWord(word);

        if (expected is string expectedString)
        {
            Assert.AreEqual(expectedString, result);
        }
        else
        {
            Assert.AreEqual(word.Length, result.Length);
            foreach (var c in word)
            {
                StringAssert.Contains(result, c.ToString());
            }
        }
    }

    // Exercise 36 - Write a C# Sharp program to concatenate three strings and display the result.
    [TestMethod]
    [DataRow(new[] { "hello ", "welcome ", "to ", "C# Sharp ", "create ", "Windows ", "client ", "applications " }, "hello welcome to C# Sharp create Windows client applications ")]
    [DataRow(new[] { "a", "b", "c" }, "abc")]
    [DataRow(new[] { "test", "123" }, "test123")]
    public void ConcatenateStrings_WhenCalled_ReturnsConcatenatedString(string[] input, string expected)
    {
        var result = StringOperations.ConcatenateStrings(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 38 - Write a C# Sharp program to determine whether the string "birds" is a substring of a familiar string.
    [TestMethod]
    [DataRow("Kill two birds with one stone", "birds", true, 10)]
    [DataRow("Hello world", "world", true, 7)]
    [DataRow("Test string", "notfound", false, 0)]
    [DataRow("", "test", false, 0)]
    public void CheckSubstringPosition_WhenCalled_ReturnsCorrectResult(string mainString, string substring, bool expectedContains, int expectedPosition)
    {
        var result = StringOperations.CheckSubstringPosition(mainString, substring);

        Assert.AreEqual(expectedContains, result.contains);
        if (expectedContains)
        {
            Assert.AreEqual(expectedPosition, result.position);
        }
    }

    // Exercise 39 - Write a C# Sharp program to create two string objects with different values.
    [TestMethod]
    [DataRow("JAVA", "JAVA", false, true)]
    public void CopyString_WhenCalled_ReturnsExpectedResults(string original, string expectedValue, bool expectedRefEquals, bool expectedEquals)
    {
        var result = StringOperations.CopyStrings(original);

        Assert.AreEqual(expectedValue, result.s2);
        Assert.AreEqual(expectedRefEquals, result.referenceEquals);
        Assert.AreEqual(expectedEquals, result.equals);
    }

    [TestMethod]
    [DataRow("JAVA", "JAVA", true, true)]
    public void AssignString_WhenCalled_ReturnsExpectedResults(string original, string expectedValue, bool expectedRefEquals, bool expectedEquals)
    {
        var result = StringOperations.AssignString(original);

        Assert.AreEqual(expectedValue, result.s2);
        Assert.AreEqual(expectedRefEquals, result.referenceEquals);
        Assert.AreEqual(expectedEquals, result.equals);
    }

    // Exercise 40 - Write a C# Sharp program to demonstrate the CopyTo method.
    [TestMethod]
    [DataRow("Python", 0, new char[] { 'w', '3', 'r', 'e', 's', 'o', 'u', 'r', 'c', 'e', ' ', 'C', 'S', 'h', 'a', 'r', 'p', ' ', 'T', 'u', 't', 'o', 'r', 'i', 'a', 'l' }, 11, 6, "w3resource Python Tutorial")]
    [DataRow("A different string", 2, new char[] { 'w', '3', 'r', 'e', 's', 'o', 'u', 'r', 'c', 'e', ' ', 'C', 'S', 'h', 'a', 'r', 'p', ' ', 'T', 'u', 't', 'o', 'r', 'i', 'a', 'l' }, 10, 9, "w3resourcedifferentutorial")]
    public void CopyToDestination_WhenCalled_ReturnsModifiedCharArray(string source, int sourceIndex, char[] destination, int destIndex, int count, string expected)
    {
        var result = StringOperations.CopyToDestination(source, sourceIndex, destination, destIndex, count);
        var resultString = new string(result);

        Assert.AreEqual(expected, resultString);
    }

    // Exercise 41 - Write a C# Sharp program to indicate whether each string in an array ends with a period (".").
    [TestMethod]
    [DataRow("Actions speak louder than words", false)]
    [DataRow("Hello!", false)]
    [DataRow("Python.", true)]
    [DataRow("PHP.", true)]
    [DataRow("random", false)]
    [DataRow("", false)]
    public void EndsWithPeriod_WhenCalled_ReturnsCorrectResult(string input, bool expected)
    {
        var result = StringOperations.EndsWithPeriod(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 42 - Write C# Sharp program to check whether a string occurs at the end of another string.
    [TestMethod]
    [DataRow("abcЙࠉ", "Å", false, "en-GB", false)]
    [DataRow("abcЙࠉ", "Å", true, "en-GB", false)]
    [DataRow("abcЙࠉ", "Å", false, "en-AU", false)]
    [DataRow("abcЙࠉ", "Å", true, "en-AU", false)]
    [DataRow("test.", ".", false, "en-US", true)]
    [DataRow("TEST.", ".", true, "en-US", true)]
    public void EndsWithCulture_WhenCalled_ReturnsCorrectResult(string source, string value, bool ignoreCase, string cultureName, bool expected)
    {
        var culture = new CultureInfo(cultureName);
        var result = StringOperations.EndsWithCulture(source, value, ignoreCase, culture);

        Assert.AreEqual(expected, result);
    }

    // Exercise 43 - Write a C# Sharp program to determine whether a string ends with a particular substring.
    [TestMethod]
    [DataRow("xyzPQR", "PQR", StringComparison.CurrentCulture, true)]
    [DataRow("xyzPQR", "PQR", StringComparison.CurrentCultureIgnoreCase, true)]
    [DataRow("xyzPQR", "PQR", StringComparison.InvariantCulture, true)]
    [DataRow("xyzPQR", "PQR", StringComparison.InvariantCultureIgnoreCase, true)]
    [DataRow("xyzPQR", "PQR", StringComparison.Ordinal, true)]
    [DataRow("xyzPQR", "PQR", StringComparison.OrdinalIgnoreCase, true)]
    [DataRow("xyzPQR", "pqr", StringComparison.Ordinal, false)]
    [DataRow("xyzPQR", "pqr", StringComparison.OrdinalIgnoreCase, true)]
    public void EndsWithComparison_WhenCalled_ReturnsCorrectResult(string source, string value, StringComparison comparison, bool expected)
    {
        var result = StringOperations.EndsWithComparison(source, value, comparison);

        Assert.AreEqual(expected, result);
    }

    // Exercise 44 - Write a C# Sharp program to get the longest Palindromic substring from a given string.
    [TestMethod]
    [DataRow("aaaaaabbbbccc", "aaaaaa")]
    [DataRow("BDEFGAABEF", "AA")]
    [DataRow("Python", "P")]
    [DataRow("Java", "ava")]
    [DataRow("abracadabra", "aca")]
    [DataRow("bananas", "anana")]
    public void LongestPalindrome_WhenCalled_ReturnsLongestPalindrome(string input, string expected)
    {
        var result = StringOperations.LongestPalindrome(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 45 - Write a C# Sharp program to reverse a given string in uppercase.
    [TestMethod]
    [DataRow("php", "PHP")]
    [DataRow("java", "AVAJ")]
    [DataRow("abcd", "DCBA")]
    [DataRow("test", "TSET")]
    [DataRow("hello", "OLLEH")]
    public void ReverseAndUppercase_WhenCalled_ReturnsReversedUppercase(string input, string expected)
    {
        var result = StringOperations.ReverseAndUppercase(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 46 - Write a C# Sharp program to remove duplicate characters from a given string.
    [TestMethod]
    [DataRow("aaaaaabbbbccc", "abc")]
    [DataRow("Python", "Python")]
    [DataRow("Java", "Jav")]
    [DataRow("aabbcc", "abc")]
    [DataRow("hello", "helo")]
    public void RemoveDuplicateChars_WhenCalled_ReturnsStringWithoutDuplicates(string input, string expected)
    {
        var result = StringOperations.RemoveDuplicateChars(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 47 - Write a C# Sharp program to find the length of the longest substring without repeating characters in a given string.
    [TestMethod]
    [DataRow("aaaaaabbbbccc", 2)]
    [DataRow("BDEFGAABEF", 6)]
    [DataRow("Python", 6)]
    [DataRow("Java", 3)]
    [DataRow("abcabcbb", 3)]
    [DataRow("bbbbb", 1)]
    [DataRow("pwwkew", 3)]
    public void LongestSubstringWithoutRepeating_WhenCalled_ReturnsCorrectLength(string input, int expected)
    {
        var result = StringOperations.LongestSubstringWithoutRepeating(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 48 - Write a C# Sharp program to reverse the case (upper->lower, lower->upper) of all the characters in a given string.
    [TestMethod]
    [DataRow("PHP", "php")]
    [DataRow("JavaScript", "jAVAsCRIPT")]
    [DataRow("Python 3.0", "pYTHON 3.0")]
    [DataRow("Hello World", "hELLO wORLD")]
    [DataRow("Test123", "tEST123")]
    public void ReverseCase_WhenCalled_ReturnsStringWithReversedCase(string input, string expected)
    {
        var result = StringOperations.ReverseCase(input);

        Assert.AreEqual(expected, result);
    }

    /*Exercise 49 - Write a C# Sharp program to find the central character(s) in a given string.
    Return the middle character if the string length is odd and return two middle characters if the string length is even.*/
    [TestMethod]
    [DataRow("Python", "th")]
    [DataRow("PHP", "H")]
    [DataRow("C#", "C#")]
    [DataRow("A", "A")]
    [DataRow("AB", "AB")]
    [DataRow("Hello", "l")]
    public void GetMiddleCharacters_WhenCalled_ReturnsCorrectMiddleCharacters(string input, string expected)
    {
        var result = StringOperations.GetMiddleCharacters(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 50 - Write a C# Sharp program to find the maximum and minimum number from a given string of numbers separated by a single space.
    [TestMethod]
    [DataRow("3 4 8 9 0 2 1", 9, 0)]
    [DataRow("-2 -1 0 4 10", 10, -2)]
    [DataRow("1 2 3", 3, 1)]
    [DataRow("5", 5, 5)]
    [DataRow("-5 -10 -3", -3, -10)]
    public void FindMaxMinNumbers_WhenCalled_ReturnsCorrectMaxMin(string input, int expectedMax, int expectedMin)
    {
        var result = StringOperations.FindMaxMinNumbers(input);

        Assert.AreEqual(expectedMax, result.max);
        Assert.AreEqual(expectedMin, result.min);
    }

    // Exercise 51 - Write a C# Sharp program to check whether a given string is an “isograms” or not. Return True or False.
    [TestMethod]
    [DataRow("Python", true)]
    [DataRow("JavaScript", false)]
    [DataRow("PHP", false)]
    [DataRow("C#", true)]
    [DataRow("isogram", true)]
    [DataRow("hello", false)]
    [DataRow("", true)]
    public void IsIsogram_WhenCalled_ReturnsCorrectResult(string input, bool expected)
    {
        var result = StringOperations.IsIsogram(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 52 - Write a C# Sharp program to convert the first character of each word in a given string to uppercase.
    [TestMethod]
    [DataRow("python exercises", "Python Exercises")]
    [DataRow("The quick brown Fox jumps over the little lazy Dog", "The Quick Brown Fox Jumps Over The Little Lazy Dog")]
    [DataRow("hello world", "Hello World")]
    [DataRow("a b c", "A B C")]
    [DataRow("", "")]
    [DataRow("test", "Test")]
    public void CapitalizeFirstLetter_WhenCalled_ReturnsCapitalizedString(string input, string expected)
    {
        var result = StringOperations.CapitalizeFirstLetter(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 53 - Write a C# Sharp program to find the position of a specified word in a given string.
    [TestMethod]
    [DataRow("The quick brown fox jumps over the lazy dog.", "fox", 4)]
    [DataRow("The quick brown fox jumps over the lazy dog.", "The", 1)]
    [DataRow("The quick brown fox jumps over the lazy dog.", "lazy", 8)]
    [DataRow("Hello world", "world", 2)]
    [DataRow("Test", "Test", 1)]
    [DataRow("One two three", "four", 0)]
    public void FindWordPosition_WhenCalled_ReturnsCorrectPosition(string text, string word, int expected)
    {
        var result = StringOperations.FindWordPosition(text, word);

        Assert.AreEqual(expected, result);
    }

    // Exercise 54 - Write a C# Sharp program to alternate the case of each letter in a given string. The first letter of this string must be uppercase.
    [TestMethod]
    [DataRow("c# Exercises", "C# eXeRcIsEs")]
    [DataRow("C# is used to develop web apps, desktop apps, mobile apps, games and much more.", "C# iS uSeD tO dEvElOp WeB aPpS, dEsKtOp ApPs, MoBiLe ApPs, GaMeS aNd MuCh MoRe.")]
    [DataRow("hello", "HeLlO")]
    [DataRow("a", "A")]
    [DataRow("ab", "Ab")]
    [DataRow("test 123", "TeSt 123")]
    public void AlternateCase_WhenCalled_ReturnsAlternatingCaseString(string input, string expected)
    {
        var result = StringOperations.AlternateCase(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 55 - Write a C# Sharp program to reverse all the words of a given string with even length.
    [TestMethod]
    [DataRow("C# Exercises", "#C Exercises")]
    [DataRow("C# is used to develop web apps , desktop apps , mobile apps , games and much more.", "#C si desu ot develop web sppa , desktop sppa , elibom sppa , games and hcum more.")]
    [DataRow("hello world", "hello world")]
    [DataRow("test", "tset")]
    [DataRow("a bc def", "a cb def")]
    [DataRow("", "")]
    public void ReverseEvenLengthWords_WhenCalled_ReturnsStringWithReversedEvenWords(string input, string expected)
    {
        var result = StringOperations.ReverseEvenLengthWords(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 56 - Write a C# Sharp program to find the longest common ending between two given strings.
    [TestMethod]
    [DataRow("running", "ruminating", "ing")]
    [DataRow("thisisatest", "testing123testing", "")]
    [DataRow("hello", "world", "")]
    [DataRow("test", "test", "test")]
    [DataRow("abc", "xyzabc", "abc")]
    [DataRow("", "test", "")]
    public void FindLongestCommonEnding_WhenCalled_ReturnsCommonEnding(string str1, string str2, string expected)
    {
        var result = StringOperations.FindLongestCommonEnding(str1, str2);

        Assert.AreEqual(expected, result);
    }

    // Exercise 57 - Write a C# Sharp program that takes a string and reverses the words of three or more lengths in a string.
    [TestMethod]
    [DataRow("The quick brown fox jumps over the lazy dog", "ehT kciuq nworb xof spmuj revo eht yzal god")]
    [DataRow("Reverse the words of three or more", "esreveR eht sdrow of eerht or erom")]
    [DataRow("ABcDef", "feDcBA")]
    [DataRow("a bc def", "a bc fed")]
    [DataRow("hello world", "olleh dlrow")]
    [DataRow("test", "tset")]
    public void ReverseLongWords_WhenCalled_ReturnsStringWithReversedLongWords(string input, string expected)
    {
        var result = StringOperations.ReverseLongWords(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 58 - Write a C# Sharp program to check if two given strings are anagrams or not.
    [TestMethod]
    [DataRow("wxyz", "zyxw", true)]
    [DataRow("pears", "spare", true)]
    [DataRow("stone", "tones", true)]
    [DataRow("cat", "rat", false)]
    [DataRow("hello", "world", false)]
    [DataRow("listen", "silent", true)]
    [DataRow("", "", true)]
    public void AreAnagrams_WhenCalled_ReturnsCorrectResult(string text1, string text2, bool expected)
    {
        var result = StringOperations.AreAnagrams(text1, text2);

        Assert.AreEqual(expected, result);
    }

    // Exercise 59 - Write a C# Sharp program to reverse a positive integer and add the reversed number to the original number.
    [TestMethod]
    [DataRow(456, "456654")]
    [DataRow(-123, "Input a positive number.")]
    [DataRow(10000, "1000000001")]
    [DataRow(123, "123321")]
    [DataRow(1, "11")]
    [DataRow(0, "Input a positive number.")]
    public void ReverseAndAdd_WhenCalled_ReturnsCorrectResult(int number, string expected)
    {
        var result = StringOperations.ReverseAndAdd(number);

        Assert.AreEqual(expected, result);
    }

    /* Exercise 60 - Write a C# Sharp program to count the number of duplicate characters
    (case sensitive) including spaces in a given string. If there are no duplicates, return 0. */
    [TestMethod]
    [DataRow("Red Green WHITE", 2)]
    [DataRow("ppqrrsttuuu", 4)]
    [DataRow("dow jones industrial average", 9)]
    [DataRow("abc", 0)]
    [DataRow("aabbcc", 3)]
    [DataRow("", 0)]
    public void CountDuplicateCharacters_WhenCalled_ReturnsCorrectCount(string input, int expected)
    {
        var result = StringOperations.CountDuplicateCharacters(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 61 - Write a C# Sharp program to count a specific string (case sensitive) in given text.
    [TestMethod]
    [DataRow("The quick brown fox jumps over the lazy dog.", "The", 1)]
    [DataRow("Red Green Black RedRed", "Red", 3)]
    [DataRow("Red Green Black", "Pink", 0)]
    [DataRow("hello hello hello", "hello", 3)]
    [DataRow("test", "test", 1)]
    [DataRow("", "search", 0)]
    [DataRow("abc", "", 0)]
    public void CountStringOccurrences_WhenCalled_ReturnsCorrectCount(string text, string searchStr, int expected)
    {
        var result = StringOperations.CountStringOccurrences(text, searchStr);

        Assert.AreEqual(expected, result);
    }

    // Exercise 62 - Write a C# Sharp program that displays all the characters with their respective numbers from a string.
    [TestMethod]
    [DataRow("C Sharp", "3 19 8 1 18 16")]
    [DataRow("The quick brown fox jumps over the lazy dog.", "20 8 5 17 21 9 3 11 2 18 15 23 14 6 15 24 10 21 13 16 19 15 22 5 18 20 8 5 12 1 26 25 4 15 7")]
    [DataRow("HTML Tutorial", "8 20 13 12 20 21 20 15 18 9 1 12")]
    [DataRow("abc", "1 2 3")]
    [DataRow("", "")]
    [DataRow("123", "")]
    public void GetAlphabetPositions_WhenCalled_ReturnsCorrectPositions(string input, string expected)
    {
        var result = StringOperations.GetAlphabetPositions(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 63 - Write a C# Sharp program that takes a string that repeats a substring. Count the number of times the substring appears.
    [TestMethod]
    [DataRow("aaaaaa", 6)]
    [DataRow("abababab", 4)]
    [DataRow("abcdabcdabcd", 3)]
    [DataRow("a", 1)]
    [DataRow("", 0)]
    [DataRow("test", 2)]
    public void CountSubstringRepetitions_WhenCalled_ReturnsCorrectCount(string input, int expected)
    {
        var result = StringOperations.CountSubstringRepetitions(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 64 - Write a C# Sharp program to find the longest abecedarian word in a given array of words.
    [TestMethod]
    [DataRow(new[] { "abc", "abcd", "abcdef", "pqrstuv" }, "pqrstuv")]
    [DataRow(new[] { "abc", "abcd", "abcdef", "pqrs" }, "abcdef")]
    [DataRow(new string[] { }, "Empty array!")]
    [DataRow(new[] { "a", "b", "c" }, "a")]
    [DataRow(new[] { "zxy", "abc", "def" }, "abc")]
    [DataRow(new[] { "abcd", "acbd", "abdc" }, "abcd")]
    public void FindLongestAbecedarian_WhenCalled_ReturnsCorrectWord(string[] input, string expected)
    {
        var result = StringOperations.FindLongestAbecedarian(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 65 - Write a C# Sharp program to find the century of a given year.
    [TestMethod]
    [DataRow(1435, "15th century")]
    [DataRow(1567, "16th century")]
    [DataRow(1921, "20th century")]
    [DataRow(2014, "21st century")]
    [DataRow(2000, "20th century")]
    [DataRow(1, "1st century")]
    [DataRow(100, "1st century")]
    [DataRow(101, "2nd century")]
    [DataRow(2024, "21st century")]
    public void GetCentury_WhenCalled_ReturnsCorrectCentury(int year, string expected)
    {
        var result = StringOperations.GetCentury(year);

        Assert.AreEqual(expected, result);
    }

    // Exercise 66 - Write a C# Sharp program to calculate the highest frequency of the character(s) in the words of a given string.
    [TestMethod]
    [DataRow("aaaaaa", "a")]
    [DataRow("Century of the said year", " ")]
    [DataRow("CPP Exercises", "P, e, s")]
    [DataRow("abc", "All unique characters")]
    [DataRow("", "")]
    [DataRow("aabbcc", "a, b, c")]
    public void GetHighestFrequencyCharacters_WhenCalled_ReturnsCorrectCharacters(string input, string expected)
    {
        var result = StringOperations.GetHighestFrequencyCharacters(input);

        Assert.AreEqual(expected, result);
    }

    // Exercise 67 - Write a C# Sharp program that converts ASCII characters to hexadecimal values.
    [TestMethod]
    [DataRow("Python", "50 79 74 68 6f 6e")]
    [DataRow("Century of the year", "43 65 6e 74 75 72 79 20 6f 66 20 74 68 65 20 79 65 61 72")]
    [DataRow("CPP Exercises", "43 50 50 20 45 78 65 72 63 69 73 65 73")]
    [DataRow("", "")]
    [DataRow("a", "61")]
    [DataRow("AB", "41 42")]
    public void ConvertAsciiToHex_WhenCalled_ReturnsCorrectHexString(string input, string expected)
    {
        var result = StringOperations.ConvertAsciiToHex(input);

        Assert.AreEqual(expected, result);
    }

    /* Exercise 68 - Write a C# Sharp program to check whether all characters in a given string are unique. If all the characters are distinct,
    return “There is no similarity between any of the characters!” otherwise if not unique, then:. */
    [TestMethod]
    [DataRow("", "There is no similarity between any of the characters!")]
    [DataRow(".", "There is no similarity between any of the characters!")]
    [DataRow("cppCPP", "Character 'p' appears at positions: 1, 2")]
    [DataRow("PQR RQP", "Character 'P' appears at positions: 0, 6")]
    [DataRow("C Sharp", "There is no similarity between any of the characters!")]
    [DataRow("hello", "Character 'l' appears at positions: 2, 3")]
    public void CheckUniqueCharacters_WhenCalled_ReturnsCorrectMessage(string input, string expected)
    {
        var result = StringOperations.CheckUniqueCharacters(input);

        Assert.AreEqual(expected, result);
    }
}
