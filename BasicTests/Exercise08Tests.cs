using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic;

namespace BasicTests
{
    [TestClass]
    public class MultiplicationTableTests
    {
        [TestMethod]
        public void GenerateTable_ForNumber5_ReturnsCorrectTable()
        {
            // Arrange
            int number = 5;
            string expected = "5 * 0 = 0\r\n" +
                            "5 * 1 = 5\r\n" +
                            "5 * 2 = 10\r\n" +
                            "5 * 3 = 15\r\n" +
                            "5 * 4 = 20\r\n" +
                            "5 * 5 = 25\r\n" +
                            "5 * 6 = 30\r\n" +
                            "5 * 7 = 35\r\n" +
                            "5 * 8 = 40\r\n" +
                            "5 * 9 = 45\r\n" +
                            "5 * 10 = 50";

            // Act
            string result = Exercise08.GenerateMultiplicationTable(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GenerateTable_ForNumber0_ReturnsAllZeros()
        {
            // Arrange
            int number = 0;
            string expected = "0 * 0 = 0\r\n" +
                            "0 * 1 = 0\r\n" +
                            "0 * 2 = 0\r\n" +
                            "0 * 3 = 0\r\n" +
                            "0 * 4 = 0\r\n" +
                            "0 * 5 = 0\r\n" +
                            "0 * 6 = 0\r\n" +
                            "0 * 7 = 0\r\n" +
                            "0 * 8 = 0\r\n" +
                            "0 * 9 = 0\r\n" +
                            "0 * 10 = 0";

            // Act
            string result = Exercise08.GenerateMultiplicationTable(number);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
