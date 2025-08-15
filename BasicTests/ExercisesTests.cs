using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic;

namespace BasicTests
{
    [TestClass]
    public class ExercisesTests
    {
        // Exercise 11 - Print Age Message

        [TestMethod]
        public void GetAgeMessage_WithAge25()
        {
            // Arrange
            int age = 25;
            string expected = "You look older than 25";

            // Act
            string result = Exercise11.GetAgeMessage(age);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 12 - Repeat Number in Rows

        [TestMethod]

        public void GetNumberPattern()
        {
            // Arrange
            int number = 25;
            string expected = "25 25 25 25\r\n25252525\r\n25 25 25 25\r\n25252525";

            // Act
            string result = Exercise12.GetNumberPattern(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 13 - Rectangle Pattern with Number

        [TestMethod]
        public void GetRectanglePattern()
        {
            // Arrange
            int number = 5;
            string expected = "555\r\n5 5\r\n5 5\r\n5 5\r\n555";

            // Act
            string result = Exercise13.GetRectanglePattern(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 14 - Celsius to Kelvin and Fahrenheit

        [TestMethod]
        public void ConvertCelsiusToKelvin()
        {
            // Arrange
            double celsius = 30;
            double expected = 303;

            // Act
            double result = Exercise14.ConvertToKelvin(celsius);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertCelsiusToFahrenheit()
        {
            // Arrange
            double celsius = 30;
            double expected = 86;

            // Act
            double result = Exercise14.ConvertToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetTemperatureConversions_String()
        {
            // Arrange
            double celsius = 30;
            string expected = "Kelvin = 303\r\nFahrenheit = 86";

            // Act
            string result = Exercise14.GetTemperatureConversions(celsius);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 15 - Remove Character by Index

        [TestMethod]
        public void RemoveCharacterAtIndex_RemoveFirstCharacter()
        {
            // Arrange
            string input = "w3resource";
            int index = 0;
            string expected = "3resource";

            // Act
            string result = Exercise15.RemoveCharacterAtIndex(input, index);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveCharacterAtIndex_RemoveSecondCharacter()
        {
            // Arrange
            string input = "w3resource";
            int index = 1;
            string expected = "wresource";

            // Act
            string result = Exercise15.RemoveCharacterAtIndex(input, index);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveCharacterAtIndex_RemoveLastCharacter()
        {
            // Arrange
            string input = "w3resource";
            int index = 9;
            string expected = "w3resourc";

            // Act
            string result = Exercise15.RemoveCharacterAtIndex(input, index);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 16 - Swap First and Last Characters

        [TestMethod]
        public void SwapFirstToLastCharacter()
        {
            // Arrange
            string input = "w3resource";
            string expected = "e3resourcw";

            // Act
            string result = Exercise16.SwapFirstLastCharacters(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SwapFirst_LastCharacter()
        {
            // Arrange
            string input = "Python";
            string expected = "nythoP";

            // Act
            string result = Exercise16.SwapFirstLastCharacters(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NonSwapFirstLastCharacter()
        {
            // Arrange
            string input = "x";
            string expected = "x";

            // Act
            string result = Exercise16.SwapFirstLastCharacters(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 17 - Add First Character to Front and Back

        [TestMethod]
        public void AddFirstCharFrontAndBack()
        {
            // Arrange
            string input = "The quick brown fox jumps over the lazy dog.";
            string expected = "TThe quick brown fox jumps over the lazy dog.T";

            // Act
            string result = Exercise17.AddFirstCharFrontAndBack(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 18 - Check Positive and Negative Pair

        [TestMethod]
        public void CheckPositiveNegativePair()
        {
            // Arrange
            int first = -5;
            int second = 25;
            bool expected = true;

            // Act
            bool result = Exercise18.CheckPositiveNegativePair(first, second);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 19 - Sum or Triple Sum of Integers

        [TestMethod]
        public void ComputeSum_SameNumbers_ReturnsTripleSum()
        {
            // Arrange
            int a = 2;
            int b = 2;
            int expected = 12;

            // Act
            int result = Exercise19.ComputeSum(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ComputeSum_DifferentNumbers_ReturnsSum()
        {
            // Arrange
            int a = 12;
            int b = 10;
            int expected = 22;

            // Act
            int result = Exercise19.ComputeSum(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ComputeSum_OneNegative_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = 2;
            int expected = -3;

            // Act
            int result = Exercise19.ComputeSum(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        // Exercise 20 - Absolute Difference or Double It

        [TestMethod]
        public void CalculateDifference_FirstGreater_ReturnsDoubleAbsoluteDifference()
        {
            // Arrange
            int a = 15;
            int b = 7;
            int expected = 16;

            // Act
            int result = Exercise20.CalculateDifference(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateDifference_SecondGreater_ReturnsAbsoluteDifference()
        {
            // Arrange
            int a = 5;
            int b = 12;
            int expected = 7;

            // Act
            int result = Exercise20.CalculateDifference(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
