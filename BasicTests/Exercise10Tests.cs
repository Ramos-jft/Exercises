using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic;

namespace BasicTests
{
    [TestClass]
    public class FormulaCalculationsTests
    {
        [TestMethod]
        public void CalculateFirstFormula_WithSampleNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int x = 5;
            int y = 6;
            int z = 7;
            int expected = 77; // (5+6)*7 = 77

            // Act
            int result = Exercise10.CalculateFirstFormula(x, y, z);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSecondFormula_WithSampleNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int x = 5;
            int y = 6;
            int z = 7;
            int expected = 72; // 5*6 + 6*7 = 30 + 42 = 72

            // Act
            int result = Exercise10.CalculateSecondFormula(x, y, z);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetFormulasOutput_WithSampleNumbers_ReturnsCorrectString()
        {
            // Arrange
            int x = 5;
            int y = 6;
            int z = 7;
            string expected = "Result of specified formulas:\r\n" +
                            "(x + y).z = 77\r\n" +
                            "x.y + y.z = 72";

            // Act
            string result = Exercise10.GetFormulasOutput(x, y, z);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
