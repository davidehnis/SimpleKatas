using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace katas.tests
{
    [TestClass]
    public class Legions
    {
        [TestMethod]
        public void Verify_Roman_Numerals()
        {
            // Arrange
            var ch = 'X';

            // Act
            var result = Legion.CountOccurrences(1, 2660, ch);

            // Assert
            Assert.AreEqual(3977, result);
        }

        [TestMethod]
        public void Verify_Roman_Numerals_01()
        {
            // Arrange
            var ch = 'X';

            // Act
            var result = Legion.CountOccurrences(1, 10, ch);

            // Assert
            Assert.AreEqual(2, result);
        }
    }
}