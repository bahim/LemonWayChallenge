using ChallengeLib;
using NUnit.Framework;
using System;

namespace Challenge.Test
{
    [TestFixture]
    public class FibonacciTest
    {
        [TestCase(30, 832040)]
        [TestCase(23, 28657)]
        [TestCase(17, 1597)]
        [TestCase(11, 89)]
        [TestCase(1, 1)]
        public void FibonacciNumberWithinAllowedRangeTest(int sequenceSize, int expected)
        {
            // Arrange
            var fibo = new Fibonacci(100);

            // Act
            var fiboNbr = fibo.Compute(sequenceSize);

            // Assert
            Assert.AreEqual(expected, fiboNbr);
        }

        [Test]
        public void ConstructorArgumentLowerThanZeroTest()
        {
            Assert.Throws<ArgumentException>(() => new Fibonacci(0));
        }

        [Test]
        public void FibonacciNumberPositionlowerthanOneTest()
        {
            var fibo = new Fibonacci(100);

            Assert.Throws<ArgumentException>(() => fibo.Compute(0));
        }

        [Test]
        public void FibonacciNumberPositionGreaterThanLimitMaxTest()
        {
            var fibo = new Fibonacci(100);

            Assert.Throws<ArgumentException>(() => fibo.Compute(101));
        }

    }
}
