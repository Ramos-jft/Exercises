using Exercises;
using FluentAssertions;
using System.ComponentModel;

namespace ExercisesTests;

[TestClass]
public class LinqExercisesTests
{
    // Exercise 1 - Write a program in C# Sharp to show how the three parts of a query operation execute.
    [TestMethod]
    public void Exercise1_ReturnsEvenNumbers()
    {
        var result = LinqExercises.Exercise1();
        result.Should().Be("0 2 4 6 8");
    }

    // Exercise 2 - Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
    [TestMethod]
    [DataRow("1 3 6 9 10")]
    public void Exercise2_ReturnsPositiveNumbersInRange(string expected)
    {
        var result = LinqExercises.Exercise2();
        result.Should().Be(expected);
    }

    // Exercise 3 - Write a program in C# Sharp to find the number of an array and the square of each number.
    [TestMethod]
    public void Exercise3_ReturnsNumbersAndSquaresAbove20()
    {
        var result = LinqExercises.Exercise3();
        var expected = new List<string>
        {
            "{ Number = 9, SqrNo = 81 }",
            "{ Number = 8, SqrNo = 64 }",
            "{ Number = 6, SqrNo = 36 }",
            "{ Number = 5, SqrNo = 25 }"
        };

        result.Should().Equal(expected);
    }

    // Exercise 4 - Write a program in C# Sharp to display the number and frequency of a given number from an array.
    [TestMethod]
    public void Exercise4_ReturnsNumberFrequency()
    {
        var result = LinqExercises.Exercise4();
        var expected = new List<string>
        {
            "Number 5 appears 3 times",
            "Number 9 appears 2 times",
            "Number 1 appears 1 times",
            "Number 2 appears 2 times",
            "Number 3 appears 2 times",
            "Number 7 appears 3 times",
            "Number 6 appears 3 times",
            "Number 8 appears 1 times",
            "Number 4 appears 1 times"
        };

        result.Should().Equal(expected);
    }

    // Exercise 5 -  Write a program in C# Sharp to display the characters and frequency of each character in a given string.
    [TestMethod]
    [DataRow("apple", new string[] {
        "Character a: 1 times",
        "Character p: 2 times",
        "Character l: 1 times",
        "Character e: 1 times"
    })]
    [DataRow("w3resource", new string[] {
        "Character w: 1 times",
        "Character 3: 1 times",
        "Character r: 2 times",
        "Character e: 2 times",
        "Character s: 1 times",
        "Character o: 1 times",
        "Character u: 1 times",
        "Character c: 1 times"
    })]
    public void Exercise5_ReturnsCharacterFrequency(string input, string[] expected)
    {
        var result = LinqExercises.Exercise5(input);
        result.Should().Equal(expected);
    }

