using Exercises;
using FluentAssertions;

namespace ExercisesTests;

[TestClass]
public class ForLoopTests
{
    // Exercise 1 - Write a program in C# Sharp to display the first 10 natural numbers.
    [TestMethod]
    public void GetFirst10NaturalNumbers_ReturnsCorrectSequence()
    {
        // Arrange
        var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        var result = ForLoop.GetFirst10NaturalNumbers();

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 2 - Write a C# Sharp program to find the sum of the first 10 natural numbers.
    [TestMethod]
    public void SumFirst10NaturalNumbers_Returns55()
    {
        // Arrange
        var expected = 55;

        // Act
        var result = ForLoop.SumFirst10NaturalNumbers();

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 3 - Write a C# Sharp program that displays the sum of n natural numbers.
    [TestMethod]
    public void SumNaturalNumbers_When7_Returns28()
    {
        // Arrange
        var n = 7;
        var expected = 28;

        // Act
        var result = ForLoop.SumNaturalNumbers(n);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void SumNaturalNumbers_When5_Returns15()
    {
        // Arrange
        var n = 5;
        var expected = 15;

        // Act
        var result = ForLoop.SumNaturalNumbers(n);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 4 - Write a C# Sharp program to read 10 numbers and find their average and sum.
    [TestMethod]
    public void CalculateSumAndAverage_With10Numbers_ReturnsCorrectSumAndAverage()
    {
        // Arrange
        var numbers = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        var expectedSum = 20;
        var expectedAverage = 2.0;

        // Act
        var result = ForLoop.CalculateSumAndAverage(numbers);

        // Assert
        result.Sum.Should().Be(expectedSum);
        result.Average.Should().Be(expectedAverage);
    }

    [TestMethod]
    public void CalculateSumAndAverage_WithMixedNumbers_ReturnsCorrectSumAndAverage()
    {
        // Arrange
        var numbers = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        var expectedSum = 110;
        var expectedAverage = 11.0;

        // Act
        var result = ForLoop.CalculateSumAndAverage(numbers);

        // Assert
        result.Sum.Should().Be(expectedSum);
        result.Average.Should().Be(expectedAverage);
    }

    // Exercise 5 - Write a C# Sharp program to display the cube of an integer up to given number.
    [TestMethod]
    public void GetCubes_When5_ReturnsCorrectCubes()
    {
        // Arrange
        var n = 5;
        var expected = new List<int> { 1, 8, 27, 64, 125 };

        // Act
        var result = ForLoop.GetCubes(n);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GetCubes_When3_ReturnsCorrectCubes()
    {
        // Arrange
        var n = 3;
        var expected = new List<int> { 1, 8, 27 };

        // Act
        var result = ForLoop.GetCubes(n);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 6 - Write a program in C# Sharp to display the multiplication table of a given integer.
    [TestMethod]
    public void GetMultiplicationTable_When15_ReturnsCorrectTable()
    {
        // Arrange
        var number = 15;
        var expected = new List<int> { 15, 30, 45, 60, 75, 90, 105, 120, 135, 150 };

        // Act
        var result = ForLoop.GetMultiplicationTable(number);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GetMultiplicationTable_When5_ReturnsCorrectTable()
    {
        // Arrange
        var number = 5;
        var expected = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

        // Act
        var result = ForLoop.GetMultiplicationTable(number);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 7 - Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
    [TestMethod]
    public void GetVerticalMultiplicationTable_When8_ReturnsCorrectTable()
    {
        // Arrange
        var n = 8;
        var expected = new List<List<int>>
        {
            new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 },
            new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 },
            new List<int> { 3, 6, 9, 12, 15, 18, 21, 24 },
            new List<int> { 4, 8, 12, 16, 20, 24, 28, 32 },
            new List<int> { 5, 10, 15, 20, 25, 30, 35, 40 },
            new List<int> { 6, 12, 18, 24, 30, 36, 42, 48 },
            new List<int> { 7, 14, 21, 28, 35, 42, 49, 56 },
            new List<int> { 8, 16, 24, 32, 40, 48, 56, 64 },
            new List<int> { 9, 18, 27, 36, 45, 54, 63, 72 },
            new List<int> { 10, 20, 30, 40, 50, 60, 70, 80 }
        };

        // Act
        var result = ForLoop.GetVerticalMultiplicationTable(n);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [TestMethod]
    public void GetVerticalMultiplicationTable_When5_ReturnsCorrectTable()
    {
        // Arrange
        var n = 5;
        var expected = new List<List<int>>
        {
            new List<int> { 1, 2, 3, 4, 5 },
            new List<int> { 2, 4, 6, 8, 10 },
            new List<int> { 3, 6, 9, 12, 15 },
            new List<int> { 4, 8, 12, 16, 20 },
            new List<int> { 5, 10, 15, 20, 25 },
            new List<int> { 6, 12, 18, 24, 30 },
            new List<int> { 7, 14, 21, 28, 35 },
            new List<int> { 8, 16, 24, 32, 40 },
            new List<int> { 9, 18, 27, 36, 45 },
            new List<int> { 10, 20, 30, 40, 50 }
        };

        // Act
        var result = ForLoop.GetVerticalMultiplicationTable(n);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    // Exercise 8 - Write a C# Sharp program to display the n terms of odd natural numbers and their sums.
    [TestMethod]
    public void GetOddNumbersAndSum_When10_ReturnsCorrectOddNumbersAndSum()
    {
        // Arrange
        var n = 10;
        var expectedNumbers = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        var expectedSum = 100;

        // Act
        var result = ForLoop.GetOddNumbersAndSum(n);

        // Assert
        result.OddNumbers.Should().Equal(expectedNumbers);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void GetOddNumbersAndSum_When5_ReturnsCorrectOddNumbersAndSum()
    {
        // Arrange
        var n = 5;
        var expectedNumbers = new List<int> { 1, 3, 5, 7, 9 };
        var expectedSum = 25;

        // Act
        var result = ForLoop.GetOddNumbersAndSum(n);

        // Assert
        result.OddNumbers.Should().Equal(expectedNumbers);
        result.Sum.Should().Be(expectedSum);
    }

    // Exercise 9 - Write a program in C# Sharp to display a right angle triangle with an asterisk.
    [TestMethod]
    public void GenerateRightAngleTriangle_When4Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 4;
        var expected = new List<string> { "*", "**", "***", "****" };

        // Act
        var result = ForLoop.GenerateRightAngleTriangle(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateRightAngleTriangle_When10Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 10;
        var expected = new List<string>
        {
            "*", "**", "***", "****", "*****",
            "******", "*******", "********", "*********", "**********"
        };

        // Act
        var result = ForLoop.GenerateRightAngleTriangle(rows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 10 - Write a program in C# Sharp to display a pattern like a right angle triangle with a number.
    [TestMethod]
    public void GenerateNumberTriangle_When4Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 4;
        var expected = new List<string> { "1", "12", "123", "1234" };

        // Act
        var result = ForLoop.GenerateNumberTriangle(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateNumberTriangle_When10Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 10;
        var expected = new List<string>
        {
            "1", "12", "123", "1234", "12345",
            "123456", "1234567", "12345678", "123456789", "12345678910"
        };

        // Act
        var result = ForLoop.GenerateNumberTriangle(rows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 11 - Write a program in C# Sharp to make such a pattern like a right angle triangle with a number which repeats a number in a row.
    [TestMethod]
    public void GenerateRepeatingNumberTriangle_When4Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 4;
        var expected = new List<string> { "1", "22", "333", "4444" };

        // Act
        var result = ForLoop.GenerateRepeatingNumberTriangle(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateRepeatingNumberTriangle_When7Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 7;
        var expected = new List<string>
        {
            "1", "22", "333", "4444", "55555", "666666", "7777777"
        };

        // Act
        var result = ForLoop.GenerateRepeatingNumberTriangle(rows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 12 - Write a C# Sharp program to make such a pattern like a right angle triangle with the number increased by 1.
    [TestMethod]
    public void GenerateIncreasingNumberTriangle_When4Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 4;
        var expected = new List<List<int>>
        {
            new List<int> { 1 },
            new List<int> { 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9, 10 }
        };

        // Act
        var result = ForLoop.GenerateIncreasingNumberTriangle(rows);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [TestMethod]
    public void GenerateIncreasingNumberTriangle_When5Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 5;
        var expected = new List<List<int>>
        {
            new List<int> { 1 },
            new List<int> { 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9, 10 },
            new List<int> { 11, 12, 13, 14, 15 }
        };

        // Act
        var result = ForLoop.GenerateIncreasingNumberTriangle(rows);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    // Exercise 13 - Write a program in C# Sharp to make such a pattern like a pyramid with numbers increasing by 1.
    [TestMethod]
    public void GenerateNumberPyramid_When4Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 4;
        var expected = new List<string>
        {
            "   1",
            "  2 3",
            " 4 5 6",
            "7 8 9 10"
        };

        // Act
        var result = ForLoop.GenerateNumberPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateNumberPyramid_When5Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 5;
        var expected = new List<string>
        {
            "    1",
            "   2 3",
            "  4 5 6",
            " 7 8 9 10",
            "11 12 13 14 15"
        };

        // Act
        var result = ForLoop.GenerateNumberPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 14 - Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
    [TestMethod]
    public void GenerateAsteriskPyramid_When4Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 4;
        var expected = new List<string>
        {
            "   *",
            "  * *",
            " * * *",
            "* * * *"
        };

        // Act
        var result = ForLoop.GenerateAsteriskPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateAsteriskPyramid_When6Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 6;
        var expected = new List<string>
        {
            "     *",
            "    * *",
            "   * * *",
            "  * * * *",
            " * * * * *",
            "* * * * * *"
        };

        // Act
        var result = ForLoop.GenerateAsteriskPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 15 - Write a C# Sharp program to calculate the factorial of a given number.
    [TestMethod]
    public void CalculateFactorial_When5_Returns120()
    {
        // Arrange
        var number = 5;
        var expected = 120;

        // Act
        var result = ForLoop.CalculateFactorial(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateFactorial_When6_Returns720()
    {
        // Arrange
        var number = 6;
        var expected = 720;

        // Act
        var result = ForLoop.CalculateFactorial(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateFactorial_When0_Returns1()
    {
        // Arrange
        var number = 0;
        var expected = 1;

        // Act
        var result = ForLoop.CalculateFactorial(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateFactorial_When1_Returns1()
    {
        // Arrange
        var number = 1;
        var expected = 1;

        // Act
        var result = ForLoop.CalculateFactorial(number);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 16 - Write a program in C# Sharp to display the n terms of even natural number and their sum.
    [TestMethod]
    public void GetEvenNumbersAndSum_When5_ReturnsCorrectEvenNumbersAndSum()
    {
        // Arrange
        var n = 5;
        var expectedNumbers = new List<int> { 2, 4, 6, 8, 10 };
        var expectedSum = 30;

        // Act
        var result = ForLoop.GetEvenNumbersAndSum(n);

        // Assert
        result.EvenNumbers.Should().Equal(expectedNumbers);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void GetEvenNumbersAndSum_When10_ReturnsCorrectEvenNumbersAndSum()
    {
        // Arrange
        var n = 10;
        var expectedNumbers = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        var expectedSum = 110;

        // Act
        var result = ForLoop.GetEvenNumbersAndSum(n);

        // Assert
        result.EvenNumbers.Should().Equal(expectedNumbers);
        result.Sum.Should().Be(expectedSum);
    }

    // Exercise 17 - Write a program in C# Sharp to make such a pattern like a pyramid with a number which will repeat the number in the same row.
    [TestMethod]
    public void GenerateRepeatingNumberPyramid_When4Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 4;
        var expected = new List<string>
        {
            "   1",
            "  2 2",
            " 3 3 3",
            "4 4 4 4"
        };

        // Act
        var result = ForLoop.GenerateRepeatingNumberPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateRepeatingNumberPyramid_When8Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 8;
        var expected = new List<string>
        {
            "       1",
            "      2 2",
            "     3 3 3",
            "    4 4 4 4",
            "   5 5 5 5 5",
            "  6 6 6 6 6 6",
            " 7 7 7 7 7 7 7",
            "8 8 8 8 8 8 8 8"
        };

        // Act
        var result = ForLoop.GenerateRepeatingNumberPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 18 - Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........].
    [TestMethod]
    public void CalculateSeriesSum_WhenX2AndTerms5_ReturnsCorrectSum()
    {
        // Arrange
        var x = 2.0;
        var n = 5;
        var expected = -0.41587301587301587;

        // Act
        var result = ForLoop.CalculateSeriesSum(x, n);

        // Assert
        result.Should().BeApproximately(expected, 0.000001);
    }

    [TestMethod]
    public void CalculateSeriesSum_WhenX5AndTerms2_ReturnsCorrectSum()
    {
        // Arrange
        var x = 5.0;
        var n = 2;
        var expected = -11.5;

        // Act
        var result = ForLoop.CalculateSeriesSum(x, n);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateSeriesSum_WhenX1AndTerms1_Returns1()
    {
        // Arrange
        var x = 1.0;
        var n = 1;
        var expected = 1.0;

        // Act
        var result = ForLoop.CalculateSeriesSum(x, n);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateSeriesSum_WhenX3AndTerms3_ReturnsCorrectSum()
    {
        // Arrange
        var x = 3.0;
        var n = 3;
        var expected = -0.125;

        // Act
        var result = ForLoop.CalculateSeriesSum(x, n);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 19 - Write a program in C# Sharp to display the n terms of harmonic series and their sum.
    [TestMethod]
    public void CalculateHarmonicSeriesSum_When5Terms_ReturnsCorrectSum()
    {
        // Arrange
        var n = 5;
        var expected = 2.283333333333333;

        // Act
        var result = ForLoop.CalculateHarmonicSeriesSum(n);

        // Assert
        result.Should().BeApproximately(expected, 0.000001);
    }

    [TestMethod]
    public void CalculateHarmonicSeriesSum_When6Terms_ReturnsCorrectSum()
    {
        // Arrange
        var n = 6;
        var expected = 2.45;

        // Act
        var result = ForLoop.CalculateHarmonicSeriesSum(n);

        // Assert
        result.Should().BeApproximately(expected, 0.000001);
    }

    [TestMethod]
    public void CalculateHarmonicSeriesSum_When1Term_Returns1()
    {
        // Arrange
        var n = 1;
        var expected = 1.0;

        // Act
        var result = ForLoop.CalculateHarmonicSeriesSum(n);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateHarmonicSeriesSum_When10Terms_ReturnsCorrectSum()
    {
        // Arrange
        var n = 10;
        var expected = 2.9289682539682538;

        // Act
        var result = ForLoop.CalculateHarmonicSeriesSum(n);

        // Assert
        result.Should().BeApproximately(expected, 0.000001);
    }

    // Exercise 20 - Write a program in C# Sharp to display the pattern like pyramid using an asterisk and each row contain an odd number of an asterisks.
    [TestMethod]
    public void GenerateOddAsteriskPyramid_When3Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 3;
        var expected = new List<string>
        {
            "  *",
            " ***",
            "*****"
        };

        // Act
        var result = ForLoop.GenerateOddAsteriskPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateOddAsteriskPyramid_When10Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 10;
        var expected = new List<string>
        {
            "         *",
            "        ***",
            "       *****",
            "      *******",
            "     *********",
            "    ***********",
            "   *************",
            "  ***************",
            " *****************",
            "*******************"
        };

        // Act
        var result = ForLoop.GenerateOddAsteriskPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 21 - Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
    [TestMethod]
    public void CalculateNineSeries_When5Terms_ReturnsCorrectSeriesAndSum()
    {
        // Arrange
        var n = 5;
        var expectedSeries = new List<long> { 9, 99, 999, 9999, 99999 };
        var expectedSum = 111105L;

        // Act
        var result = ForLoop.CalculateNineSeries(n);

        // Assert
        result.Series.Should().Equal(expectedSeries);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateNineSeries_When3Terms_ReturnsCorrectSeriesAndSum()
    {
        // Arrange
        var n = 3;
        var expectedSeries = new List<long> { 9, 99, 999 };
        var expectedSum = 1107L;

        // Act
        var result = ForLoop.CalculateNineSeries(n);

        // Assert
        result.Series.Should().Equal(expectedSeries);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateNineSeries_When1Term_ReturnsCorrectSeriesAndSum()
    {
        // Arrange
        var n = 1;
        var expectedSeries = new List<long> { 9 };
        var expectedSum = 9L;

        // Act
        var result = ForLoop.CalculateNineSeries(n);

        // Assert
        result.Series.Should().Equal(expectedSeries);
        result.Sum.Should().Be(expectedSum);
    }

    // Exercise 22 - Write a program in C# Sharp to print Floyd's Triangle.
    [TestMethod]
    public void GenerateFloydsTriangle_When5Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 5;
        var expected = new List<string>
        {
            "1",
            "01",
            "101",
            "0101",
            "10101"
        };

        // Act
        var result = ForLoop.GenerateFloydsTriangle(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateFloydsTriangle_When8Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 8;
        var expected = new List<string>
        {
            "1",
            "01",
            "101",
            "0101",
            "10101",
            "010101",
            "1010101",
            "01010101"
        };

        // Act
        var result = ForLoop.GenerateFloydsTriangle(rows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 23 - Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....].
    [TestMethod]
    public void CalculateExponentialSeries_WhenX3AndTerms5_ReturnsCorrectSum()
    {
        // Arrange
        var x = 3.0;
        var n = 5;
        var expected = 16.375;

        // Act
        var result = ForLoop.CalculateExponentialSeries(x, n);

        // Assert
        result.Should().BeApproximately(expected, 0.000001);
    }

    [TestMethod]
    public void CalculateExponentialSeries_WhenX5AndTerms5_ReturnsCorrectSum()
    {
        // Arrange
        var x = 5.0;
        var n = 5;
        var expected = 65.375;

        // Act
        var result = ForLoop.CalculateExponentialSeries(x, n);

        // Assert
        result.Should().BeApproximately(expected, 0.000001);
    }

    [TestMethod]
    public void CalculateExponentialSeries_WhenX1AndTerms1_Returns1()
    {
        // Arrange
        var x = 1.0;
        var n = 1;
        var expected = 1.0;

        // Act
        var result = ForLoop.CalculateExponentialSeries(x, n);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateExponentialSeries_WhenX2AndTerms3_ReturnsCorrectSum()
    {
        // Arrange
        var x = 2.0;
        var n = 3;
        var expected = 5.0;

        // Act
        var result = ForLoop.CalculateExponentialSeries(x, n);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 24 - Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....].
    [TestMethod]
    public void CalculateAlternatingPowerSeries_WhenX2AndTerms5_Returns410()
    {
        // Arrange
        var x = 2.0;
        var n = 5;
        var expected = 410.0;

        // Act
        var result = ForLoop.CalculateAlternatingPowerSeries(x, n);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateAlternatingPowerSeries_WhenX1AndTerms3_ReturnsCorrectSum()
    {
        // Arrange
        var x = 1.0;
        var n = 3;
        var expected = 1.0 - 1.0 + 1.0; // 1 - 1^3 + 1^5 = 1 - 1 + 1 = 1

        // Act
        var result = ForLoop.CalculateAlternatingPowerSeries(x, n);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateAlternatingPowerSeries_WhenX3AndTerms2_ReturnsCorrectSum()
    {
        // Arrange
        var x = 3.0;
        var n = 2;
        var expected = 3.0 - Math.Pow(3, 3); // 3 - 27 = -24

        // Act
        var result = ForLoop.CalculateAlternatingPowerSeries(x, n);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void CalculateAlternatingPowerSeries_WhenX0AndTerms5_Returns0()
    {
        // Arrange
        var x = 0.0;
        var n = 5;
        var expected = 0.0;

        // Act
        var result = ForLoop.CalculateAlternatingPowerSeries(x, n);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 25 - Write a C# Sharp program that displays the n terms of square natural numbers and their sum.
    [TestMethod]
    public void CalculateSquareNumbers_When5Terms_ReturnsCorrectSquaresAndSum()
    {
        // Arrange
        var n = 5;
        var expectedSquares = new List<int> { 1, 4, 9, 16, 25 };
        var expectedSum = 55;

        // Act
        var result = ForLoop.CalculateSquareNumbers(n);

        // Assert
        result.Squares.Should().Equal(expectedSquares);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateSquareNumbers_When10Terms_ReturnsCorrectSquaresAndSum()
    {
        // Arrange
        var n = 10;
        var expectedSquares = new List<int> { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 };
        var expectedSum = 385;

        // Act
        var result = ForLoop.CalculateSquareNumbers(n);

        // Assert
        result.Squares.Should().Equal(expectedSquares);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateSquareNumbers_When1Term_ReturnsCorrectSquaresAndSum()
    {
        // Arrange
        var n = 1;
        var expectedSquares = new List<int> { 1 };
        var expectedSum = 1;

        // Act
        var result = ForLoop.CalculateSquareNumbers(n);

        // Assert
        result.Squares.Should().Equal(expectedSquares);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateSquareNumbers_When3Terms_ReturnsCorrectSquaresAndSum()
    {
        // Arrange
        var n = 3;
        var expectedSquares = new List<int> { 1, 4, 9 };
        var expectedSum = 14;

        // Act
        var result = ForLoop.CalculateSquareNumbers(n);

        // Assert
        result.Squares.Should().Equal(expectedSquares);
        result.Sum.Should().Be(expectedSum);
    }

    // Exercise 26 - Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
    [TestMethod]
    public void CalculateOnesSeries_When5Terms_ReturnsCorrectSumAndTerms()
    {
        // Arrange
        var n = 5;
        var expectedTerms = new List<long> { 1, 11, 111, 1111, 11111 };
        var expectedSum = 12345L;

        // Act
        var result = ForLoop.CalculateOnesSeries(n);

        // Assert
        result.Terms.Should().Equal(expectedTerms);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateOnesSeries_When6Terms_ReturnsCorrectSumAndTerms()
    {
        // Arrange
        var n = 6;
        var expectedTerms = new List<long> { 1, 11, 111, 1111, 11111, 111111 };
        var expectedSum = 123456L;

        // Act
        var result = ForLoop.CalculateOnesSeries(n);

        // Assert
        result.Terms.Should().Equal(expectedTerms);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateOnesSeries_When3Terms_ReturnsCorrectSumAndTerms()
    {
        // Arrange
        var n = 3;
        var expectedTerms = new List<long> { 1, 11, 111 };
        var expectedSum = 123L;

        // Act
        var result = ForLoop.CalculateOnesSeries(n);

        // Assert
        result.Terms.Should().Equal(expectedTerms);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateOnesSeries_When1Term_ReturnsCorrectSumAndTerms()
    {
        // Arrange
        var n = 1;
        var expectedTerms = new List<long> { 1 };
        var expectedSum = 1L;

        // Act
        var result = ForLoop.CalculateOnesSeries(n);

        // Assert
        result.Terms.Should().Equal(expectedTerms);
        result.Sum.Should().Be(expectedSum);
    }

    // Exercise 27 - Write a C# Sharp program for checking if a number is a perfect number.
    [TestMethod]
    public void CheckPerfectNumber_When56_ReturnsNotPerfect()
    {
        // Arrange
        var number = 56;
        var expectedDivisors = new List<int> { 1, 2, 4, 7, 8, 14, 28 };
        var expectedSum = 64;
        var expectedIsPerfect = false;

        // Act
        var result = ForLoop.CheckPerfectNumber(number);

        // Assert
        result.Divisors.Should().Equal(expectedDivisors);
        result.Sum.Should().Be(expectedSum);
        result.IsPerfect.Should().Be(expectedIsPerfect);
    }

    [TestMethod]
    public void CheckPerfectNumber_When20_ReturnsNotPerfect()
    {
        // Arrange
        var number = 20;
        var expectedDivisors = new List<int> { 1, 2, 4, 5, 10 };
        var expectedSum = 22;
        var expectedIsPerfect = false;

        // Act
        var result = ForLoop.CheckPerfectNumber(number);

        // Assert
        result.Divisors.Should().Equal(expectedDivisors);
        result.Sum.Should().Be(expectedSum);
        result.IsPerfect.Should().Be(expectedIsPerfect);
    }

    [TestMethod]
    public void CheckPerfectNumber_When6_ReturnsPerfect()
    {
        // Arrange
        var number = 6;
        var expectedDivisors = new List<int> { 1, 2, 3 };
        var expectedSum = 6;
        var expectedIsPerfect = true;

        // Act
        var result = ForLoop.CheckPerfectNumber(number);

        // Assert
        result.Divisors.Should().Equal(expectedDivisors);
        result.Sum.Should().Be(expectedSum);
        result.IsPerfect.Should().Be(expectedIsPerfect);
    }

    [TestMethod]
    public void CheckPerfectNumber_When28_ReturnsPerfect()
    {
        // Arrange
        var number = 28;
        var expectedDivisors = new List<int> { 1, 2, 4, 7, 14 };
        var expectedSum = 28;
        var expectedIsPerfect = true;

        // Act
        var result = ForLoop.CheckPerfectNumber(number);

        // Assert
        result.Divisors.Should().Equal(expectedDivisors);
        result.Sum.Should().Be(expectedSum);
        result.IsPerfect.Should().Be(expectedIsPerfect);
    }

    // Exercise 28 - Write a C# Sharp program to find the ‘perfect’ numbers within a given number range.
    [TestMethod]
    public void FindPerfectNumbersInRange_When1To50_Returns6And28()
    {
        // Arrange
        var start = 1;
        var end = 50;
        var expected = new List<int> { 6, 28 };

        // Act
        var result = ForLoop.FindPerfectNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindPerfectNumbersInRange_When1To20_Returns6()
    {
        // Arrange
        var start = 1;
        var end = 20;
        var expected = new List<int> { 6 };

        // Act
        var result = ForLoop.FindPerfectNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindPerfectNumbersInRange_When1To100_Returns6And28()
    {
        // Arrange
        var start = 1;
        var end = 100;
        var expected = new List<int> { 6, 28 };

        // Act
        var result = ForLoop.FindPerfectNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindPerfectNumbersInRange_When1To500_Returns6And28And496()
    {
        // Arrange
        var start = 1;
        var end = 500;
        var expected = new List<int> { 6, 28, 496 };

        // Act
        var result = ForLoop.FindPerfectNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindPerfectNumbersInRange_When100To200_ReturnsEmptyList()
    {
        // Arrange
        var start = 100;
        var end = 200;
        var expected = new List<int>();

        // Act
        var result = ForLoop.FindPerfectNumbersInRange(start, end);

        // Assert
        result.Should().BeEmpty();
    }

    // Exercise 29 - Write a C# Sharp program to check whether a given number is an Armstrong number or not.
    [TestMethod]
    public void IsArmstrongNumber_When153_ReturnsTrue()
    {
        // Arrange
        var number = 153;
        var expected = true;

        // Act
        var result = ForLoop.IsArmstrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsArmstrongNumber_When370_ReturnsTrue()
    {
        // Arrange
        var number = 370;
        var expected = true;

        // Act
        var result = ForLoop.IsArmstrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsArmstrongNumber_When371_ReturnsTrue()
    {
        // Arrange
        var number = 371;
        var expected = true;

        // Act
        var result = ForLoop.IsArmstrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsArmstrongNumber_When407_ReturnsTrue()
    {
        // Arrange
        var number = 407;
        var expected = true;

        // Act
        var result = ForLoop.IsArmstrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsArmstrongNumber_When123_ReturnsFalse()
    {
        // Arrange
        var number = 123;
        var expected = false;

        // Act
        var result = ForLoop.IsArmstrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsArmstrongNumber_When1634_ReturnsTrue()
    {
        // Arrange
        var number = 1634;
        var expected = true;

        // Act
        var result = ForLoop.IsArmstrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 30 - Write a C# Sharp program to find the Armstrong number for a given range of numbers.
    [TestMethod]
    public void FindArmstrongNumbersInRange_When1To1000_ReturnsCorrectNumbers()
    {
        // Arrange
        var start = 1;
        var end = 1000;
        var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407 };

        // Act
        var result = ForLoop.FindArmstrongNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindArmstrongNumbersInRange_When1To500_ReturnsCorrectNumbers()
    {
        // Arrange
        var start = 1;
        var end = 500;
        var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407 };

        // Act
        var result = ForLoop.FindArmstrongNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindArmstrongNumbersInRange_When1000To2000_Returns1634()
    {
        // Arrange
        var start = 1000;
        var end = 2000;
        var expected = new List<int> { 1634 };

        // Act
        var result = ForLoop.FindArmstrongNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindArmstrongNumbersInRange_When1To100_ReturnsSingleDigitNumbers()
    {
        // Arrange
        var start = 1;
        var end = 100;
        var expected = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        var result = ForLoop.FindArmstrongNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindArmstrongNumbersInRange_When150To400_Returns153370371()
    {
        // Arrange
        var start = 150;
        var end = 400;
        var expected = new List<int> { 153, 370, 371 };

        // Act
        var result = ForLoop.FindArmstrongNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 31 - Write a program in C# Sharp to display the pattern like a diamond.
    [TestMethod]
    public void GenerateDiamondPattern_When5HalfRows_ReturnsCorrectPattern()
    {
        // Arrange
        var halfRows = 5;
        var expected = new List<string>
        {
            "    *",
            "   ***",
            "  *****",
            " *******",
            "*********",
            " *******",
            "  *****",
            "   ***",
            "    *"
        };

        // Act
        var result = ForLoop.GenerateDiamondPattern(halfRows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateDiamondPattern_When3HalfRows_ReturnsCorrectPattern()
    {
        // Arrange
        var halfRows = 3;
        var expected = new List<string>
        {
            "  *",
            " ***",
            "*****",
            " ***",
            "  *"
        };

        // Act
        var result = ForLoop.GenerateDiamondPattern(halfRows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateDiamondPattern_When2HalfRows_ReturnsCorrectPattern()
    {
        // Arrange
        var halfRows = 2;
        var expected = new List<string>
        {
            " *",
            "***",
            " *"
        };

        // Act
        var result = ForLoop.GenerateDiamondPattern(halfRows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 32 - Write a C# Sharp program to determine whether a given number is prime or not.
    [TestMethod]
    public void IsPrimeNumber_When13_ReturnsTrue()
    {
        // Arrange
        var number = 13;
        var expected = true;

        // Act
        var result = ForLoop.IsPrimeNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsPrimeNumber_When53_ReturnsTrue()
    {
        // Arrange
        var number = 53;
        var expected = true;

        // Act
        var result = ForLoop.IsPrimeNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsPrimeNumber_When4_ReturnsFalse()
    {
        // Arrange
        var number = 4;
        var expected = false;

        // Act
        var result = ForLoop.IsPrimeNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsPrimeNumber_When1_ReturnsFalse()
    {
        // Arrange
        var number = 1;
        var expected = false;

        // Act
        var result = ForLoop.IsPrimeNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsPrimeNumber_When2_ReturnsTrue()
    {
        // Arrange
        var number = 2;
        var expected = true;

        // Act
        var result = ForLoop.IsPrimeNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsPrimeNumber_When9_ReturnsFalse()
    {
        // Arrange
        var number = 9;
        var expected = false;

        // Act
        var result = ForLoop.IsPrimeNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 33 - Write a C# Sharp program to display Pascal's triangle.
    [TestMethod]
    public void GeneratePascalsTriangle_When5Rows_ReturnsCorrectTriangle()
    {
        // Arrange
        var rows = 5;
        var expected = new List<List<int>>
        {
            new List<int> { 1 },
            new List<int> { 1, 1 },
            new List<int> { 1, 2, 1 },
            new List<int> { 1, 3, 3, 1 },
            new List<int> { 1, 4, 6, 4, 1 }
        };

        // Act
        var result = ForLoop.GeneratePascalsTriangle(rows);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [TestMethod]
    public void GeneratePascalsTriangle_When3Rows_ReturnsCorrectTriangle()
    {
        // Arrange
        var rows = 3;
        var expected = new List<List<int>>
        {
            new List<int> { 1 },
            new List<int> { 1, 1 },
            new List<int> { 1, 2, 1 }
        };

        // Act
        var result = ForLoop.GeneratePascalsTriangle(rows);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [TestMethod]
    public void GeneratePascalsTriangle_When1Row_ReturnsSingleRow()
    {
        // Arrange
        var rows = 1;
        var expected = new List<List<int>>
        {
            new List<int> { 1 }
        };

        // Act
        var result = ForLoop.GeneratePascalsTriangle(rows);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [TestMethod]
    public void GeneratePascalsTriangle_When8Rows_ReturnsCorrectTriangle()
    {
        // Arrange
        var rows = 8;
        var expected = new List<List<int>>
        {
            new List<int> { 1 },
            new List<int> { 1, 1 },
            new List<int> { 1, 2, 1 },
            new List<int> { 1, 3, 3, 1 },
            new List<int> { 1, 4, 6, 4, 1 },
            new List<int> { 1, 5, 10, 10, 5, 1 },
            new List<int> { 1, 6, 15, 20, 15, 6, 1 },
            new List<int> { 1, 7, 21, 35, 35, 21, 7, 1 }
        };

        // Act
        var result = ForLoop.GeneratePascalsTriangle(rows);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    // Exercise 34 - Write a program in C# Sharp to find prime numbers within a range of numbers.
    [TestMethod]
    public void FindPrimeNumbersInRange_When1To50_ReturnsCorrectPrimes()
    {
        // Arrange
        var start = 1;
        var end = 50;
        var expected = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 };

        // Act
        var result = ForLoop.FindPrimeNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindPrimeNumbersInRange_When10To30_ReturnsCorrectPrimes()
    {
        // Arrange
        var start = 10;
        var end = 30;
        var expected = new List<int> { 11, 13, 17, 19, 23, 29 };

        // Act
        var result = ForLoop.FindPrimeNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindPrimeNumbersInRange_When1To10_ReturnsCorrectPrimes()
    {
        // Arrange
        var start = 1;
        var end = 10;
        var expected = new List<int> { 2, 3, 5, 7 };

        // Act
        var result = ForLoop.FindPrimeNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindPrimeNumbersInRange_When50To60_ReturnsCorrectPrimes()
    {
        // Arrange
        var start = 50;
        var end = 60;
        var expected = new List<int> { 53, 59 };

        // Act
        var result = ForLoop.FindPrimeNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindPrimeNumbersInRange_When1To2_ReturnsOnly2()
    {
        // Arrange
        var start = 1;
        var end = 2;
        var expected = new List<int> { 2 };

        // Act
        var result = ForLoop.FindPrimeNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindPrimeNumbersInRange_WhenNegativeRange_ReturnsEmptyList()
    {
        // Arrange
        var start = -10;
        var end = -1;
        var expected = new List<int>();

        // Act
        var result = ForLoop.FindPrimeNumbersInRange(start, end);

        // Assert
        result.Should().BeEmpty();
    }

    // Exercise 35 - Write a program in C# Sharp to display the first n terms of Fibonacci series.
    [TestMethod]
    public void GenerateFibonacciSeries_When10Terms_ReturnsCorrectSeries()
    {
        // Arrange
        var n = 10;
        var expected = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

        // Act
        var result = ForLoop.GenerateFibonacciSeries(n);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateFibonacciSeries_When5Terms_ReturnsCorrectSeries()
    {
        // Arrange
        var n = 5;
        var expected = new List<int> { 0, 1, 1, 2, 3 };

        // Act
        var result = ForLoop.GenerateFibonacciSeries(n);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateFibonacciSeries_When2Terms_ReturnsCorrectSeries()
    {
        // Arrange
        var n = 2;
        var expected = new List<int> { 0, 1 };

        // Act
        var result = ForLoop.GenerateFibonacciSeries(n);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateFibonacciSeries_When1Term_ReturnsCorrectSeries()
    {
        // Arrange
        var n = 1;
        var expected = new List<int> { 0 };

        // Act
        var result = ForLoop.GenerateFibonacciSeries(n);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateFibonacciSeries_When15Terms_ReturnsCorrectSeries()
    {
        // Arrange
        var n = 15;
        var expected = new List<int>
        {
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
        };

        // Act
        var result = ForLoop.GenerateFibonacciSeries(n);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 36 - Write a program in C# Sharp to display such a pattern for n number of rows using a number starting with the number 1. The first and last number of each row will be 1.
    [TestMethod]
    public void GenerateNumberPyramid_When3Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 3;
        var expected = new List<string>
        {
            "  1",
            " 121",
            "12321"
        };

        // Act
        var result = ForLoop.GenerateNumbersPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateNumbersPyramid_When5Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 5;
        var expected = new List<string>
        {
            "    1",
            "   121",
            "  12321",
            " 1234321",
            "123454321"
        };

        // Act
        var result = ForLoop.GenerateNumbersPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateNumberPyramid_When1Row_ReturnsSingle1()
    {
        // Arrange
        var rows = 1;
        var expected = new List<string>
        {
            "1"
        };

        // Act
        var result = ForLoop.GenerateNumbersPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateNumberPyramid_When2Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 2;
        var expected = new List<string>
        {
            " 1",
            "121"
        };

        // Act
        var result = ForLoop.GenerateNumbersPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateNumbersPyramid_When4Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var rows = 4;
        var expected = new List<string>
        {
            "   1",
            "  121",
            " 12321",
            "1234321"
        };

        // Act
        var result = ForLoop.GenerateNumbersPyramid(rows);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 37 - Write a program in C# Sharp to display a number in reverse order.
    [TestMethod]
    public void ReverseNumber_When12345_Returns54321()
    {
        // Arrange
        var number = 12345;
        var expected = 54321;

        // Act
        var result = ForLoop.ReverseNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ReverseNumber_When25_Returns52()
    {
        // Arrange
        var number = 25;
        var expected = 52;

        // Act
        var result = ForLoop.ReverseNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ReverseNumber_When7_Returns7()
    {
        // Arrange
        var number = 7;
        var expected = 7;

        // Act
        var result = ForLoop.ReverseNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ReverseNumber_When100_Returns1()
    {
        // Arrange
        var number = 100;
        var expected = 1;

        // Act
        var result = ForLoop.ReverseNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ReverseNumber_When12321_Returns12321()
    {
        // Arrange
        var number = 12321;
        var expected = 12321;

        // Act
        var result = ForLoop.ReverseNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ReverseNumber_WhenNegativeNumber_ReturnsNegativeReversed()
    {
        // Arrange
        var number = -12345;
        var expected = -54321;

        // Act
        var result = ForLoop.ReverseNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    // Exerceise 38 - Write a program in C# Sharp to check whether a number is a palindrome or not.
    [TestMethod]
    public void IsPalindrome_When121_ReturnsTrue()
    {
        // Arrange
        var number = 121;
        var expected = true;

        // Act
        var result = ForLoop.IsPalindrome(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsPalindrome_When8_ReturnsTrue()
    {
        // Arrange
        var number = 8;
        var expected = true;

        // Act
        var result = ForLoop.IsPalindrome(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsPalindrome_When123_ReturnsFalse()
    {
        // Arrange
        var number = 123;
        var expected = false;

        // Act
        var result = ForLoop.IsPalindrome(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsPalindrome_When1221_ReturnsTrue()
    {
        // Arrange
        var number = 1221;
        var expected = true;

        // Act
        var result = ForLoop.IsPalindrome(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsPalindrome_When12321_ReturnsTrue()
    {
        // Arrange
        var number = 12321;
        var expected = true;

        // Act
        var result = ForLoop.IsPalindrome(number);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 39 - Write a C# Sharp program to find the number and sum of all integers between 100 and 200 divisible by 9.
    [TestMethod]
    public void FindNumbersDivisibleBy9_When100To200_ReturnsCorrectNumbersAndSum()
    {
        // Arrange
        var start = 100;
        var end = 200;
        var expectedNumbers = new List<int> { 108, 117, 126, 135, 144, 153, 162, 171, 180, 189, 198 };
        var expectedSum = 1683;

        // Act
        var result = ForLoop.FindNumbersDivisibleBy9(start, end);

        // Assert
        result.Numbers.Should().Equal(expectedNumbers);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void FindNumbersDivisibleBy9_When1To20_ReturnsCorrectNumbersAndSum()
    {
        // Arrange
        var start = 1;
        var end = 20;
        var expectedNumbers = new List<int> { 9, 18 };
        var expectedSum = 27;

        // Act
        var result = ForLoop.FindNumbersDivisibleBy9(start, end);

        // Assert
        result.Numbers.Should().Equal(expectedNumbers);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void FindNumbersDivisibleBy9_When200To300_ReturnsCorrectNumbersAndSum()
    {
        // Arrange
        var start = 200;
        var end = 300;
        var expectedNumbers = new List<int> { 207, 216, 225, 234, 243, 252, 261, 270, 279, 288, 297 };
        var expectedSum = 2772;

        // Act
        var result = ForLoop.FindNumbersDivisibleBy9(start, end);

        // Assert
        result.Numbers.Should().Equal(expectedNumbers);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void FindNumbersDivisibleBy9_WhenNoNumbersFound_ReturnsEmptyListAndZeroSum()
    {
        // Arrange
        var start = 1;
        var end = 8;
        var expectedNumbers = new List<int>();
        var expectedSum = 0;

        // Act
        var result = ForLoop.FindNumbersDivisibleBy9(start, end);

        // Assert
        result.Numbers.Should().BeEmpty();
        result.Sum.Should().Be(expectedSum);
    }

    // Exercise 40 - Write a C# Sharp Program to display the following pattern using the alphabet.
    [TestMethod]
    public void GenerateAlphabetPyramid_When4Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var n = 4;
        var expected = new List<string>
        {
            "A",
            "A B A",
            "A B C B A",
            "A B C D C B A"
        };

        // Act
        var result = ForLoop.GenerateAlphabetPyramid(n);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateAlphabetPyramid_When8Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var n = 8;
        var expected = new List<string>
        {
            "A",
            "A B A",
            "A B C B A",
            "A B C D C B A",
            "A B C D E D C B A",
            "A B C D E F E D C B A",
            "A B C D E F G F E D C B A",
            "A B C D E F G H G F E D C B A"
        };

        // Act
        var result = ForLoop.GenerateAlphabetPyramid(n);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateAlphabetPyramid_When1Row_ReturnsSingleA()
    {
        // Arrange
        var n = 1;
        var expected = new List<string>
        {
            "A"
        };

        // Act
        var result = ForLoop.GenerateAlphabetPyramid(n);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateAlphabetPyramid_When2Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var n = 2;
        var expected = new List<string>
        {
            "A",
            "A B A"
        };

        // Act
        var result = ForLoop.GenerateAlphabetPyramid(n);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void GenerateAlphabetPyramid_When3Rows_ReturnsCorrectPattern()
    {
        // Arrange
        var n = 3;
        var expected = new List<string>
        {
            "A",
            "A B A",
            "A B C B A"
        };

        // Act
        var result = ForLoop.GenerateAlphabetPyramid(n);

        // Assert
        result.Should().Equal(expected);
    }

    // Exercise 41 - Write a program in C# Sharp to convert a decimal number into binary without using an array.
    [TestMethod]
    public void ConvertDecimalToBinary_When25_Returns11001()
    {
        // Arrange
        var decimalNumber = 25;
        var expected = 11001L;

        // Act
        var result = ForLoop.ConvertDecimalToBinary(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToBinary_When65_Returns1000001()
    {
        // Arrange
        var decimalNumber = 65;
        var expected = 1000001L;

        // Act
        var result = ForLoop.ConvertDecimalToBinary(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToBinary_When1_Returns1()
    {
        // Arrange
        var decimalNumber = 1;
        var expected = 1L;

        // Act
        var result = ForLoop.ConvertDecimalToBinary(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToBinary_When0_Returns0()
    {
        // Arrange
        var decimalNumber = 0;
        var expected = 0L;

        // Act
        var result = ForLoop.ConvertDecimalToBinary(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToBinary_When10_Returns1010()
    {
        // Arrange
        var decimalNumber = 10;
        var expected = 1010L;

        // Act
        var result = ForLoop.ConvertDecimalToBinary(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToBinary_When255_Returns11111111()
    {
        // Arrange
        var decimalNumber = 255;
        var expected = 11111111L;

        // Act
        var result = ForLoop.ConvertDecimalToBinary(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 42 - Write a program in C# Sharp to convert a binary number into a decimal number without using array, function and while loop.
    [TestMethod]
    public void ConvertBinaryToDecimal_When1010101_Returns85()
    {
        // Arrange
        var binaryNumber = 1010101;
        var expected = 85;

        // Act
        var result = ForLoop.ConvertBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertBinaryToDecimal_When1000001_Returns65()
    {
        // Arrange
        var binaryNumber = 1000001;
        var expected = 65;

        // Act
        var result = ForLoop.ConvertBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertBinaryToDecimal_When1_Returns1()
    {
        // Arrange
        var binaryNumber = 1;
        var expected = 1;

        // Act
        var result = ForLoop.ConvertBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertBinaryToDecimal_When0_Returns0()
    {
        // Arrange
        var binaryNumber = 0;
        var expected = 0;

        // Act
        var result = ForLoop.ConvertBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertBinaryToDecimal_When1111_Returns15()
    {
        // Arrange
        var binaryNumber = 1111;
        var expected = 15;

        // Act
        var result = ForLoop.ConvertBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertBinaryToDecimal_When1010_Returns10()
    {
        // Arrange
        var binaryNumber = 1010;
        var expected = 10;

        // Act
        var result = ForLoop.ConvertBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 43 - Write a C# Sharp program to find the HCF (Highest Common Factor) of two numbers.
    [TestMethod]
    public void FindHCF_When24And28_Returns4()
    {
        // Arrange
        var num1 = 24;
        var num2 = 28;
        var expected = 4;

        // Act
        var result = ForLoop.FindHCF(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindHCF_When10And14_Returns2()
    {
        // Arrange
        var num1 = 10;
        var num2 = 14;
        var expected = 2;

        // Act
        var result = ForLoop.FindHCF(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindHCF_When15And25_Returns5()
    {
        // Arrange
        var num1 = 15;
        var num2 = 25;
        var expected = 5;

        // Act
        var result = ForLoop.FindHCF(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindHCF_When7And13_Returns1()
    {
        // Arrange
        var num1 = 7;
        var num2 = 13;
        var expected = 1;

        // Act
        var result = ForLoop.FindHCF(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindHCF_When36And60_Returns12()
    {
        // Arrange
        var num1 = 36;
        var num2 = 60;
        var expected = 12;

        // Act
        var result = ForLoop.FindHCF(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindHCF_WhenSameNumbers_ReturnsSameNumber()
    {
        // Arrange
        var num1 = 17;
        var num2 = 17;
        var expected = 17;

        // Act
        var result = ForLoop.FindHCF(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 44 - Write a program in C# Sharp to find the LCM of any two numbers using HCF.
    [TestMethod]
    public void FindLCM_When15And20_Returns60()
    {
        // Arrange
        var num1 = 15;
        var num2 = 20;
        var expected = 60;

        // Act
        var result = ForLoop.FindLCM(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_When8And12_Returns24()
    {
        // Arrange
        var num1 = 8;
        var num2 = 12;
        var expected = 24;

        // Act
        var result = ForLoop.FindLCM(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_When7And13_Returns91()
    {
        // Arrange
        var num1 = 7;
        var num2 = 13;
        var expected = 91;

        // Act
        var result = ForLoop.FindLCM(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_When6And8_Returns24()
    {
        // Arrange
        var num1 = 6;
        var num2 = 8;
        var expected = 24;

        // Act
        var result = ForLoop.FindLCM(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_WhenSameNumbers_ReturnsSameNumber()
    {
        // Arrange
        var num1 = 9;
        var num2 = 9;
        var expected = 9;

        // Act
        var result = ForLoop.FindLCM(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_When4And6_Returns12()
    {
        // Arrange
        var num1 = 4;
        var num2 = 6;
        var expected = 12;

        // Act
        var result = ForLoop.FindLCM(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 45 - Write a program in C# Sharp to find the LCM of any two numbers.
    [TestMethod]
    public void FindLCM_When15And20_Return60()
    {
        // Arrange
        var num1 = 15;
        var num2 = 20;
        var expected = 60;

        // Act
        var result = ForLoop.FindLCM1(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_When6And8_Return24()
    {
        // Arrange
        var num1 = 6;
        var num2 = 8;
        var expected = 24;

        // Act
        var result = ForLoop.FindLCM1(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_When7And13_Return91()
    {
        // Arrange
        var num1 = 7;
        var num2 = 13;
        var expected = 91;

        // Act
        var result = ForLoop.FindLCM1(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_When4And6_Return12()
    {
        // Arrange
        var num1 = 4;
        var num2 = 6;
        var expected = 12;

        // Act
        var result = ForLoop.FindLCM1(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_WhenSameNumbers_ReturnSameNumber()
    {
        // Arrange
        var num1 = 9;
        var num2 = 9;
        var expected = 9;

        // Act
        var result = ForLoop.FindLCM1(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void FindLCM_When3And5_Return15()
    {
        // Arrange
        var num1 = 3;
        var num2 = 5;
        var expected = 15;

        // Act
        var result = ForLoop.FindLCM1(num1, num2);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 46 - Write a C# Sharp program to convert a binary number into a decimal number using the math function.
    [TestMethod]
    public void ConvertBinaryToDecimal_When1010100_Returns84()
    {
        // Arrange
        var binaryNumber = 1010100;
        var expected = 84;

        // Act
        var result = ForLoop.ConvertsBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertsBinaryToDecimal_When1000001_Returns65()
    {
        // Arrange
        var binaryNumber = 1000001;
        var expected = 65;

        // Act
        var result = ForLoop.ConvertsBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertsBinaryToDecimal_When1111_Returns15()
    {
        // Arrange
        var binaryNumber = 1111;
        var expected = 15;

        // Act
        var result = ForLoop.ConvertsBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertsBinaryToDecimal_When1010_Returns10()
    {
        // Arrange
        var binaryNumber = 1010;
        var expected = 10;

        // Act
        var result = ForLoop.ConvertsBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertsBinaryToDecimal_When1_Returns1()
    {
        // Arrange
        var binaryNumber = 1;
        var expected = 1;

        // Act
        var result = ForLoop.ConvertsBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertsBinaryToDecimal_When0_Returns0()
    {
        // Arrange
        var binaryNumber = 0;
        var expected = 0;

        // Act
        var result = ForLoop.ConvertsBinaryToDecimal(binaryNumber);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 47 - Write a C# Sharp program to check whether a number is a Strong Number or not.
    [TestMethod]
    public void IsStrongNumber_When15_ReturnsFalse()
    {
        // Arrange
        var number = 15;
        var expected = false;

        // Act
        var result = ForLoop.IsStrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsStrongNumber_When2_ReturnsTrue()
    {
        // Arrange
        var number = 2;
        var expected = true;

        // Act
        var result = ForLoop.IsStrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsStrongNumber_When145_ReturnsTrue()
    {
        // Arrange
        var number = 145;
        var expected = true;

        // Act
        var result = ForLoop.IsStrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsStrongNumber_When1_ReturnsTrue()
    {
        // Arrange
        var number = 1;
        var expected = true;

        // Act
        var result = ForLoop.IsStrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsStrongNumber_When40585_ReturnsTrue()
    {
        // Arrange
        var number = 40585;
        var expected = true;

        // Act
        var result = ForLoop.IsStrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void IsStrongNumber_When123_ReturnsFalse()
    {
        // Arrange
        var number = 123;
        var expected = false;

        // Act
        var result = ForLoop.IsStrongNumber(number);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 48 - Write a C# Sharp program to find Strong Numbers within a range of numbers.
    [TestMethod]
    public void FindStrongNumbersInRange_When1To200_Returns1And2And145()
    {
        // Arrange
        var start = 1;
        var end = 200;
        var expected = new List<int> { 1, 2, 145 };

        // Act
        var result = ForLoop.FindStrongNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindStrongNumbersInRange_When0To1000_Returns0And1And2And145()
    {
        // Arrange
        var start = 0;
        var end = 1000;
        var expected = new List<int> { 0, 1, 2, 145 };

        // Act
        var result = ForLoop.FindStrongNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindStrongNumbersInRange_When1To2_Returns1And2()
    {
        // Arrange
        var start = 1;
        var end = 2;
        var expected = new List<int> { 1, 2 };

        // Act
        var result = ForLoop.FindStrongNumbersInRange(start, end);

        // Assert
        result.Should().Equal(expected);
    }

    [TestMethod]
    public void FindStrongNumbersInRange_When10To100_ReturnsEmptyList()
    {
        // Arrange
        var start = 10;
        var end = 100;
        var expected = new List<int>();

        // Act
        var result = ForLoop.FindStrongNumbersInRange(start, end);

        // Assert
        result.Should().BeEmpty();
    }

    [TestMethod]
    public void FindStrongNumbersInRange_WhenNegativeRange_ReturnsEmptyList()
    {
        // Arrange
        var start = -10;
        var end = -1;
        var expected = new List<int>();

        // Act
        var result = ForLoop.FindStrongNumbersInRange(start, end);

        // Assert
        result.Should().BeEmpty();
    }

    // Exercise 49 - Write a C# Sharp program to find out the sum of the Arithmetic Progress series.
    [TestMethod]
    public void CalculateArithmeticProgression_When1Start10Count4Difference_ReturnsCorrectSeriesAndSum()
    {
        // Arrange
        var start = 1;
        var count = 10;
        var difference = 4;
        var expectedSeries = new List<int> { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37 };
        var expectedSum = 190;

        // Act
        var result = ForLoop.CalculateArithmeticProgression(start, count, difference);

        // Assert
        result.Series.Should().Equal(expectedSeries);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateArithmeticProgression_When0Start10Count5Difference_ReturnsCorrectSeriesAndSum()
    {
        // Arrange
        var start = 0;
        var count = 10;
        var difference = 5;
        var expectedSeries = new List<int> { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45 };
        var expectedSum = 225;

        // Act
        var result = ForLoop.CalculateArithmeticProgression(start, count, difference);

        // Assert
        result.Series.Should().Equal(expectedSeries);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateArithmeticProgression_When2Start5Count3Difference_ReturnsCorrectSeriesAndSum()
    {
        // Arrange
        var start = 2;
        var count = 5;
        var difference = 3;
        var expectedSeries = new List<int> { 2, 5, 8, 11, 14 };
        var expectedSum = 40;

        // Act
        var result = ForLoop.CalculateArithmeticProgression(start, count, difference);

        // Assert
        result.Series.Should().Equal(expectedSeries);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateArithmeticProgression_When10Start1Count1Difference_ReturnsSingleNumber()
    {
        // Arrange
        var start = 10;
        var count = 1;
        var difference = 1;
        var expectedSeries = new List<int> { 10 };
        var expectedSum = 10;

        // Act
        var result = ForLoop.CalculateArithmeticProgression(start, count, difference);

        // Assert
        result.Series.Should().Equal(expectedSeries);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateArithmeticProgression_WhenNegativeStart_ReturnsCorrectSeriesAndSum()
    {
        // Arrange
        var start = -5;
        var count = 4;
        var difference = 2;
        var expectedSeries = new List<int> { -5, -3, -1, 1 };
        var expectedSum = -8;

        // Act
        var result = ForLoop.CalculateArithmeticProgression(start, count, difference);

        // Assert
        result.Series.Should().Equal(expectedSeries);
        result.Sum.Should().Be(expectedSum);
    }

    [TestMethod]
    public void CalculateArithmeticProgression_WhenZeroDifference_ReturnsConstantSeries()
    {
        // Arrange
        var start = 7;
        var count = 5;
        var difference = 0;
        var expectedSeries = new List<int> { 7, 7, 7, 7, 7 };
        var expectedSum = 35;

        // Act
        var result = ForLoop.CalculateArithmeticProgression(start, count, difference);

        // Assert
        result.Series.Should().Equal(expectedSeries);
        result.Sum.Should().Be(expectedSum);
    }

    // Exercise 50 - Write a program in C# Sharp to convert a decimal number into octal without using an array.
    [TestMethod]
    public void ConvertDecimalToOctal_When79_Returns117()
    {
        // Arrange
        var decimalNumber = 79;
        var expected = 117L;

        // Act
        var result = ForLoop.ConvertDecimalToOctal(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToOctal_When6_Returns6()
    {
        // Arrange
        var decimalNumber = 6;
        var expected = 6L;

        // Act
        var result = ForLoop.ConvertDecimalToOctal(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToOctal_When8_Returns10()
    {
        // Arrange
        var decimalNumber = 8;
        var expected = 10L;

        // Act
        var result = ForLoop.ConvertDecimalToOctal(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToOctal_When15_Returns17()
    {
        // Arrange
        var decimalNumber = 15;
        var expected = 17L;

        // Act
        var result = ForLoop.ConvertDecimalToOctal(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToOctal_When63_Returns77()
    {
        // Arrange
        var decimalNumber = 63;
        var expected = 77L;

        // Act
        var result = ForLoop.ConvertDecimalToOctal(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToOctal_When0_Returns0()
    {
        // Arrange
        var decimalNumber = 0;
        var expected = 0L;

        // Act
        var result = ForLoop.ConvertDecimalToOctal(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    [TestMethod]
    public void ConvertDecimalToOctal_When255_Returns377()
    {
        // Arrange
        var decimalNumber = 255;
        var expected = 377L;

        // Act
        var result = ForLoop.ConvertDecimalToOctal(decimalNumber);

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 51 - Write a program in C# Sharp to convert an octal number to decimal without using an array.
    [TestMethod]
    [DataRow("745", "The Octal Number : 745\nThe equivalent Decimal Number : 485")]
    [DataRow("5", "The Octal Number : 5\nThe equivalent Decimal Number : 5")]
    [DataRow("10", "The Octal Number : 10\nThe equivalent Decimal Number : 8")]
    [DataRow("77", "The Octal Number : 77\nThe equivalent Decimal Number : 63")]
    [DataRow("0", "The Octal Number : 0\nThe equivalent Decimal Number : 0")]
    [DataRow("", "Invalid input")]
    [DataRow("89", "Invalid octal number")]
    [DataRow("A7", "Invalid octal number")]
    public void ConvertOctalToDecimal_ValidOctal_ReturnsCorrectDecimal(string input, string expected)
    {
        var result = ForLoop.ConvertOctalToDecimal(input);
        result.Should().Be(expected);
    }

    // Exercise 52 - Write a C# Sharp program to find the sum of the Geometric Progress series.
    [TestMethod]
    [DataRow(1, 5, 2, "The numbers for the G.P. series:\n1 2 4 8 16\nThe tn terms of G.P. : 16.000000\nThe Sum of the G.P. series : 31.000000")]
    [DataRow(1, 5, 10, "The numbers for the G.P. series:\n1 10 100 1000 10000\nThe tn terms of G.P. : 10000.000000\nThe Sum of the G.P. series : 11111.000000")]
    [DataRow(3, 4, 2, "The numbers for the G.P. series:\n3 6 12 24\nThe tn terms of G.P. : 24.000000\nThe Sum of the G.P. series : 45.000000")]
    [DataRow(2, 3, 3, "The numbers for the G.P. series:\n2 6 18\nThe tn terms of G.P. : 18.000000\nThe Sum of the G.P. series : 26.000000")]
    public void CalculateGPSeries_ValidInput_ReturnsCorrectResult(int firstTerm, int numberOfTerms, int commonRatio, string expected)
    {
        var result = ForLoop.CalculateGPSeries(firstTerm, numberOfTerms, commonRatio);
        result.Should().Be(expected);
    }

    // Exercise 53 - Write a program in C# Sharp to convert a binary number to octal.
    [TestMethod]
    [DataRow("1001", "The Binary Number : 1001\nThe equivalent Octal Number : 11")]
    [DataRow("110101", "The Binary Number : 110101\nThe equivalent Octal Number : 65")]
    [DataRow("1010", "The Binary Number : 1010\nThe equivalent Octal Number : 12")]
    [DataRow("1111", "The Binary Number : 1111\nThe equivalent Octal Number : 17")]
    [DataRow("1", "The Binary Number : 1\nThe equivalent Octal Number : 1")]
    [DataRow("0", "The Binary Number : 0\nThe equivalent Octal Number : 0")]
    [DataRow("", "Invalid input")]
    [DataRow("102", "Invalid binary number")]
    [DataRow("abc", "Invalid binary number")]
    public void ConvertBinaryToOctal_ValidBinary_ReturnsCorrectOctal(string input, string expected)
    {
        var result = ForLoop.ConvertBinaryToOctal(input);
        result.Should().Be(expected);
    }

    // Exercise 54 -  Write a program in C# Sharp to convert an octal number into binary.
    [TestMethod]
    [DataRow("11", "The Octal Number : 11\nThe equivalent Binary Number : 1001")]
    [DataRow("45", "The Octal Number : 45\nThe equivalent Binary Number : 100101")]
    [DataRow("7", "The Octal Number : 7\nThe equivalent Binary Number : 111")]
    [DataRow("1", "The Octal Number : 1\nThe equivalent Binary Number : 1")]
    [DataRow("0", "The Octal Number : 0\nThe equivalent Binary Number : 0")]
    [DataRow("", "Invalid input")]
    [DataRow("89", "Invalid octal number")]
    [DataRow("A7", "Invalid octal number")]
    public void ConvertOctalToBinary_ValidOctal_ReturnsCorrectBinary(string input, string expected)
    {
        var result = ForLoop.ConvertOctalToBinary(input);
        result.Should().Be(expected);
    }

    // Exercise 55 - Write a program in C# Sharp to convert a decimal number to hexadecimal.
    [TestMethod]
    [DataRow(79, "The equivalent Hexadecimal Number : 4F")]
    [DataRow(1015, "The equivalent Hexadecimal Number : 3F7")]
    [DataRow(255, "The equivalent Hexadecimal Number : FF")]
    [DataRow(16, "The equivalent Hexadecimal Number : 10")]
    [DataRow(0, "The equivalent Hexadecimal Number : 0")]
    [DataRow(10, "The equivalent Hexadecimal Number : A")]
    [DataRow(15, "The equivalent Hexadecimal Number : F")]
    [DataRow(4096, "The equivalent Hexadecimal Number : 1000")]
    public void ConvertDecimalToHexadecimal_ValidDecimal_ReturnsCorrectHexadecimal(int input, string expected)
    {
        var result = ForLoop.ConvertDecimalToHexadecimal(input);
        result.Should().Be(expected);
    }

    // Exercise 56 - Write a program in C# Sharp to check whether a number can be expressed as the sum of two prime numbers.
    [TestMethod]
    [DataRow(16, "16 = 3 + 13\n16 = 5 + 11")]
    [DataRow(50, "50 = 3 + 47\n50 = 7 + 43\n50 = 13 + 37\n50 = 19 + 31")]
    [DataRow(4, "4 = 2 + 2")]
    [DataRow(10, "10 = 3 + 7\n10 = 5 + 5")]
    [DataRow(3, "3 can not be expressed as the sum of two prime numbers.")]
    [DataRow(1, "1 can not be expressed as the sum of two prime numbers.")]
    [DataRow(2, "2 can not be expressed as the sum of two prime numbers.")]
    [DataRow(11, "11 can not be expressed as the sum of two prime numbers.")]
    [DataRow(100, "100 = 3 + 97\n100 = 11 + 89\n100 = 17 + 83\n100 = 29 + 71\n100 = 41 + 59\n100 = 47 + 53")]
    public void CheckSumOfTwoPrimes_ValidNumber_ReturnsCorrectResult(int input, string expected)
    {
        var result = ForLoop.CheckSumOfTwoPrimes(input);
        result.Should().Be(expected);
    }

    // Exercise 57 - Write a program in C# Sharp to print a string in reverse order.
    [TestMethod]
    [DataRow("Welcome", "Reversed string is: emocleW")]
    [DataRow("W3RESOURCE", "Reversed string is: ECRUOSER3W")]
    [DataRow("Hello", "Reversed string is: olleH")]
    [DataRow("A", "Reversed string is: A")]
    [DataRow("", "Reversed string is: ")]
    [DataRow("12345", "Reversed string is: 54321")]
    [DataRow("C# Sharp", "Reversed string is: prahS #C")]
    public void ReverseString_ValidInput_ReturnsReversedString(string input, string expected)
    {
        var result = ForLoop.ReverseString(input);
        result.Should().Be(expected);
    }

    // Exercise 58 - Write a C# Sharp program to display an alphabet pattern like A with an asterisk.
    [TestMethod]
    public void DisplayPatternA_ReturnsCorrectAPattern()
    {
        var expected = "  ***  \n *   * \n *   * \n ***** \n *   * \n *   * \n *   * \n *   * \n";
        var result = ForLoop.DisplayPatternA();
        result.Should().Be(expected);
    }

    // Exercise 59 - Write a C# Sharp program to display an alphabet pattern like B with an asterisk.
    [TestMethod]
    public void DisplayPatternB_ReturnsCorrectBPattern()
    {
        var expected = "  **** \n *   * \n *   * \n  **** \n *   * \n *   * \n  **** \n";
        var result = ForLoop.DisplayPatternB();
        result.Should().Be(expected);
    }

    // Exercise 60 - Write a C# Sharp program to display an alphabet pattern like C with an asterisk.
    [TestMethod]
    public void DisplayPatternC_ReturnsCorrectCPattern()
    {
        var expected = "  ***  \n *   * \n *     \n *     \n *     \n *   * \n  ***  \n";
        var result = ForLoop.DisplayPatternC();
        result.Should().Be(expected);
    }

    // Exercise 61 - Write a C# Sharp program to display an alphabet pattern like D with an asterisk.
    [TestMethod]
    public void DisplayPatternD_ReturnsCorrectDPattern()
    {
        var expected = " ****  \n *   * \n *   * \n *   * \n *   * \n *   * \n ****  \n";
        var result = ForLoop.DisplayPatternD();
        result.Should().Be(expected);
    }

    // Exercise 62 - Write a C# Sharp program to display an alphabet pattern like E with an asterisk.
    [TestMethod]
    public void DisplayPatternE_ReturnsCorrectEPattern()
    {
        var expected = " ***** \n *     \n *     \n ****  \n *     \n *     \n ***** \n";
        var result = ForLoop.DisplayPatternE();
        result.Should().Be(expected);
    }

    // Exercise 63 - Write a C# Sharp program to display an alphabet pattern like F with an asterisk.
    [TestMethod]
    public void DisplayPatternF_ReturnsCorrectFPattern()
    {
        var expected = " ***** \n *     \n *     \n ****  \n *     \n *     \n *     \n";
        var result = ForLoop.DisplayPatternF();
        result.Should().Be(expected);
    }

    // Exercise 64 - Write a C# Sharp program to display an alphabet pattern like G with an asterisk.
    [TestMethod]
    public void DisplayPatternG_ReturnsCorrectGPattern()
    {
        var expected = "  ***  \n *   * \n *     \n * *** \n *   * \n *   * \n  ***  \n";
        var result = ForLoop.DisplayPatternG();
        result.Should().Be(expected);
    }

    // Exercise 65 - Write a C# Sharp program to display an alphabet pattern like H with an asterisk.
    [TestMethod]
    public void DisplayPatternH_ReturnsCorrectHPattern()
    {
        var expected = " *   * \n *   * \n *   * \n ***** \n *   * \n *   * \n *   * \n";
        var result = ForLoop.DisplayPatternH();
        result.Should().Be(expected);
    }

    // Exercise 66 - Write a C# Sharp program to display an alphabet pattern like I with an asterisk.
    [TestMethod]
    public void DisplayPatternI_ReturnsCorrectIPattern()
    {
        var expected = " ***** \n   *   \n   *   \n   *   \n   *   \n   *   \n ***** \n";
        var result = ForLoop.DisplayPatternI();
        result.Should().Be(expected);
    }

    // Exercise 67 - Write a C# Sharp program to display an alphabet pattern like J with an asterisk.
    [TestMethod]
    public void DisplayPatternJ_ReturnsCorrectJPattern()
    {
        var expected = "   *** \n    *  \n    *  \n    *  \n    *  \n  * *  \n   *   \n";
        var result = ForLoop.DisplayPatternJ();
        result.Should().Be(expected);
    }

    // Exercise 68 - Write a C# Sharp program to display an alphabet pattern like K with an asterisk.
    [TestMethod]
    public void DisplayPatternK_ReturnsCorrectKPattern()
    {
        var expected = " *   * \n *  *  \n * *   \n **    \n * *   \n *  *  \n *   * \n";
        var result = ForLoop.DisplayPatternK();
        result.Should().Be(expected);
    }

    // Exercise 69 - Write a C# Sharp program to display an alphabet pattern like L with an asterisk.
    [TestMethod]
    public void DisplayPatternL_ReturnsCorrectLPattern()
    {
        var expected = " *     \n *     \n *     \n *     \n *     \n *     \n ***** \n";
        var result = ForLoop.DisplayPatternL();
        result.Should().Be(expected);
    }

    // Exercise 70 - Write a C# Sharp program to display an alphabet pattern like M with an asterisk.
    [TestMethod]
    public void DisplayPatternM_ReturnsCorrectMPattern()
    {
        var expected = " *   * \n *   * \n ** ** \n * * * \n *   * \n *   * \n *   * \n";
        var result = ForLoop.DisplayPatternM();
        result.Should().Be(expected);
    }

    // Exercise 71 - Write a C# Sharp program to display an alphabet pattern like N with an asterisk.
    [TestMethod]
    public void DisplayPatternN_ReturnsCorrectNPattern()
    {
        var expected = " *   * \n *   * \n **  * \n * * * \n *  ** \n *   * \n *   * \n";
        var result = ForLoop.DisplayPatternN();
        result.Should().Be(expected);
    }

    // Exercise 72 - Write a C# Sharp program to display an alphabet pattern like O with an asterisk.
    [TestMethod]
    public void DisplayPatternO_ReturnsCorrectOPattern()
    {
        var expected = "  ***  \n *   * \n *   * \n *   * \n *   * \n *   * \n  ***  \n";
        var result = ForLoop.DisplayPatternO();
        result.Should().Be(expected);
    }

    // Exercise 73 - Write a C# Sharp program to display an alphabet pattern like P with an asterisk.
    [TestMethod]
    public void DisplayPatternP_ReturnsCorrectPPattern()
    {
        var expected = " ****  \n *   * \n *   * \n ****  \n *     \n *     \n *     \n";
        var result = ForLoop.DisplayPatternP();
        result.Should().Be(expected);
    }

    // Exercise 74 - Write a C# Sharp program to display an alphabet pattern like Q with an asterisk.
    [TestMethod]
    public void DisplayPatternQ_ReturnsCorrectQPattern()
    {
        var expected = "  ***  \n *   * \n *   * \n *   * \n * * * \n *  *  \n  ** * \n";
        var result = ForLoop.DisplayPatternQ();
        result.Should().Be(expected);
    }

    // Exercise 75 - Write a C# Sharp program to display an alphabet pattern like R with an asterisk.
    [TestMethod]
    public void DisplayPatternR_ReturnsCorrectRPattern()
    {
        var expected = " ****  \n *   * \n *   * \n ****  \n * *   \n *  *  \n *   * \n";
        var result = ForLoop.DisplayPatternR();
        result.Should().Be(expected);
    }

    // Exercise 76 - Write a C# Sharp program to display an alphabet pattern like S with an asterisk.
    [TestMethod]
    public void DisplayPatternS_ReturnsCorrectSPattern()
    {
        var expected = "  **** \n *     \n *     \n  ***  \n     * \n     * \n ****  \n";
        var result = ForLoop.DisplayPatternS();
        result.Should().Be(expected);
    }

    // Exercise 77 - Write a C# Sharp program to display an alphabet pattern like T with an asterisk.
    [TestMethod]
    public void DisplayPatternT_ReturnsCorrectTPattern()
    {
        var expected = " ***** \n   *   \n   *   \n   *   \n   *   \n   *   \n   *   \n";
        var result = ForLoop.DisplayPatternT();
        result.Should().Be(expected);
    }

    // Exercise 78 - Write a C# Sharp program to display an alphabet pattern like U with an asterisk.
    [TestMethod]
    public void DisplayPatternU_ReturnsCorrectUPattern()
    {
        var expected = " *   * \n *   * \n *   * \n *   * \n *   * \n *   * \n  ***  \n";
        var result = ForLoop.DisplayPatternU();
        result.Should().Be(expected);
    }

    // Exercise 79 - Write a C# Sharp program to display an alphabet pattern like V with an asterisk.
    [TestMethod]
    public void DisplayPatternV_ReturnsCorrectVPattern()
    {
        var expected = " *   * \n *   * \n *   * \n *   * \n *   * \n  * *  \n   *   \n";
        var result = ForLoop.DisplayPatternV();
        result.Should().Be(expected);
    }

    // Exercise 80 - Write a C# Sharp program to display an alphabet pattern like W with an asterisk.
    [TestMethod]
    public void DisplayPatternW_ReturnsCorrectWPattern()
    {
        var expected = " *   * \n *   * \n *   * \n *   * \n * * * \n * * * \n  * *  \n";
        var result = ForLoop.DisplayPatternW();
        result.Should().Be(expected);
    }

    // Exercise 81 - Write a C# Sharp program to display an alphabet pattern like X with an asterisk.
    [TestMethod]
    public void DisplayPatternX_ReturnsCorrectXPattern()
    {
        var expected = " *   * \n *   * \n  * *  \n   *   \n  * *  \n *   * \n *   * \n";
        var result = ForLoop.DisplayPatternX();
        result.Should().Be(expected);
    }

    // Exercise 82 - Write a C# Sharp program to display an alphabet pattern like Y with an asterisk.
    [TestMethod]
    public void DisplayPatternY_ReturnsCorrectYPattern()
    {
        var expected = " *   * \n *   * \n  * *  \n   *   \n   *   \n   *   \n   *   \n";
        var result = ForLoop.DisplayPatternY();
        result.Should().Be(expected);
    }

    // Exercise 83 - Write a C# Sharp program to display an alphabet pattern like Z with an asterisk.
    [TestMethod]
    public void DisplayPatternZ_ReturnsCorrectZPattern()
    {
        var expected = "*******\n     * \n    *  \n   *   \n  *    \n *     \n*******\n";
        var result = ForLoop.DisplayPatternZ();
        result.Should().Be(expected);
    }
}
