using System;
using System.Collections.Generic;
using System.Text;

namespace Yatzhee
{
    using NUnit.Framework;

    [TestFixture]
    class ThreeKindCalculatorTest
    {
        [Test]
        public void Calculate_1_2_3_4_5_Returns0()
        {
            //Arrange
            var roll = new Roll(1, 2, 3, 4, 5);
            var sut = new ThreeKindCalculator();

            //Act
            var actual = sut.Calculate(roll);

            //Assert 
            Assert.That(actual, Is.EqualTo(0));
        }
        [Test]
        public void Calculate_1_2_6_6_6_Returns18()
        {
            //Arrange
            var roll = new Roll(1, 2, 6, 6, 6);
            var sut = new ThreeKindCalculator();

            //Act
            var actual = sut.Calculate(roll);

            //Assert 
            Assert.That(actual, Is.EqualTo(18));
        }

    }
}