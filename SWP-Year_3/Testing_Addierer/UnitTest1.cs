using NUnit.Framework;

namespace HalbaddiererTests
{
    [TestFixture]
    public class HalbaddiererTests
    {
        [TestCase(0, 0, 0, 0)] // Input: x=0, y=0 -> Output: S=0, C=0
        [TestCase(1, 0, 1, 0)] // Input: x=1, y=0 -> Output: S=1, C=0
        [TestCase(0, 1, 1, 0)] // Input: x=0, y=1 -> Output: S=1, C=0
        [TestCase(1, 1, 0, 1)] // Input: x=1, y=1 -> Output: S=0, C=1
        public void HalfAdder_ValidInputs_ReturnsExpectedOutput(int x, int y, int expectedS, int expectedC)
        {
            // Arrange
            var halbaddierer = new Halbaddierer();

            // Act
            var result = halbaddierer.HalfAdder(x, y);

            // Assert
            Assert.AreEqual((expectedS, expectedC), result,
                $"Expected S={expectedS}, C={expectedC} for input ({x}, {y})");
        }
    }
}
