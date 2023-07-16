using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests._16SEVEN;

namespace Test._16SEVEN.Test{

    [TestFixture]

    public class CalculatorTests{

        [Test]
        public void AdditionalMustReturnCorrectValue(){

            var calculatorAdditionaTest = new Calculator();
            Assert.That(calculatorAdditionaTest.Additional(1, 1), Is.EqualTo(2));
        }

        [Test]
        public void SubstractionMustReturnCorrectValue(){

            var calculatorSubstractionTest = new Calculator();
            Assert.That(calculatorSubstractionTest.Subtraction(2, 2), Is.EqualTo(0));
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue(){

            var calculatorMultiplicationTest = new Calculator();
            Assert.That(calculatorMultiplicationTest.Miltiplication(3, 3), Is.EqualTo(9));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculatorDivisionTest = new Calculator();
            Assert.That(calculatorDivisionTest.Division(4, 4), Is.EqualTo(1));
        }

        [Test]
        public void DivisionMustThrowException()
        {
            var calculatorThrowExceptionTest = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculatorThrowExceptionTest.Division(5, 0));
        }
    }
}
