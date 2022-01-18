namespace Yatzhee
{
    using System.Runtime.InteropServices;
    using NUnit.Framework;

    [TestFixture]
    public class TwoPairCalculatorTest
    {
        [Test]
        public void Calculate_1_2_3_5_6_Returns0()
        {
            //Arrange
            var sut = new TwoPairCalculator();

            //Act
            var actual = sut.Calculate(new Roll()
                .AddDie(Die.One())
                .AddDie(Die.Two())
                .AddDie(Die.Three())
                .AddDie(Die.Five())
                .AddDie(Die.Six()));

            //Assert
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Calculate_1_1_3_5_6_Returns2()
        {
            //Arrange
            var sut = new TwoPairCalculator();

            //Act
            var actual = sut.Calculate(new Roll()
                .AddDie(Die.One())
                .AddDie(Die.One())
                .AddDie(Die.Three())
                .AddDie(Die.Five())
                .AddDie(Die.Six()));

            //Assert
            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        public void Calculate_1_1_3_5_5_Returns10()
        {
            //Arrange
            var sut = new TwoPairCalculator();

            //Act
            var actual = sut.Calculate(new Roll()
                .AddDie(Die.One())
                .AddDie(Die.One())
                .AddDie(Die.Three())
                .AddDie(Die.Five())
                .AddDie(Die.Six()));

            //Assert
            Assert.That(actual, Is.EqualTo(2));
        }
    }
}
