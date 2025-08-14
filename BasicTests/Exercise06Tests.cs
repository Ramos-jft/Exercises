using Basic;

namespace BasicTests;

[TestClass]
public class Exercise06Tests
{
    [TestMethod]
    public void MultiplyThreeNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        int n1 = 2;
        int n2 = 3;
        int n3 = 6;
        int expected = 36;

        // Act
        int result = Exercise06.MultiplyThreeNumbers(n1, n2, n3);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
