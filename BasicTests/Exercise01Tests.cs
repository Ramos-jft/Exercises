using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basic;

namespace BasicTests
{
    [TestClass]
    public class Exercise01Tests
    {
        [TestMethod]
        public void ShouldReturnHelloAndName()
        {
            // Arrange

            var exercise = new Exercise01();

            // Act

            var result = exercise.Message("Lucas");

            // Assert

            Assert.AreEqual("Hello\nLucas", result);
        }
    }
}
