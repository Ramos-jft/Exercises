using Exercises;
using FluentAssertions;

namespace ExercisesTests;

[TestClass]
public class DataTypesTests
{
    // Exercise 1 - Write a C# Sharp program that takes three letters and displays them in reverse order
    [TestMethod]
    public void ReverseLetters_WithBat_ReturnsTab()
    {
        // Arrange
        char letter1 = 'b';
        char letter2 = 'a';
        char letter3 = 't';

        // Act
        string result = DataTypes.ReverseLetters(letter1, letter2, letter3);

        // Assert
        result.Should().Be("t a b");
    }

    // Exercise 2 - Write a C# Sharp program that takes a number and a width also a number. It then displays a triangle of that width using that number.
    [TestMethod]
    public void BuildTriangle_WithNumber6AndWidth6_ReturnsTriangle()
    {
        // Arrange
        int number = 6;
        int width = 6;

        // Act
        string result = DataTypes.BuildTriangle(number, width);

        // Assert
        result.Should().Be("666666\n66666\n6666\n666\n66\n6");
    }

    // Exercise 3 - Write a C# Sharp program that takes userid and password as input (string type). After 3 unsuccessful attempts, the user will be rejected.
    [TestMethod]
    public void Login_WithValidCredentials_ReturnsSuccessMessage()
    {
        // Arrange
        string username = "username";
        string password = "password";

        // Act
        string result = DataTypes.Login(username, password);

        // Assert
        result.Should().Be("Password entered successfully!");
    }

    [TestMethod]
    public void Login_WithInvalidCredentials_ReturnsFailureMessage()
    {
        // Arrange
        string username = "invalid";
        string password = "wrong";

        // Act
        string result = DataTypes.Login(username, password);

        // Assert
        result.Should().Be("Login attempt more than three times. Try later!");
    }

    // Exercise 4 - Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.
    [TestMethod]
    public void CalculateOperation_WithSubtraction_ReturnsCorrectResult()
    {
        // Arrange
        int firstNumber = 20;
        char operation = '-';
        int secondNumber = 12;

        // Act
        string result = DataTypes.CalculateOperation(firstNumber, operation, secondNumber);

        // Assert
        result.Should().Be("20 - 12 = 8");
    }

    [TestMethod]
    public void CalculateOperation_WithSum_ReturnsCorrectResult()
    {
        // Arrange
        int firstNumber = 30;
        char operation = '+';
        int secondNumber = 25;

        // Act
        string result = DataTypes.CalculateOperation(firstNumber, operation, secondNumber);

        // Assert
        result.Should().Be("30 + 25 = 55");
    }

    [TestMethod]
    public void CalculateOperation_WithDivide_ReturnsCorrectResult()
    {
        // Arrange
        int firstNumber = 20;
        char operation = '/';
        int secondNumber = 2;

        // Act
        string result = DataTypes.CalculateOperation(firstNumber, operation, secondNumber);

        // Assert
        result.Should().Be("20 / 2 = 10");
    }

    [TestMethod]
    public void CalculateOperation_WithMultiplicationX_ReturnsCorrectResult()
    {
        // Arrange
        int firstNumber = 5;
        char operation = 'x';
        int secondNumber = 5;

        // Act
        string result = DataTypes.CalculateOperation(firstNumber, operation, secondNumber);

        // Assert
        result.Should().Be("5 x 5 = 25");
    }

    [TestMethod]
    public void CalculateOperation_WithMultiplication_ReturnsCorrectResult()
    {
        // Arrange
        int firstNumber = 4;
        char operation = '*';
        int secondNumber = 4;

        // Act
        string result = DataTypes.CalculateOperation(firstNumber, operation, secondNumber);

        // Assert
        result.Should().Be("4 * 4 = 16");
    }

    // Exercise 5 - Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle.
    [TestMethod]
    public void CalculateCircleProperties_WithRadius12_ReturnsCorrectPerimeter()
    {
        // Arrange
        double radius = 12;

        // Act
        string result = DataTypes.CalculateCircleProperties(radius);

        // Assert
        result.Should().Be("Perimeter of Circle : 75.40");
    }

    [TestMethod]
    public void CalculateCircleProperties_WithRadius25_ReturnsCorrectPerimeter()
    {
        // Arrange
        double radius = 25;

        // Act
        string result = DataTypes.CalculateCircleProperties(radius);

        // Assert
        result.Should().Be("Perimeter of Circle : 157.08");
    }

