using NUnit.Framework;
using MyConsoleApp;

namespace MyConsoleApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSum()
        {
            var result = _calculator.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsDifference()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsProduct()
        {
            var result = _calculator.Multiply(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Divide_WhenCalled_ReturnsQuotient()
        {
            var result = _calculator.Divide(6, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void PerformOperation_WithInvalidOperation_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _calculator.PerformOperation(2, 3, "^"));
        }

        /*[Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }*/
    }
}

