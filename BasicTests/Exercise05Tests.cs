using Basic;

namespace BasicTests;

[TestClass]
public class Exercise05Tests
{
    [TestMethod]
    public void Swap_TwoNumbers_ShouldSwapValues()
    {
        // Arrange
        int firstNumber = 5;
        int secondNumber = 6;

        // Act
        Exercise05.Swap(ref firstNumber, ref secondNumber);

        // Assert
        Assert.AreEqual(6, firstNumber);
        Assert.AreEqual(5, secondNumber);
    }
}
