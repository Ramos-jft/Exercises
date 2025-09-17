using Exercises;
using FluentAssertions;

namespace ExercisesTests;

[TestClass]
public class FunctionExercisesTests
{
    // Exercise 1 - Write a program in C# Sharp to create a user defined function.
    [TestMethod]
    public void Welcome_ShouldPrintWelcomeMessage()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);

        FunctionExercises.Welcome();

        sw.ToString().Should().Be("Welcome Friends!" + Environment.NewLine);
    }

    [TestMethod]
    public void HaveAnice_ShouldPrintNiceDayMessage()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);

        FunctionExercises.HaveAnice();

        sw.ToString().Should().Be("Have a nice day!" + Environment.NewLine);
    }

    // Exercise 2 - Write a program in C# Sharp to create a user defined function with parameters.
    [TestMethod]
    [DataRow("John", "Welcome friend John !")]
    [DataRow("Mary", "Welcome friend Mary !")]
    [DataRow("", "Welcome friend  !")]
    public void Welcome_ShouldPrintPersonalizedWelcomeMessage(string name, string expected)
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);

        FunctionExercises.Welcome(name);

        sw.ToString().Should().Be(expected + Environment.NewLine);
    }

    [TestMethod]
    public void HaveNiceDay_ShouldPrintNiceDayMessage()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);

        FunctionExercises.HaveNiceDay();

        sw.ToString().Should().Be("Have a nice day!" + Environment.NewLine);
    }

    // Exercise 3 - Write a program in C# Sharp to create a function for the sum of two numbers.
    [TestMethod]
    [DataRow(15, 16, 31)]
    [DataRow(25, 50, 75)]
    [DataRow(-5, 10, 5)]
    [DataRow(0, 0, 0)]
    public void SumTwoNumbers_ShouldReturnCorrectSum(int num1, int num2, int expected)
    {
        var result = FunctionExercises.SumTwoNumbers(num1, num2);
        result.Should().Be(expected);
    }

    // Exercise 4 - Write a program in C# Sharp to create a function to input a string and count the number of spaces within the string.
    [TestMethod]
    [DataRow("This is a test string.", 4)]
    [DataRow("w3resource is a tutorial", 3)]
    [DataRow("NoSpacesHere", 0)]
    [DataRow("  Multiple  Spaces  ", 6)]
    [DataRow("", 0)]
    public void CountSpaces_ShouldReturnCorrectSpaceCount(string input, int expected)
    {
        var result = FunctionExercises.CountSpaces(input);
        result.Should().Be(expected);
    }

    // Exercise 5 - Write a program in C# Sharp to calculate the sum of elements in an array.
    [TestMethod]
    [DataRow(new int[] { 5, 7, 3, 2, 9 }, 26)]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 15)]
    [DataRow(new int[] { 10, 20, 30 }, 60)]
    [DataRow(new int[] { -1, -2, -3 }, -6)]
    [DataRow(new int[] { 0 }, 0)]
    public void SumArrayElements_ShouldReturnCorrectSum(int[] array, int expected)
    {
        var result = FunctionExercises.SumArrayElements(array);
        result.Should().Be(expected);
    }

    // Exercises 6 - Write a program in C# Sharp to create a function to swap two integer numbers.
    [TestMethod]
    [DataRow(5, 6, 6, 5)]
    [DataRow(45, 65, 65, 45)]
    [DataRow(-10, 20, 20, -10)]
    [DataRow(0, 100, 100, 0)]
    [DataRow(7, 7, 7, 7)]
    public void SwapNumbers_ShouldSwapValuesCorrectly(int num1, int num2, int expectedNum1, int expectedNum2)
    {
        var a = num1;
        var b = num2;

        FunctionExercises.SwapNumbers(ref a, ref b);

        a.Should().Be(expectedNum1);
        b.Should().Be(expectedNum2);
    }

    // Exercise 7 - Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
    [TestMethod]
    [DataRow(3, 2, 9)]
    [DataRow(8, 2, 64)]
    [DataRow(5, 3, 125)]
    [DataRow(2, 0, 1)]
    [DataRow(7, 1, 7)]
    public void CalculatePower_ShouldReturnCorrectResult(int num, int exp, int expected)
    {
        var result = FunctionExercises.CalculatePower(num, exp);
        result.Should().Be(expected);
    }

    // Exercise 8 - Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.
    [TestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 3)]
    [DataRow(5, 5)]
    [DataRow(6, 8)]
    [DataRow(7, 13)]
    [DataRow(8, 21)]
    [DataRow(9, 34)]
    public void Fibonacci_ShouldReturnCorrectNumber(int n, int expected)
    {
        var result = FunctionExercises.Fibonacci(n);
        result.Should().Be(expected);
    }

    // Exercise 9 - Write a program in C# Sharp to create a function to check whether a number is prime or not.
    [TestMethod]
    [DataRow(31, true)]
    [DataRow(23, true)]
    [DataRow(4, false)]
    [DataRow(1, false)]
    [DataRow(0, false)]
    [DataRow(97, true)]
    [DataRow(100, false)]
    [DataRow(2, true)]
    public void IsPrime_ShouldReturnCorrectResult(int number, bool expected)
    {
        var result = FunctionExercises.IsPrime(number);
        result.Should().Be(expected);
    }

    // Exercise 10 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
    [TestMethod]
    [DataRow(1234, 10)]
    [DataRow(25, 7)]
    [DataRow(999, 27)]
    [DataRow(1000, 1)]
    [DataRow(0, 0)]
    [DataRow(7, 7)]
    [DataRow(123456789, 45)]
    public void SumDigits_ShouldReturnCorrectSum(int number, int expected)
    {
        var result = FunctionExercises.SumDigits(number);
        result.Should().Be(expected);
    }

    // Exercise 11 - Write a program in C# Sharp to create a recursive function to find the factorial of a given number.
    [TestMethod]
    [DataRow(5, 120)]
    [DataRow(0, 1)]
    [DataRow(1, 1)]
    [DataRow(3, 6)]
    [DataRow(4, 24)]
    [DataRow(6, 720)]
    public void Factorial_ShouldReturnCorrectResult(int number, long expected)
    {
        var result = FunctionExercises.Factorial(number);
        result.Should().Be(expected);
    }

    // Exercise 12 - Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
    [TestMethod]
    [DataRow(10, 55)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 3)]
    [DataRow(5, 5)]
    [DataRow(6, 8)]
    public void FibonacciRecursive_ShouldReturnCorrectResult(int term, int expected)
    {
        var result = FunctionExercises.FibonacciRecursive(term);
        result.Should().Be(expected);
    }
}
