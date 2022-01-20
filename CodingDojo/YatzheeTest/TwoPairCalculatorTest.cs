using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzhee
{
    using NUnit.Framework;

    [TestFixture]
    class TwoPairCalculatorTest
    {
        [Test]
        public void Calculate_1_2_3_4_5_Returns0()
        {
            //Arrange
            var roll = new Roll(1,2,3,4,5);
            var sut = new TwoPairCalculator();

            //Act
            var actual = sut.Calculate(roll);

            //Assert 
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Calculate_2_2_4_4_6_Returns12()
        {
            //Arrange
            var roll = new Roll(2,2, 4, 4, 6);
            var sut = new TwoPairCalculator();

            //Act
            var actual = sut.Calculate(roll);

            //Assert 
            Assert.That(actual, Is.EqualTo(12));
        }
        [Test]
        public void Calculate_2_2_3_4_6_Returns0()
        {
            //Arrange
            var roll = new Roll(2, 2, 3, 4, 6);
            var sut = new TwoPairCalculator();

            //Act
            var actual = sut.Calculate(roll);

            //Assert 
            Assert.That(actual, Is.EqualTo(0));
        }
    }
}
