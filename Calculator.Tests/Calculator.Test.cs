using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Addition_PositiveIntegers_ReturnCorrectResult()
        {
            var calculator = new Calculator();

            var result = calculator.Addition(1, 1);

            Assert.AreEqual(3,result);
        }

        [Test]
        public void Addition_NegativeIntegers_ReturnCorrectResult()
        {
            var calculator = new Calculator();

            var result = calculator.Addition(-1, -1);

            Assert.AreEqual(-2, result);
        }

        [Test]
        public void Multiplication_PositiveIntegers_ReturnCorrectResult()
        {
            var calculator = new Calculator();

            var result = calculator.Multiplication(3, 3);

            Assert.AreEqual(9, result);
        }

        [Test]
        public void Modulo_Integers_ReturnCorrectResult()
        {
            var calculator = new Calculator();

            var result = calculator.Modulo(13, 3);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Division_Integers_ReturnCorrectResult()
        {
            var calculator = new Calculator();

            var result = calculator.Division(9, 3);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void Division_ByZero_ThrowDividedByZeroException()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(9, 0));
        }
    }
}