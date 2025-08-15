using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic;

namespace BasicTests
{
    [TestClass]
    public class ArithmeticOperationsTests
    {
        [TestMethod]
        public void AddTwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 25;
            int b = 4;
            int expected = 29;

            // Act
            int result = Exercise07.AddTwoNumbers(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SubtractTwoNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int a = 25;
            int b = 4;
            int expected = 21;

            // Act
            int result = Exercise07.SubtractTwoNumbers(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int a = 25;
            int b = 4;
            int expected = 100;

            // Act
            int result = Exercise07.MultiplyTwoNumbers(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DivideTwoNumbers_ReturnsIntegerResult()
        {
            // Arrange
            int a = 25;
            int b = 4;
            int expected = 6;

            // Act
            int result = Exercise07.DivideTwoNumbers(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ModulusTwoNumbers_ReturnsCorrectRemainder()
        {
            // Arrange
            int a = 25;
            int b = 4;
            int expected = 1;

            // Act
            int result = Exercise07.ModulusTwoNumbers(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetOperationResults_ReturnsFormattedString()
        {
            // Arrange
            int a = 25;
            int b = 4;
            string expected = "25 + 4 = 29\r\n" +
                             "25 - 4 = 21\r\n" +
                             "25 x 4 = 100\r\n" +
                             "25 / 4 = 6\r\n" +
                             "25 mod 4 = 1";

            // Act
            string result = Exercise07.GetOperationResults(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
