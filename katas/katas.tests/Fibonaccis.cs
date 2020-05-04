using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace katas.tests
{
    [TestClass]
    public class Fibonaccis
    {
        [TestMethod]
        public void Verify_Fibonacci_01()
        {
            // Arrange
            var max = 4;

            // Act
            var result = Fibonacci.SumOfOddNumbers(max);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Verify_Fibonacci_02()
        {
            // Arrange
            var max = 12000;

            // Act
            var result = Fibonacci.SumOfOddNumbers(max);
            var abs = Math.Abs(result);

            // Assert
            Assert.AreEqual(14328d, abs);
        }

        [TestMethod]
        public void Verify_Fibonacci_03()
        {
            // Arrange
            var max = 10001;

            // Act
            var result = Fibonacci.SumOfOddNumbers(max);
            var abs = Math.Abs(result);

            // Assert
            Assert.AreEqual(14328d, abs);
        }

        [TestMethod]
        public void Verify_Fibonacci_04()
        {
            // Arrange
            var max = 10000;

            // Act
            var result = Fibonacci.SumOfOddNumbers(max);
            var abs = Math.Abs(result);

            // Assert
            Assert.AreEqual(14328d, abs);
        }

        [TestMethod]
        public void Verify_Fibonacci_05()
        {
            // Arrange
            var max = 5;

            // Act
            var result = Fibonacci.SumOfOddNumbers(max);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Verify_Fibonacci_06()
        {
            // Arrange

            // Act
            var first = Fibonacci.SumOfOddNumbers(10002);
            var second = Fibonacci.SumOfOddNumbers(10000);

            // Assert
            Assert.AreEqual(first, second);
            Assert.AreEqual(14328, first);
        }

        [TestMethod]
        public void Verify_Fibonacci()
        {
            // Arrange
            var max = 4;

            // Act
            var result = Fibonacci.ToSequence(max);

            // Assert
            Assert.AreEqual(2, result.Last());
        }
    }
}