using Basic;

namespace BasicTests;

[TestClass]
public class Exercise03Tests
{
    [TestMethod]
    public void DivideTwoNumbers()
    {
        // Arrange
        int n1 = 10;
        int n2 = 5;
        int expected = 2;

        // Act
        int result = Exercise03.Divide(n1, n2);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
