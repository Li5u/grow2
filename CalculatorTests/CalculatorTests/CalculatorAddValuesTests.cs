using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorAddValuesTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(2, 2, 4)]
        [TestCase(2, 5, 7)]
        [TestCase(5, 2, 7)]
        [TestCase(-2, 2, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, -5, -10)]
        public void AddValuesTest(double x, double y, double expected)
        {
            var actualValue = calculator.Add(x, y);
            Assert.AreEqual(expected, actualValue);
        }
    }
}