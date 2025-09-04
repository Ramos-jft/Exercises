using FluentAssertions;
using System.Net;
using static Exercises.ExceptionHandling;

namespace ExercisesTests;

[TestClass]
public class ExceptionHandlingTests
{
    /* Exercise 1 - Write a C# program that prompts the user to input two numbers and divides them. 
       Handle an exception when the user enters non-numeric values.*/

    [TestMethod]
    public void DivideNumbers_WithValidNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var firstInput = "10";
        var secondInput = "2";

        // Act
        var result = Exercises.ExceptionHandling.DivideNumbers(firstInput, secondInput);

        // Assert
        result.Should().Be(5.0);
    }

    [TestMethod]
    public void DivideNumbers_WithDecimalNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var firstInput = "1";
        var secondInput = "2";

        // Act
        var result = Exercises.ExceptionHandling.DivideNumbers(firstInput, secondInput);

        // Assert
        result.Should().Be(0.5);
    }

    [TestMethod]
    public void DivideNumbers_WithZeroDividend_ReturnsZero()
    {
        // Arrange
        var firstInput = "0";
        var secondInput = "12";

        // Act
        var result = Exercises.ExceptionHandling.DivideNumbers(firstInput, secondInput);

        // Assert
        result.Should().Be(0.0);
    }

    [TestMethod]
    public void DivideNumbers_WithFirstNonNumericInput_ThrowsFormatException()
    {
        // Arrange
        var firstInput = "a";
        var secondInput = "2";

        // Act
        Action act = () => Exercises.ExceptionHandling.DivideNumbers(firstInput, secondInput);

        // Assert
        act.Should().Throw<FormatException>()
            .WithMessage("Non-numeric value entered.");
    }

    [TestMethod]
    public void DivideNumbers_WithSecondNonNumericInput_ThrowsFormatException()
    {
        // Arrange
        var firstInput = "5";
        var secondInput = "b";

        // Act
        Action act = () => Exercises.ExceptionHandling.DivideNumbers(firstInput, secondInput);

        // Assert
        act.Should().Throw<FormatException>()
            .WithMessage("Non-numeric value entered.");
    }

    [TestMethod]
    public void DivideNumbers_WithBothNonNumericInputs_ThrowsFormatException()
    {
        // Arrange
        var firstInput = "a";
        var secondInput = "b";

        // Act
        Action act = () => Exercises.ExceptionHandling.DivideNumbers(firstInput, secondInput);

        // Assert
        act.Should().Throw<FormatException>()
            .WithMessage("Non-numeric value entered.");
    }

    [TestMethod]
    public void DivideNumbers_WithZeroDivisor_ThrowsDivideByZeroException()
    {
        // Arrange
        var firstInput = "5";
        var secondInput = "0";

        // Act
        Action act = () => Exercises.ExceptionHandling.DivideNumbers(firstInput, secondInput);

        // Assert
        act.Should().Throw<DivideByZeroException>()
            .WithMessage("Cannot divide by zero.");
    }

    /* Exercise 2 - Write a C# program to implement a method that takes an integer as input 
    and throws an exception if the number is negative.Handle the exception in the calling code.*/

    [TestMethod]
    public void ValidatePositiveNumber_WithPositiveInteger_DoesNotThrowException()
    {
        // Arrange
        var number = 12;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidatePositiveNumber(number);

        // Assert
        act.Should().NotThrow();
    }

    [TestMethod]
    public void ValidatePositiveNumber_WithZero_DoesNotThrowException()
    {
        // Arrange
        var number = 0;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidatePositiveNumber(number);

        // Assert
        act.Should().NotThrow();
    }

    [TestMethod]
    public void ValidatePositiveNumber_WithNegativeInteger_ThrowsNegativeNumberException()
    {
        // Arrange
        var number = -34;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidatePositiveNumber(number);

        // Assert
        act.Should().Throw<NegativeNumberException>()
            .WithMessage("Negative number not allowed.");
    }

    [TestMethod]
    public void ValidatePositiveNumber_WithPositiveStringInput_DoesNotThrowException()
    {
        // Arrange
        var input = "12";

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidatePositiveNumber(input);

        // Assert
        act.Should().NotThrow();
    }

    [TestMethod]
    public void ValidatePositiveNumber_WithNonNumericString_ThrowsFormatException()
    {
        // Arrange
        var input = "a";

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidatePositiveNumber(input);

        // Assert
        act.Should().Throw<FormatException>()
            .WithMessage("Invalid input. Please enter an integer.");
    }

    [TestMethod]
    public void ValidatePositiveNumber_WithNegativeStringInput_ThrowsNegativeNumberException()
    {
        // Arrange
        var input = "-34";

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidatePositiveNumber(input);

        // Assert
        act.Should().Throw<NegativeNumberException>()
            .WithMessage("Negative number not allowed.");
    }

    /*Exercise 3 - Write a C# program that reads a file path from the user and tries to open the file. 
      Handle exceptions if the file does not exist.*/

    private string _testFilePath;
    private string _nonExistentFilePath;
    private string _testDirectory;

    [TestInitialize]
    public void Initialize()
    {
        // Arrange (setup geral para todos os testes)
        _testDirectory = Path.GetTempPath();
        _testFilePath = Path.GetTempFileName();
        _nonExistentFilePath = Path.Combine(_testDirectory, "nonexistentfile.txt");
    }

    [TestMethod]
    public void OpenFile_WithExistingFile_DoesNotThrowException()
    {
        // Arrange
        var filePath = _testFilePath;

        // Act
        Action act = () => Exercises.ExceptionHandling.OpenFile(filePath);

        // Assert
        act.Should().NotThrow();
    }

    [TestMethod]
    public void OpenFile_WithNonExistentFile_ThrowsFileNotFoundException()
    {
        // Arrange
        var filePath = _nonExistentFilePath;

        // Act
        Action act = () => Exercises.ExceptionHandling.OpenFile(filePath);

        // Assert
        act.Should().Throw<FileNotFoundException>();
    }

    [TestMethod]
    public void OpenFile_WithNullFilePath_ThrowsArgumentException()
    {
        // Arrange
        string filePath = null;

        // Act
        Action act = () => Exercises.ExceptionHandling.OpenFile(filePath);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("File path cannot be null or empty.");
    }

    [TestMethod]
    public void OpenFile_WithEmptyFilePath_ThrowsArgumentException()
    {
        // Arrange
        var filePath = "";

        // Act
        Action act = () => Exercises.ExceptionHandling.OpenFile(filePath);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("File path cannot be null or empty.");
    }

    [TestMethod]
    public void OpenFile_WithWhitespaceFilePath_ThrowsArgumentException()
    {
        // Arrange
        var filePath = "   ";

        // Act
        Action act = () => Exercises.ExceptionHandling.OpenFile(filePath);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("File path cannot be null or empty.");
    }

    [TestMethod]
    public void OpenFile_WithDirectoryPath_ThrowsIOException()
    {
        // Arrange
        var directoryPath = Path.GetTempPath();

        // Act
        Action act = () => Exercises.ExceptionHandling.OpenFile(directoryPath);

        // Assert
        act.Should().Throw<IOException>();
    }


    /* Exercise 4 - Write a C# program that prompts the user to input a numeric integer and throws an exception 
   if the number is less than 0 or greater than 1000.*/

    [TestMethod]
    public void ValidateNumberInRange_WithValidNumberInMiddleRange_DoesNotThrowException()
    {
        // Arrange
        var number = 500;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidateNumberInRange(number);

        // Assert
        act.Should().NotThrow();
    }

    [TestMethod]
    public void ValidateNumberInRange_WithMinimumBoundaryValue_DoesNotThrowException()
    {
        // Arrange
        var number = 0;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidateNumberInRange(number);

        // Assert
        act.Should().NotThrow();
    }

    [TestMethod]
    public void ValidateNumberInRange_WithMaximumBoundaryValue_DoesNotThrowException()
    {
        // Arrange
        var number = 1000;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidateNumberInRange(number);

        // Assert
        act.Should().NotThrow();
    }

    [TestMethod]
    public void ValidateNumberInRange_WithNegativeNumber_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var number = -1;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidateNumberInRange(number);

        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("Number must be between 0 and 1000.*");    
    }

    [TestMethod]
    public void ValidateNumberInRange_WithNumberAboveMaximum_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var number = 1001;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidateNumberInRange(number);

        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("Number must be between 0 and 1000.*");
    }

    [TestMethod]
    public void ValidateNumberInRange_WithLargeNegativeNumber_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var number = -1000;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidateNumberInRange(number);

        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("Number must be between 0 and 1000.*");
    }

    [TestMethod]
    public void ValidateNumberInRange_WithLargePositiveNumber_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var number = 2000;

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidateNumberInRange(number);

        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("Number must be between 0 and 1000.*");
    }

    [TestMethod]
    public void ValidateNumberInRange_WithValidStringInput_DoesNotThrowException()
    {
        // Arrange
        var input = "500";

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidateNumberInRange(input);

        // Assert
        act.Should().NotThrow();
    }

    [TestMethod]
    public void ValidateNumberInRange_WithNegativeStringInput_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var input = "-1";

        // Act
        Action act = () => Exercises.ExceptionHandling.ValidateNumberInRange(input);

        // Assert
        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("Number must be between 0 and 1000.*");
    }

    /* Exercise 5 - Write a C# program that implements a method that takes an array of 
       integers as input and calculates the average value. Handle the exception if the array is empty.*/

    [TestMethod]
    public void CalculateAverage_WithValidArray_ReturnsCorrectAverage()
    {
        // Arrange
        var numbers = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = Exercises.ExceptionHandling.CalculateAverage(numbers);

        // Assert
        result.Should().Be(3.0);
    }

    [TestMethod]
    public void CalculateAverage_WithSingleElement_ReturnsElementValue()
    {
        // Arrange
        var numbers = new[] { 7 };

        // Act
        var result = Exercises.ExceptionHandling.CalculateAverage(numbers);

        // Assert
        result.Should().Be(7.0);
    }

    [TestMethod]
    public void CalculateAverage_WithNegativeNumbers_ReturnsCorrectAverage()
    {
        // Arrange
        var numbers = new[] { -1, -2, -3, -4, -5 };

        // Act
        var result = Exercises.ExceptionHandling.CalculateAverage(numbers);

        // Assert
        result.Should().Be(-3.0);
    }

    [TestMethod]
    public void CalculateAverage_WithDecimalResult_ReturnsPreciseAverage()
    {
        // Arrange
        var numbers = new[] { 1, 2, 3 };

        // Act
        var result = Exercises.ExceptionHandling.CalculateAverage(numbers);

        // Assert
        result.Should().Be(2.0);
    }

    [TestMethod]
    public void CalculateAverage_WithEmptyArray_ThrowsEmptyArrayException()
    {
        // Arrange
        var numbers = new int[0];

        // Act
        Action act = () => Exercises.ExceptionHandling.CalculateAverage(numbers);

        // Assert
        act.Should().Throw<EmptyArrayException>().WithMessage("Array is empty. Cannot calculate average.");
    }

    [TestMethod]
    public void CalculateAverage_WithNullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] numbers = null;

        // Act
        Action act = () => Exercises.ExceptionHandling.CalculateAverage(numbers);

        // Assert
        act.Should().Throw<ArgumentNullException>().WithMessage("Array cannot be null. (Parameter 'numbers')");
    }

    /* Exercise 6 - Write a C# program that reads a string from the user and converts it to an integer. 
    Handle the exception if the input cannot be parsed into an integer.*/

    [TestMethod]
    public void ConvertToInt_WithValidIntegerString_ReturnsInteger()
    {
        // Arrange
        var input = "123";

        // Act
        var result = Exercises.ExceptionHandling.ConvertToInt(input);

        // Assert
        result.Should().Be(123);
    }

    [TestMethod]
    public void ConvertToInt_WithZeroString_ReturnsZero()
    {
        // Arrange
        var input = "0";

        // Act
        var result = Exercises.ExceptionHandling.ConvertToInt(input);

        // Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void ConvertToInt_WithNegativeIntegerString_ReturnsNegativeInteger()
    {
        // Arrange
        var input = "-456";

        // Act
        var result = Exercises.ExceptionHandling.ConvertToInt(input);

        // Assert
        result.Should().Be(-456);
    }

    [TestMethod]
    public void ConvertToInt_WithMaxValueString_ReturnsMaxValue()
    {
        // Arrange
        var input = int.MaxValue.ToString();

        // Act
        var result = Exercises.ExceptionHandling.ConvertToInt(input);

        // Assert
        result.Should().Be(int.MaxValue);
    }

    [TestMethod]
    public void ConvertToInt_WithMinValueString_ReturnsMinValue()
    {
        // Arrange
        var input = int.MinValue.ToString();

        // Act
        var result = Exercises.ExceptionHandling.ConvertToInt(input);

        // Assert
        result.Should().Be(int.MinValue);
    }

    [TestMethod]
    public void ConvertToInt_WithNonNumericString_ThrowsFormatException()
    {
        // Arrange
        var input = "abc";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToInt(input);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [TestMethod]
    public void ConvertToInt_WithDecimalString_ThrowsFormatException()
    {
        // Arrange
        var input = "123.45";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToInt(input);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [TestMethod]
    public void ConvertToInt_WithEmptyString_ThrowsArgumentException()
    {
        // Arrange
        var input = "";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToInt(input);

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("Input cannot be null or empty.");
    }

    [TestMethod]
    public void ConvertToInt_WithWhitespaceString_ThrowsArgumentException()
    {
        // Arrange
        var input = "   ";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToInt(input);

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("Input cannot be null or empty.");
    }

    /* Exercise 7 - Write a C# program that reads a list of integers from the user. 
    Handle the exception that occurs if the user enters a value outside the range of Int32.*/

    [TestMethod]
    public void ConvertToInt32_WithValidInteger_ReturnsInteger()
    {
        // Arrange
        var input = "645789";

        // Act
        var result = Exercises.ExceptionHandling.ConvertToInt32(input);

        // Assert
        result.Should().Be(645789);
    }

    [TestMethod]
    public void ConvertToInt32_WithMaxInt32Value_ReturnsMaxValue()
    {
        // Arrange
        var input = int.MaxValue.ToString();

        // Act
        var result = Exercises.ExceptionHandling.ConvertToInt32(input);

        // Assert
        result.Should().Be(int.MaxValue);
    }

    [TestMethod]
    public void ConvertToInt32_WithMinInt32Value_ReturnsMinValue()
    {
        // Arrange
        var input = int.MinValue.ToString();

        // Act
        var result = Exercises.ExceptionHandling.ConvertToInt32(input);

        // Assert
        result.Should().Be(int.MinValue);
    }

    [TestMethod]
    public void ConvertToInt32_WithValueAboveMaxInt32_ThrowsOverflowException()
    {
        // Arrange
        var input = "2147483648";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToInt32(input);

        // Assert
        act.Should().Throw<OverflowException>();
    }

    [TestMethod]
    public void ConvertToInt32_WithValueBelowMinInt32_ThrowsOverflowException()
    {
        // Arrange
        var input = "-2147483649";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToInt32(input);

        // Assert
        act.Should().Throw<OverflowException>();
    }

    [TestMethod]
    public void ConvertToInt32_WithNonNumericString_ThrowsFormatException()
    {
        // Arrange
        var input = "abc";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToInt32(input);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [TestMethod]
    public void ConvertToInt32_WithEmptyString_ThrowsArgumentException()
    {
        // Arrange
        var input = "";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToInt32(input);

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("Input cannot be null or empty.");
    }

    [TestMethod]
    public void ReadIntegersFromInput_WithValidIntegers_ReturnsListOfIntegers()
    {
        // Arrange
        var inputs = new List<string> { "645789", "23451", "123", "12", "1" };

        // Act
        var result = Exercises.ExceptionHandling.ReadIntegersFromInput(inputs);

        // Assert
        result.Should().Equal(new List<int> { 645789, 23451, 123, 12, 1 });
    }

    [TestMethod]
    public void ReadIntegersFromInput_WithExitCommand_StopsReadingAndReturnsNumbers()
    {
        // Arrange
        var inputs = new List<string> { "100", "200", "exit", "300" };

        // Act
        var result = Exercises.ExceptionHandling.ReadIntegersFromInput(inputs);

        // Assert
        result.Should().Equal(new List<int> { 100, 200 });
    }

    [TestMethod]
    public void ReadIntegersFromInput_WithOverflowValue_ThrowsOverflowException()
    {
        // Arrange
        var inputs = new List<string> { "100", "2147483648", "200" };

        // Act
        Action act = () => Exercises.ExceptionHandling.ReadIntegersFromInput(inputs);

        // Assert
        act.Should().Throw<OverflowException>();
    }

    /* Exercise 8 - Write a C# program that implements a method that divides two numbers.
    Handle the DivideByZeroException that occurs if the denominator is 0.*/

    [TestMethod]
    public void DivideNumbers_WithValidDivision_ReturnsIntegerResult()
    {
        // Arrange
        var numerator = 4;
        var denominator = 3;

        // Act
        var result = Exercises.ExceptionHandling.DivideNumbers(numerator, denominator);

        // Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void DivideNumbers_WithZeroNumerator_ReturnsZero()
    {
        // Arrange
        var numerator = 0;
        var denominator = 12;

        // Act
        var result = Exercises.ExceptionHandling.DivideNumbers(numerator, denominator);

        // Assert
        result.Should().Be(0);
    }

    [TestMethod]
    public void DivideNumbers_WithExactDivision_ReturnsExactResult()
    {
        // Arrange
        var numerator = 12;
        var denominator = 4;

        // Act
        var result = Exercises.ExceptionHandling.DivideNumbers(numerator, denominator);

        // Assert
        result.Should().Be(3);
    }

    [TestMethod]
    public void DivideNumbers_WithNegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var numerator = -10;
        var denominator = 2;

        // Act
        var result = Exercises.ExceptionHandling.DivideNumbers(numerator, denominator);

        // Assert
        result.Should().Be(-5);
    }

    [TestMethod]
    public void DivideNumbers_WithBothNegativeNumbers_ReturnsPositiveResult()
    {
        // Arrange
        var numerator = -12;
        var denominator = -4;

        // Act
        var result = Exercises.ExceptionHandling.DivideNumbers(numerator, denominator);

        // Assert
        result.Should().Be(3);
    }

    [TestMethod]
    public void DivideNumbers_WithZeroDenominator_ThrowsDivideByZeroException()
    {
        // Arrange
        var numerator = 12;
        var denominator = 0;

        // Act
        Action act = () => Exercises.ExceptionHandling.DivideNumbers(numerator, denominator);

        // Assert
        act.Should().Throw<DivideByZeroException>().WithMessage("Division by zero is not allowed.");
    }

    [TestMethod]
    public void DivideNumbers_WithZeroNumeratorAndDenominator_ThrowsDivideByZeroException()
    {
        // Arrange
        var numerator = 0;
        var denominator = 0;

        // Act
        Action act = () => Exercises.ExceptionHandling.DivideNumbers(numerator, denominator);

        // Assert
        act.Should().Throw<DivideByZeroException>().WithMessage("Division by zero is not allowed.");
    }

    /* Exercise 9 - Write a C# program that creates a method that reads a date from the user in the format "dd/mm/yyyy" 
    and converts it to a DateTime object. Handle an exception if the input format is invalid.*/

    [TestMethod]
    public void ConvertToDate_WithValidDate_ReturnsDateTime()
    {
        // Arrange
        var input = "11/01/2019";
        var expectedDate = new DateTime(2019, 1, 11);

        // Act
        var result = Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        result.Should().Be(expectedDate);
    }

    [TestMethod]
    public void ConvertToDate_WithValidDateWithSingleDigits_ReturnsDateTime()
    {
        // Arrange
        var input = "01/01/2019";
        var expectedDate = new DateTime(2019, 1, 1);

        // Act
        var result = Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        result.Should().Be(expectedDate);
    }

    [TestMethod]
    public void ConvertToDate_WithLeapYearDate_ReturnsDateTime()
    {
        // Arrange
        var input = "29/02/2020";
        var expectedDate = new DateTime(2020, 2, 29);

        // Act
        var result = Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        result.Should().Be(expectedDate);
    }

    [TestMethod]
    public void ConvertToDate_WithInvalidMonth_ThrowsFormatException()
    {
        // Arrange
        var input = "11/14/2019";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [TestMethod]
    public void ConvertToDate_WithInvalidDay_ThrowsFormatException()
    {
        // Arrange
        var input = "32/01/2019";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [TestMethod]
    public void ConvertToDate_WithZeroValues_ThrowsFormatException()
    {
        // Arrange
        var input = "00/00/2019";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [TestMethod]
    public void ConvertToDate_WithWrongSeparator_ThrowsFormatException()
    {
        // Arrange
        var input = "01-01-2019";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [TestMethod]
    public void ConvertToDate_WithEmptyString_ThrowsArgumentException()
    {
        // Arrange
        var input = "";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("Input cannot be null or empty.");
    }

    [TestMethod]
    public void ConvertToDate_WithWhitespaceString_ThrowsArgumentException()
    {
        // Arrange
        var input = "   ";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        act.Should().Throw<ArgumentException>().WithMessage("Input cannot be null or empty.");
    }

    [TestMethod]
    public void ConvertToDate_WithNonLeapYearFebruary29_ThrowsFormatException()
    {
        // Arrange
        var input = "29/02/2019";

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToDate(input);

        // Assert
        act.Should().Throw<FormatException>();
    }

    [TestMethod]
    public void TryConvertToDate_WithValidDate_ReturnsTrueAndSetsResult()
    {
        // Arrange
        var input = "15/07/2023";
        var expectedDate = new DateTime(2023, 7, 15);

        // Act
        var success = Exercises.ExceptionHandling.TryConvertToDate(input, out var result);

        // Assert
        success.Should().BeTrue();
        result.Should().Be(expectedDate);
    }

    /* Exercise 10 - Write a C# program that reads a number from the user and calculates its square root. 
    Handle the exception if the number is negative.*/

    [TestMethod]
    public void CalculateSquareRoot_WithPositiveNumber_ReturnsCorrectSquareRoot()
    {
        // Arrange
        var number = 12.0;
        var expected = 3.4641016151377544;

        // Act
        var result = Exercises.ExceptionHandling.CalculateSquareRoot(number);

        // Assert
        result.Should().Be(3.4641016151377544);
    }

    [TestMethod]
    public void CalculateSquareRoot_WithPerfectSquare_ReturnsExactValue()
    {
        // Arrange
        var number = 100.0;
        var expected = 10.0;

        // Act
        var result = Exercises.ExceptionHandling.CalculateSquareRoot(number);

        // Assert
        result.Should().Be(10.0);
    }

    [TestMethod]
    public void CalculateSquareRoot_WithZero_ReturnsZero()
    {
        // Arrange
        var number = 0.0;
        var expected = 0.0;

        // Act
        var result = Exercises.ExceptionHandling.CalculateSquareRoot(number);

        // Assert
        result.Should().Be(0.0);
    }

    [TestMethod]
    public void CalculateSquareRoot_WithNegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        var number = -25.0;

        // Act
        Action act = () => Exercises.ExceptionHandling.CalculateSquareRoot(number);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("Number cannot be negative.");
    }

    [TestMethod]
    public void CalculateSquareRoot_WithStringInputNegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        var input = "-25";

        // Act
        Action act = () => Exercises.ExceptionHandling.CalculateSquareRoot(input);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("Number cannot be negative.");
    }

    [TestMethod]
    public void CalculateSquareRoot_WithStringInputInvalidFormat_ThrowsFormatException()
    {
        // Arrange
        var input = "abc";

        // Act
        Action act = () => Exercises.ExceptionHandling.CalculateSquareRoot(input);

        // Assert
        act.Should().Throw<FormatException>()
            .WithMessage("Invalid input. Please input a valid number.");
    }

    [TestMethod]
    public void CalculateSquareRoot_WithEmptyStringInput_ThrowsArgumentException()
    {
        // Arrange
        var input = "";

        // Act
        Action act = () => Exercises.ExceptionHandling.CalculateSquareRoot(input);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("Input cannot be null or empty.");
    }

    /* Exercise 11 - Write a C# program that creates a method that takes a string as input and converts it to uppercase. 
    Handle the NullReferenceException that occurs if the input string is null.*/

    [TestMethod]
    public void ConvertToUppercase_WithValidString_ReturnsUppercase()
    {
        // Arrange
        var input = "java";

        // Act
        var result = Exercises.ExceptionHandling.ConvertToUppercase(input);

        // Assert
        result.Should().Be("JAVA");
    }

    [TestMethod]
    public void ConvertToUppercase_WithMixedCaseString_ReturnsUppercase()
    {
        // Arrange
        var input = "Java";

        // Act
        var result = Exercises.ExceptionHandling.ConvertToUppercase(input);

        // Assert
        result.Should().Be("JAVA");
    }

    [TestMethod]
    public void ConvertToUppercase_WithNullString_ThrowsNullReferenceException()
    {
        // Arrange
        string input = null;

        // Act
        Action act = () => Exercises.ExceptionHandling.ConvertToUppercase(input);

        // Assert
        act.Should().Throw<NullReferenceException>()
            .WithMessage("Input string is null.");
    }

    [TestMethod]
    public void ConvertToUppercase_WithEmptyString_ReturnsEmptyString()
    {
        // Arrange
        var input = "";

        // Act
        var result = Exercises.ExceptionHandling.ConvertToUppercase(input);

        // Assert
        result.Should().Be("");
    }

    [TestMethod]
    public void ConvertToUppercase_WithWhitespaceString_ReturnsWhitespace()
    {
        // Arrange
        var input = "   ";

        // Act
        var result = Exercises.ExceptionHandling.ConvertToUppercase(input);

        // Assert
        result.Should().Be("   ");
    }

    /* Exercise 12 - Write a C# program that creates a method that calculates the factorial of a given number. 
    Handle the OverflowException that occurs if the result exceeds the Int32 maximum value.*/

    [TestMethod]
    public void CalculateFactorial_WithZero_ReturnsOne()
    {
        // Arrange
        var number = 0;

        // Act
        var result = Exercises.ExceptionHandling.CalculateFactorial(number);

        // Assert
        result.Should().Be(1);
    }

    [TestMethod]
    public void CalculateFactorial_WithFive_ReturnsOneHundredTwenty()
    {
        // Arrange
        var number = 5;

        // Act
        var result = Exercises.ExceptionHandling.CalculateFactorial(number);

        // Assert
        result.Should().Be(120);
    }

    [TestMethod]
    public void CalculateFactorial_WithNegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        var number = -7;

        // Act
        Action act = () => Exercises.ExceptionHandling.CalculateFactorial(number);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("Number must be non-negative.");
    }

    [TestMethod]
    public void CalculateFactorial_WithLargeNumber_ThrowsOverflowException()
    {
        // Arrange
        var number = 13;

        // Act
        Action act = () => Exercises.ExceptionHandling.CalculateFactorial(number);

        // Assert
        act.Should().Throw<OverflowException>();
    }

    /* Exercise 13 - Write a C# program that reads a list of URLs from the user and downloads the content of each URL. 
    Handle the exception if any URL is inaccessible.*/

    [TestMethod]
    public void DownloadContent_WithValidUrl_ReturnsContent()
    {
        // Arrange
        var url = "https://httpbin.org/json";

        // Act
        var result = Exercises.ExceptionHandling.DownloadContent(url);

        // Assert
        result.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void DownloadContent_WithEmptyUrl_ThrowsArgumentException()
    {
        // Arrange
        var url = "";

        // Act
        Action act = () => Exercises.ExceptionHandling.DownloadContent(url);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("URL cannot be null or empty.");
    }

    [TestMethod]
    public void DownloadContent_WithNullUrl_ThrowsArgumentException()
    {
        // Arrange
        string url = null;

        // Act
        Action act = () => Exercises.ExceptionHandling.DownloadContent(url);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("URL cannot be null or empty.");
    }

    [TestMethod]
    public void DownloadContent_WithInvalidUrl_ThrowsWebException()
    {
        // Arrange
        var url = "https://invalid-domain-that-does-not-exist-12345.com";

        // Act
        Action act = () => Exercises.ExceptionHandling.DownloadContent(url);

        // Assert
        act.Should().Throw<WebException>();
    }
}
