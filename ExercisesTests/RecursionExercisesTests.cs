using Exercises;
using FluentAssertions;

namespace ExercisesTests;

[TestClass]
public class RecursionExercisesTests
{
    // Exercise 1 - Write a program in C# Sharp to print the first n natural numbers using recursion.
    [TestMethod]
    [DataRow(10, "1 2 3 4 5 6 7 8 9 10")]
    [DataRow(1, "1")]
    [DataRow(5, "1 2 3 4 5")]
    [DataRow(0, "")]
    public void PrintNaturalNumbers_WhenCalled_ReturnsExpectedString(int n, string expected)
    {
        var result = RecursionExercises.PrintNaturalNumbers(n);
        result.Should().Be(expected);
    }

    // Exercise 2 - Write a program in C# Sharp to print numbers from n to 1 using recursion.
    [TestMethod]
    [DataRow(10, "10 9 8 7 6 5 4 3 2 1")]
    [DataRow(1, "1")]
    [DataRow(5, "5 4 3 2 1")]
    [DataRow(0, "")]
    public void PrintNumbersFromNTo1_WhenCalled_ReturnsExpectedString(int n, string expected)
    {
        var result = RecursionExercises.PrintNumbersFromNTo1(n);
        result.Should().Be(expected);
    }

    // Exercise 3 - Write a program in C# Sharp to find the sum of the first n natural numbers using recursion.
    [TestMethod]
    [DataRow(10, 55)]
    [DataRow(1, 1)]
    [DataRow(5, 15)]
    [DataRow(0, 0)]
    public void SumOfFirstNNaturalNumbers_WhenCalled_ReturnsExpectedSum(int n, int expected)
    {
        var result = RecursionExercises.SumOfFirstNNaturalNumbers(n);
        result.Should().Be(expected);
    }

    // Exercise 4 - Write a program in C# Sharp to display the individual digits of a given number using recursion.
    [TestMethod]
    [DataRow(1234, "1 2 3 4")]
    [DataRow(25, "2 5")]
    [DataRow(7, "7")]
    [DataRow(1000, "1 0 0 0")]
    public void DisplayIndividualDigits_WhenCalled_ReturnsExpectedString(int number, string expected)
    {
        var result = RecursionExercises.DisplayIndividualDigits(number);
        result.Should().Be(expected);
    }

    // Exercise 5 - Write a program in C# Sharp to count the number of digits in a number using recursion.
    [TestMethod]
    [DataRow(12345, 5)]
    [DataRow(1000, 4)]
    [DataRow(7, 1)]
    [DataRow(0, 0)]
    [DataRow(999999, 6)]
    public void CountDigits_WhenCalled_ReturnsExpectedCount(int number, int expected)
    {
        var result = RecursionExercises.CountDigits(number);
        result.Should().Be(expected);
    }

    // Exercise 6 - Write a program in C to print even or odd numbers in a given range using recursion.
    [TestMethod]
    [DataRow(2, 20, "2 4 6 8 10 12 14 16 18 20")]
    [DataRow(1, 20, "1 3 5 7 9 11 13 15 17 19")]
    [DataRow(2, 10, "2 4 6 8 10")]
    [DataRow(1, 9, "1 3 5 7 9")]
    public void PrintEvenNumbers_WhenCalled_ReturnsExpectedString(int start, int end, string expected)
    {
        var result = RecursionExercises.PrintEvenNumbers(start, end);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(1, 20, "1 3 5 7 9 11 13 15 17 19")]
    [DataRow(1, 9, "1 3 5 7 9")]
    [DataRow(3, 11, "3 5 7 9 11")]
    public void PrintOddNumbers_WhenCalled_ReturnsExpectedString(int start, int end, string expected)
    {
        var result = RecursionExercises.PrintOddNumbers(start, end);
        result.Should().Be(expected);
    }

    // Exercise 7 - Write a program in C# Sharp to check whether a number is prime or not using recursion.
    [TestMethod]
    [DataRow(37, true)]
    [DataRow(5, true)]
    [DataRow(4, false)]
    [DataRow(1, false)]
    [DataRow(0, false)]
    [DataRow(97, true)]
    [DataRow(100, false)]
    public void IsPrime_WhenCalled_ReturnsExpectedResult(int number, bool expected)
    {
        var result = RecursionExercises.IsPrime(number);
        result.Should().Be(expected);
    }

    // Exercise 8 - Write a program in C# Sharp to check whether a given string is a palindrome or not using recursion.
    [TestMethod]
    [DataRow("RADAR", true)]
    [DataRow("eye", true)]
    [DataRow("hello", false)]
    [DataRow("a", true)]
    [DataRow("", true)]
    [DataRow("racecar", true)]
    [DataRow("world", false)]
    public void IsPalindrome_WhenCalled_ReturnsExpectedResult(string text, bool expected)
    {
        var result = RecursionExercises.IsPalindrome(text);
        result.Should().Be(expected);
    }

