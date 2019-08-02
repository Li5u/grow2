using CSharpCalculator;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
    [TestFixture]
    class CalculatorDivideMethodTests
    {
        private Calculator calculator;
        private Random rand;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
            rand = new Random();
        }

        [TestCase(4, 2, 2)]
        [TestCase(4, -1, -4)]
        [TestCase(0, 5, 0)]
        [TestCase(1, 4, 0.25)]
        [TestCase(1, 0, 0.25)]

        public void DivideByNoNullDenominatorTest(double numerator, double denominator, double expected)
        {
            var actualValue = calculator.Divide(numerator, denominator);
            Assert.AreEqual(expected, actualValue);
        }
    }
}
