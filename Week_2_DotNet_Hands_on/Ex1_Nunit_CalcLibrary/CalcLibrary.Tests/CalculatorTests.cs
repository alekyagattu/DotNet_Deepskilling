using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Init()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calculator.AllClear();
        }

        [TestCase(5, 3, 8)]
        [TestCase(-2, 2, 0)]
        [TestCase(0, 0, 0)]
        public void Addition_WorksCorrectly(double a, double b, double expected)
        {
            var result = calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(10, 5, 5)]
        [TestCase(-5, -2, -3)]
        [TestCase(0, 0, 0)]
        public void Subtraction_WorksCorrectly(double a, double b, double expected)
        {
            var result = calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(3, 4, 12)]
        [TestCase(-2, 5, -10)]
        [TestCase(0, 10, 0)]
        public void Multiplication_WorksCorrectly(double a, double b, double expected)
        {
            var result = calculator.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(10, 2, 5)]
        [TestCase(-15, 3, -5)]
        [TestCase(0, 1, 0)]
        public void Division_WorksCorrectly(double a, double b, double expected)
        {
            var result = calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Division_ByZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => calculator.Division(10, 0));
        }

        [Test]
        public void GetResult_ReturnsLastResult()
        {
            calculator.Addition(4, 6);
            double result = calculator.GetResult;
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void AllClear_ResetsResultToZero()
        {
            calculator.Addition(1, 1);
            calculator.AllClear();
            double result = calculator.GetResult;
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