    // Exercise 9 - Write a program in C# Sharp to find the factorial of a given number using recursion.
    [TestMethod]
    [DataRow(5, 120)]
    [DataRow(8, 40320)]
    [DataRow(1, 1)]
    [DataRow(0, 1)]
    [DataRow(3, 6)]
    [DataRow(10, 3628800)]
    public void Factorial_WhenCalled_ReturnsExpectedResult(int number, long expected)
    {
        var result = RecursionExercises.Factorial(number);
        result.Should().Be(expected);
    }

    // Exercise 10 - Write a program in C# Sharp to find the Fibonacci numbers for a series of n numbers using recursion.
    [TestMethod]
    [DataRow(10, "0 1 1 2 3 5 8 13 21 34")]
    [DataRow(1, "0")]
    [DataRow(2, "0 1")]
    [DataRow(5, "0 1 1 2 3")]
    [DataRow(0, "")]
    public void FibonacciSeries_WhenCalled_ReturnsExpectedString(int n, string expected)
    {
        var result = RecursionExercises.FibonacciSeries(n);
        result.Should().Be(expected);
    }

    // Exercise 11 - Write a program in C# Sharp to generate all possible permutations of an array using recursion.
    [TestMethod]
    public void GeneratePermutations_WhenCalledWithThreeElements_ReturnsAllPermutations()
    {
        var arr = new int[] { 1, 2, 3 };
        var expected = new List<string> { "123", "132", "213", "231", "321", "312" };

        var result = RecursionExercises.GeneratePermutations(arr);

        result.Should().BeEquivalentTo(expected);
        result.Should().HaveCount(6);
    }

    [TestMethod]
    public void GeneratePermutations_WhenCalledWithTwoElements_ReturnsAllPermutations()
    {
        var arr = new int[] { 1, 2 };
        var expected = new List<string> { "12", "21" };

        var result = RecursionExercises.GeneratePermutations(arr);

        result.Should().BeEquivalentTo(expected);
        result.Should().HaveCount(2);
    }

    [TestMethod]
    public void GeneratePermutations_WhenCalledWithOneElement_ReturnsSinglePermutation()
    {
        var arr = new int[] { 1 };
        var expected = new List<string> { "1" };

        var result = RecursionExercises.GeneratePermutations(arr);

        result.Should().BeEquivalentTo(expected);
        result.Should().HaveCount(1);
    }

    // Exercise 12 - Write a program in C# Sharp to find the LCM and GCD of two numbers using recursion.
    [TestMethod]
    [DataRow(10, 15, 5)]
    [DataRow(2, 5, 1)]
    [DataRow(21, 14, 7)]
    [DataRow(8, 12, 4)]
    [DataRow(17, 23, 1)]
    public void GCD_WhenCalled_ReturnsExpectedResult(int a, int b, int expected)
    {
        var result = RecursionExercises.GCD(a, b);
        result.Should().Be(expected);
    }

    [TestMethod]
    [DataRow(10, 15, 30)]
    [DataRow(2, 5, 10)]
    [DataRow(21, 14, 42)]
    [DataRow(8, 12, 24)]
    [DataRow(17, 23, 391)]
    public void LCM_WhenCalled_ReturnsExpectedResult(int a, int b, int expected)
    {
        var result = RecursionExercises.LCM(a, b);
        result.Should().Be(expected);
    }

    // Exercise 13 - Write a program in C# Sharp to convert a decimal number to binary using recursion.
    [TestMethod]
    [DataRow(66, "1000010")]
    [DataRow(65, "1000001")]
    [DataRow(0, "0")]
    [DataRow(1, "1")]
    [DataRow(2, "10")]
    [DataRow(10, "1010")]
    [DataRow(255, "11111111")]
    public void DecimalToBinary_WhenCalled_ReturnsExpectedString(int number, string expected)
    {
        var result = RecursionExercises.DecimalToBinary(number);
        result.Should().Be(expected);
    }

    // Exercise 14 - Write a program in C# Sharp to get the reverse of a string using recursion.
    [TestMethod]
    [DataRow("w3resource", "ecruoser3w")]
    [DataRow("W3resource", "ecruoser3W")]
    [DataRow("hello", "olleh")]
    [DataRow("a", "a")]
    [DataRow("", "")]
    [DataRow("racecar", "racecar")]
    public void ReverseString_WhenCalled_ReturnsExpectedString(string input, string expected)
    {
        var result = RecursionExercises.ReverseString(input);
        result.Should().Be(expected);
    }

    // Exercise 15 - Write a program in C# Sharp to calculate the power of any number using recursion.
    [TestMethod]
    [DataRow(5, 3, 125)]
    [DataRow(2, 6, 64)]
    [DataRow(3, 4, 81)]
    [DataRow(7, 0, 1)]
    [DataRow(10, 1, 10)]
    [DataRow(2, 10, 1024)]
    public void CalculatePower_WhenCalled_ReturnsExpectedResult(int baseNumber, int exponent, long expected)
    {
        var result = RecursionExercises.CalculatePower(baseNumber, exponent);
        result.Should().Be(expected);
    }
}
