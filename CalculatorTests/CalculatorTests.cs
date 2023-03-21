using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [Test]
        public void Additional_MustReturnTrueValue()
        {
            Assert.That(calculator.Additional(100, 200) == 300);
        }

        [Test]
        public void Subtraction_MustReturnTrueValue()
        {
            Assert.That(calculator.Subtraction(300, 100) == 200);
        }

        [Test]
        public void Miltiplication_MustReturnTrueValue()
        {
            Assert.That(calculator.Miltiplication(300, 100) == 30000);
        }

        [Test]
        public void Division_MustReturnTrueValue()
        {
            Assert.That(calculator.Division(300, 100) == 3);
        }

        [Test]
        public void Division_MustThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(100, 0));
        }
    }
}
