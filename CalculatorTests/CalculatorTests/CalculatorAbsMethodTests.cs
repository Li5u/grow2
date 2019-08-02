using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    class ClassCalculatorAbsMethodTests
    {
        private Calculator calculator;

        [OneTimeSetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(2, 2)]
        [TestCase(-2, 2)]
        [TestCase(0, 0)]
       
        public void AbsMethodTest(double x, double expected)
        {
            var actualValue = calculator.Abs(x);
            Assert.AreEqual(expected, actualValue);
        }
    }
}