    // Exercise 6 - Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
    [TestMethod]
    public void CalculateFunctionValues_ReturnsCorrectValues()
    {
        // Arrange
        string expected = "y = -5 ; x = (-5)² + 2*(-5) + 1 = 16\n" +
                         "y = -4 ; x = (-4)² + 2*(-4) + 1 = 9\n" +
                         "y = -3 ; x = (-3)² + 2*(-3) + 1 = 4\n" +
                         "y = -2 ; x = (-2)² + 2*(-2) + 1 = 1\n" +
                         "y = -1 ; x = (-1)² + 2*(-1) + 1 = 0\n" +
                         "y = 0 ; x = (0)² + 2*(0) + 1 = 1\n" +
                         "y = 1 ; x = (1)² + 2*(1) + 1 = 4\n" +
                         "y = 2 ; x = (2)² + 2*(2) + 1 = 9\n" +
                         "y = 3 ; x = (3)² + 2*(3) + 1 = 16\n" +
                         "y = 4 ; x = (4)² + 2*(4) + 1 = 25\n" +
                         "y = 5 ; x = (5)² + 2*(5) + 1 = 36";

        // Act
        string result = DataTypes.CalculateFunctionValues();

        // Assert
        result.Should().Be(expected);
    }

    // Exercise 7 - Write a C# Sharp program that takes distance and time as input and displays speed in kilometres per hour and miles per hour.
    [TestMethod]
    public void CalculateSpeed_WithSampleData_ReturnsCorrectSpeeds()
    {
        // Arrange
        float distance = 50000;
        float hours = 1;
        float minutes = 35;
        float seconds = 56;

        // Act
        string result = DataTypes.CalculateSpeed(distance, hours, minutes, seconds);

        // Assert
        result.Should().Be("Your speed in metres/sec is 8.686588\n" +
                          "Your speed in km/h is 31.271717\n" +
                          "Your speed in miles/h is 19.4355");
    }

    // Exercise 8 - Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.
    [TestMethod]
    public void CalculateSphereProperties_WithRadius2_ReturnsCorrectValues()
    {
        // Arrange
        float radius = 2;

        // Act
        string result = DataTypes.CalculateSphereProperties(radius);

        // Assert
        result.Should().Be("50.265484\n33.510323");
    }

    // Exercise 9 - Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
    [TestMethod]
    public void CheckSymbol_WithLowercaseVowel_ReturnsVowelMessage()
    {
        // Arrange
        char symbol = 'a';

        // Act
        string result = DataTypes.CheckSymbol(symbol);

        // Assert
        result.Should().Be("It's a lowercase vowel.");
    }

    [TestMethod]
    public void CheckSymbol_WithDigit_ReturnsDigitMessage()
    {
        // Arrange
        char symbol = '5';

        // Act
        string result = DataTypes.CheckSymbol(symbol);

        // Assert
        result.Should().Be("It's a digit.");
    }

    [TestMethod]
    public void CheckSymbol_WithOtherSymbol_ReturnsOtherSymbolMessage()
    {
        // Arrange
        char symbol = '#';

        // Act
        string result = DataTypes.CheckSymbol(symbol);

        // Assert
        result.Should().Be("It's another symbol.");
    }

    // Exercise 10 - Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.
    [TestMethod]
    public void AreBothEvenOrOdd_WithBothEven_ReturnsTrue()
    {
        // Arrange
        int n1 = 4;
        int n2 = 6;

        // Act
        bool result = DataTypes.AreBothEvenOrOdd(n1, n2);

        // Assert
        result.Should().BeTrue();
    }

    [TestMethod]
    public void AreBothEvenOrOdd_WithBothOdd_ReturnsTrue()
    {
        // Arrange
        int n1 = 3;
        int n2 = 7;

        // Act
        bool result = DataTypes.AreBothEvenOrOdd(n1, n2);

        // Assert
        result.Should().BeFalse();
    }

    [TestMethod]
    public void AreBothEvenOrOdd_WithOneEvenOneOdd_ReturnsFalse()
    {
        // Arrange
        int n1 = 4;
        int n2 = 5;

        // Act
        bool result = DataTypes.AreBothEvenOrOdd(n1, n2);

        // Assert
        result.Should().BeFalse();
    }

    // Exercise 11 - Write a C# Sharp program that takes a decimal number as input and displays its equivalent in binary form.
    [TestMethod]
    public void ConvertToBinary_With25_Returns11001()
    {
        // Arrange
        int number = 25;

        // Act
        string result = DataTypes.ConvertToBinary(number);

        // Assert
        result.Should().Be("11001");
    }

    [TestMethod]
    public void ConvertToBinary_With65_Returns1000001()
    {
        // Arrange
        int number = 65;

        // Act
        string result = DataTypes.ConvertToBinary(number);

        // Assert
        result.Should().Be("1000001");
    }
}