    // Exercise 6 - Write a program in C# Sharp to display the name of the days of the week.
    [TestMethod]
    public void Exercise6_ReturnsDaysOfWeek()
    {
        var result = LinqExercises.Exercise6();
        var expected = new List<string>
        {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        result.Should().Equal(expected);
    }

    // Exercise 7 - Write a program in C# Sharp to display numbers, multiplication of numbers with frequency and the frequency of a number in an array.
    [TestMethod]
    public void Exercise7_ReturnsNumbersWithFrequencyAndProduct()
    {
        var result = LinqExercises.Exercise7();
        var expected = new List<string>
        {
            "5\t15\t\t\t3",
            "1\t1\t\t\t1",
            "9\t9\t\t\t1",
            "2\t4\t\t\t2",
            "3\t6\t\t\t2",
            "7\t14\t\t\t2",
            "4\t8\t\t\t2",
            "6\t12\t\t\t2",
            "8\t8\t\t\t1"
        };

        result.Should().Equal(expected);
    }

    // Exercise 8 - Write a program in C# Sharp to find a string that starts and ends with a specific character.
    [TestMethod]
    [DataRow("A", "M", new string[] { "AMSTERDAM" })]
    [DataRow("N", "I", new string[] { "NAIROBI", "NEW DELHI" })]
    public void Exercise8_ReturnsCitiesStartingAndEndingWithChars(string startChar, string endChar, string[] expected)
    {
        var result = LinqExercises.Exercise8(startChar, endChar);
        result.Should().Equal(expected);
    }

    // Exercise 9 - Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
    [TestMethod]
    public void Exercise9_ReturnsNumbersGreaterThan80()
    {
        var result = LinqExercises.Exercise9();
        var expected = new List<int> { 200, 740, 230, 482, 95 };

        result.Should().Equal(expected);
    }

    // Exercise 10 - Write a program in C# Sharp to accept list members through the keyboard and display them more than a specific value.
    [TestMethod]
    [DataRow(new int[] { 10, 48, 52, 94, 63 }, 59, new int[] { 94, 63 })]
    [DataRow(new int[] { 10, 20, 30, 40, 50 }, 20, new int[] { 30, 40, 50 })]
    public void Exercise10_ReturnsNumbersGreaterThanThreshold(int[] input, int threshold, int[] expected)
    {
        var result = LinqExercises.Exercise10(input.ToList(), threshold);
        result.Should().Equal(expected);
    }

    // Exercise 11 - Write a program in C# Sharp to display the top n-th records.
    [TestMethod]
    [DataRow(new int[] { 5, 7, 13, 24, 6, 9, 8, 7 }, 3, new int[] { 24, 13, 9 })]
    [DataRow(new int[] { 5, 7, 13, 24, 6, 9, 8, 7 }, 5, new int[] { 24, 13, 9, 8, 7 })]
    public void Exercise11_ReturnsTopNRecords(int[] input, int n, int[] expected)
    {
        var result = LinqExercises.Exercise11(input.ToList(), n);
        result.Should().Equal(expected);
    }

    // Exercise 12 - Write a program in C# Sharp to find uppercase words in a string.
    [TestMethod]
    [DataRow("this IS a STRING", new string[] { "IS", "STRING" })]
    public void Exercise12_ReturnsUppercaseWords(string input, string[] expected)
    {
        var result = LinqExercises.Exercise12(input);
        result.Should().Equal(expected);
    }

    // Exercise 13 - Write a program in C# Sharp to convert a string array to a string.
    [TestMethod]
    [DataRow(new string[] { "cat", "dog", "rat" }, "cat, dog, rat")]
    [DataRow(new string[] { "Cat", "Dog", "Cow", "Tiger" }, "Cat, Dog, Cow, Tiger")]
    public void Exercise13_ConvertsStringArrayToString(string[] input, string expected)
    {
        var result = LinqExercises.Exercise13(input);
        result.Should().Be(expected);
    }

    // Exercise 14 - Write a program in C# Sharp to find the n-th maximum grade point achieved by the students from the list of students.
    [TestMethod]
    [DataRow(3, new string[] {
        "Id : 7, Name : David, achieved Grade Point : 750",
        "Id : 10, Name : Jenny, achieved Grade Point : 750"
    })]
    public void Exercise14_ReturnsNthMaximumGradePoint(int rank, string[] expected)
    {
        var result = LinqExercises.Exercise14(rank);
        result.Should().Equal(expected);
    }

    // Exercise 15 - Write a program in C# Sharp to count file extensions and group it using LINQ.
    [TestMethod]
    public void Exercise15_CountsFileExtensions()
    {
        var result = LinqExercises.Exercise15();
        var expected = new List<string>
        {
            "1 File(s) with .frx Extension",
            "3 File(s) with .txt Extension",
            "1 File(s) with .dbf Extension",
            "2 File(s) with .pdf Extension",
            "1 File(s) with .frt Extension",
            "1 File(s) with .xml Extension"
        };

        result.Should().BeEquivalentTo(expected);
    }

    // Exercise 16 - Write a program in C# Sharp to calculate size of file using LINQ.
    [TestMethod]
    public void Exercise16_CalculatesAverageFileSize()
    {
        var tempFiles = new string[3];
        for (int i = 0; i < 3; i++)
        {
            tempFiles[i] = Path.GetTempFileName();
            File.WriteAllText(tempFiles[i], new string('x', 1024 * 1024 * (i + 1)));
        }

        var result = LinqExercises.Exercise16(tempFiles);
        result.Should().Be("The Average file size is 2 MB");

        foreach (var file in tempFiles)
        {
            File.Delete(file);
        }
    }

    // Exercise 17 - Write a program in C# Sharp to remove items from list using remove function by passing the object.
    [TestMethod]
    public void Exercise17_RemovesItemFromList()
    {
        var result = LinqExercises.Exercise17();
        var expected = new List<string>
        {
            "Char: m",
            "Char: n",
            "Char: p",
            "Char: q"
        };

        result.Should().Equal(expected);
    }

    // Exercise 18 - Write a program in C# Sharp to remove items from list by creating an object internally by filtering.
    [TestMethod]
    public void Exercise18_RemovesItemFromListByFiltering()
    {
        var result = LinqExercises.Exercise18();
        var expected = new List<string>
        {
            "Char: m",
            "Char: n",
            "Char: o",
            "Char: q"
        };

        result.Should().Equal(expected);
    }

    // Exercise 19 - Write a program in C# Sharp to remove items from list by passing filters.
    [TestMethod]
    public void Exercise19_RemovesItemsFromListByFilter()
    {
        var result = LinqExercises.Exercise19();
        var expected = new List<string>
        {
            "Char: m",
            "Char: n",
            "Char: o",
            "Char: p"
        };

        result.Should().Equal(expected);
    }

    // Exercise 20 - Write a program in C# Sharp to remove items from list by passing the item index.
    [TestMethod]
    public void Exercise20_RemovesItemByIndex()
    {
        var result = LinqExercises.Exercise20();
        var expected = new List<string>
        {
            "Char: m",
            "Char: n",
            "Char: o",
            "Char: q"
        };

        result.Should().Equal(expected);
    }

    // Exercise 21 - Write a program in C# Sharp to remove a range of items from a list by passing the start index and number of elements to remove.
    [TestMethod]
    public void Exercise21_RemovesRangeOfItems()
    {
        var result = LinqExercises.Exercise21();
        var expected = new List<string>
        {
            "Char: m",
            "Char: q"
        };

        result.Should().Equal(expected);
    }

    // Exercise 22 - Write a program in C# Sharp to find the strings for a specific minimum length.
    [TestMethod]
    [DataRow(new string[] { "this", "is", "a", "string" }, 5, new string[] { "Item: string" })]
    [DataRow(new string[] { "Welcome", "to", "W3resource" }, 10, new string[] { "Item: W3resource" })]
    public void Exercise22_FindsStringsWithMinimumLength(string[] input, int minLength, string[] expected)
    {
        var result = LinqExercises.Exercise22(input, minLength);
        result.Should().Equal(expected);
    }

    // Exercise 23 - Write a program in C# Sharp to generate a cartesian product of two sets.
    [TestMethod]
    public void Exercise23_GeneratesCartesianProduct()
    {
        char[] charset1 = { 'X', 'Y', 'Z' };
        int[] numset1 = { 1, 2, 3, 4 };

        var result = LinqExercises.Exercise23(charset1, numset1);
        var expected = new List<string>
        {
            "{ letterList = X, numberList = 1 }",
            "{ letterList = X, numberList = 2 }",
            "{ letterList = X, numberList = 3 }",
            "{ letterList = X, numberList = 4 }",
            "{ letterList = Y, numberList = 1 }",
            "{ letterList = Y, numberList = 2 }",
            "{ letterList = Y, numberList = 3 }",
            "{ letterList = Y, numberList = 4 }",
            "{ letterList = Z, numberList = 1 }",
            "{ letterList = Z, numberList = 2 }",
            "{ letterList = Z, numberList = 3 }",
            "{ letterList = Z, numberList = 4 }"
        };

        result.Should().Equal(expected);
    }

    // Exercise 24 - Write a program in C# Sharp to generate a cartesian product of three sets.
    [TestMethod]
    public void Exercise24_GeneratesCartesianProductOfThreeSets()
    {
        char[] charset1 = { 'X', 'Y', 'Z' };
        int[] numset1 = { 1, 2, 3 };
        string[] colorset1 = { "Green", "Orange" };

        var result = LinqExercises.Exercise24(charset1, numset1, colorset1);
        var expected = new List<string>
        {
            "{ letter = X, number = 1, colour = Green }",
            "{ letter = X, number = 1, colour = Orange }",
            "{ letter = X, number = 2, colour = Green }",
            "{ letter = X, number = 2, colour = Orange }",
            "{ letter = X, number = 3, colour = Green }",
            "{ letter = X, number = 3, colour = Orange }",
            "{ letter = Y, number = 1, colour = Green }",
            "{ letter = Y, number = 1, colour = Orange }",
            "{ letter = Y, number = 2, colour = Green }",
            "{ letter = Y, number = 2, colour = Orange }",
            "{ letter = Y, number = 3, colour = Green }",
            "{ letter = Y, number = 3, colour = Orange }",
            "{ letter = Z, number = 1, colour = Green }",
            "{ letter = Z, number = 1, colour = Orange }",
            "{ letter = Z, number = 2, colour = Green }",
            "{ letter = Z, number = 2, colour = Orange }",
            "{ letter = Z, number = 3, colour = Green }",
            "{ letter = Z, number = 3, colour = Orange }"
        };

        result.Should().Equal(expected);
    }

    // Exercise 25 - Write a program in C# Sharp to generate an Inner Join between two data sets.
    [TestMethod]
    public void Exercise25_GeneratesInnerJoin()
    {
        var result = LinqExercises.Exercise25();
        var expected = new List<string>
        {
            "1\t\tBiscuit\t\t458",
            "2\t\tChocolate\t\t650",
            "3\t\tButter\t\t800",
            "3\t\tButter\t\t900",
            "3\t\tButter\t\t900",
            "4\t\tBrade\t\t700",
            "4\t\tBrade\t\t650"
        };

        result.Should().Equal(expected);
    }

    // Exercise 26 - Write a program in C# Sharp to generate a Left Join between two data sets.
    [TestMethod]
    public void Exercise26_GeneratesLeftJoin()
    {
        var result = LinqExercises.Exercise26();
        var expected = new List<string>
        {
            "1\t\tBiscuit\t\t458",
            "2\t\tChocolate\t\t650",
            "3\t\tButter\t\t800",
            "3\t\tButter\t\t900",
            "3\t\tButter\t\t900",
            "4\t\tBrade\t\t700",
            "4\t\tBrade\t\t650",
            "5\t\tHoney\t\t0"
        };

        result.Should().Equal(expected);
    }

    // Exercise 27 - Write a program in C# Sharp to generate a Right Outer Join between two data sets.
    [TestMethod]
    public void Exercise27_GeneratesRightJoin()
    {
        var result = LinqExercises.Exercise27();
        var expected = new List<string>
        {
            "3\t\tButter\t\t800",
            "5\t\tHoney\t\t650",
            "3\t\tButter\t\t900",
            "4\t\tBrade\t\t700",
            "3\t\tButter\t\t900",
            "4\t\tBrade\t\t650",
            "1\t\tBiscuit\t\t458"
        };

        result.Should().Equal(expected);
    }

    /* Exercise 28 - Write a program in C# Sharp to display the list of items in the array according to the length of the
       string then by name in ascending order. */
    [TestMethod]
    public void Exercise28_OrdersByLengthThenByName()
    {
        var result = LinqExercises.Exercise28();
        var expected = new List<string>
        {
            "ROME",
            "PARIS",
            "LONDON",
            "ZURICH",
            "NAIROBI",
            "ABU DHABI",
            "AMSTERDAM",
            "NEW DELHI",
            "CALIFORNIA"
        };

        result.Should().Equal(expected);
    }

    // Exercise 29 - Write a program in C# Sharp to split a collection of strings into some groups.
    [TestMethod]
    public void Exercise29_SplitsIntoGroups()
    {
        var result = LinqExercises.Exercise29();
        var expected = new List<string>
        {
            "ROME;  LONDON;  NAIROBI",
            "-- here is a group of cities --",
            "CALIFORNIA;  ZURICH;  NEW DELHI",
            "-- here is a group of cities --",
            "AMSTERDAM;  ABU DHABI;  PARIS",
            "-- here is a group of cities --",
            "NEW YORK",
            "-- here is a group of cities --"
        };

        result.Should().Equal(expected);
    }

    // Exercise 30 - Write a program in C# Sharp to arrange the distinct elements in the list in ascending order.
    [TestMethod]
    public void Exercise30_ArrangesDistinctElementsAscending()
    {
        var result = LinqExercises.Exercise30();
        var expected = new List<string>
        {
            "Biscuit",
            "Brade",
            "Butter",
            "Honey"
        };

        result.Should().Equal(expected);
    }
}
