using System;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture] //tag classen
    public class CalculatorUnitTest
    {
        [Test]
        public void Add_Add2And4_Returns6()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(2, 4), Is.EqualTo(5));
        }

        [Test]
        public void Add_AddMinus2And4_Returns6()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(-2, 4), Is.EqualTo(2));
        }

        [Test]
        public void mul_mul4And10_Returns40()
        {
            var uut = new Calculator();
            Assert.That(uut.Multiply(4, 10), Is.EqualTo(40));
        }

        [Test]
        public void pow_pow2And4_Returns16()
        {
            var uut = new Calculator();
            Assert.That(uut.Power(2, -0.4), Is.EqualTo(0.758));
        }

        [Test]
        public void sub_sub4And2_Returns2()
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(4, 2), Is.EqualTo(2));
           
        }

        [Test]
        public void div_div4by2_Returns2()
        {
            var uut = new Calculator();
            Assert.That(uut.Divide(4, 2), Is.EqualTo(2));
        }

        [Test]
        public void div_div4by0_error()
        {
            var uut = new Calculator();
            Assert.Throws<DivideByZeroException>(new TestDelegate(() => uut.Divide(4,0)));
        }

    }
}