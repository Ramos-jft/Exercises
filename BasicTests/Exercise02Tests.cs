using System;
using Basic;
using Microsoft.ApplicationInsights;

namespace BasicTests;

[TestClass]
public class Exercise02Tests
{
    [TestMethod]
    public void SumOfTwoNumbers()
    {
        // Arrange
        int n1 = 8;
        int n2 = 5;
        int expected = 13;

        // Act
        int result = Exercise02.Sum(n1, n2);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
