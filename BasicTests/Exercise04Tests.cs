using Basic;

namespace BasicTests;

[TestClass]
public class Exercise04Tests
{
        [TestMethod]
        public void Calculate_Operation1_ReturnsCorrectResult()
        {
            // Arrange
            string operation = "-1 + 4 * 6";
            double expected = 23;

            // Act
            double result = Exercise04.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_Operation2_ReturnsCorrectResult()
        {
            // Arrange
            string operation = "( 35 + 5 ) % 7";
            double expected = 5;

            // Act
            double result = Exercise04.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_Operation3_ReturnsCorrectResult()
        {
            // Arrange
            string operation = "14 + ( -4 * 6 ) / 11";
            double expected = 11.82;

            // Act
            double result = Exercise04.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_Operation4_ReturnsCorrectResult()
        {
            // Arrange
            string operation = "2 + ( 15 / 6 ) * 1 - ( 7 % 2 )";
            double expected = 3.5;

            // Act
            double result = Exercise04.Calculate(operation);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
