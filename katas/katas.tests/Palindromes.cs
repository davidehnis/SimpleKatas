using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace katas.tests
{
    [TestClass]
    public class Palindromes
    {
        [TestMethod]
        public void Verify_Palindrome_Sum()
        {
            // Act
            var result = Palindrome.Sum(1, 1);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Verify_Palindrome_Sum_01()
        {
            // Act
            var result = Palindrome.Sum(1, 2);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Verify_Palindrome_Sum_02()
        {
            // Act
            var result = Palindrome.Sum(1, 9999);

            // Assert
            Assert.AreEqual(545040, result);
        }
    }
}