using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace katas.tests
{
    [TestClass]
    public class Asciis
    {
        [TestMethod]
        public void Verify_Calculator_Sums_Ascii()
        {
            // Arrange
            var text = "iffy";

            // Act
            var result = Ascii.Sum(text);

            // Assert
            Assert.AreEqual(220, result);
        }

        [TestMethod]
        public void Verify_Calculator_On_Quote()
        {
            // Arrange
            var text = "Work hard to improve. Success is also easy to handle: You've solved the wrong problem. Work hard to improve.";

            // Act
            var result = Ascii.Sum(text);

            // Assert
            Assert.AreEqual(2593, result);
        }

        [TestMethod]
        public void Verify_Calculator_01()
        {
            // Arrange
            var text = "Work.";

            // Act
            var result = Ascii.Sum(text);

            // Assert
            Assert.AreEqual(197, result);
        }
    }
}