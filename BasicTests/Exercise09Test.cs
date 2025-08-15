using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic;

namespace BasicTests
{
    [TestClass]
    public class AverageCalculationTests
    {
        [TestMethod]
        public void CalculateAverage_FourNumbers_ReturnsCorrectAverage()
        {
            // Arrange
            int num1 = 10;
            int num2 = 15;
            int num3 = 20;
            int num4 = 30;
            double expected = 18.75;

            // Act
            double result = Exercise09.CalculateAverage(num1, num2, num3, num4);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
