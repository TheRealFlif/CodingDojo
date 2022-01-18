namespace Yatzhee
{
    using NUnit.Framework;

    [TestFixture]
    public class DieOneCalculatorTest
    {
        [Test]
        public void Calculate_2_3_4_5_6_Returns0()
        {
            //Arrange
            var sut = new DieOneCalculator();

            //Act
            var actual = sut.Calculate(new Roll()
                .AddDie(Die.Two())
                .AddDie(Die.Three())
                .AddDie(Die.Four())
                .AddDie(Die.Five())
                .AddDie(Die.Six()));

            //Assert
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Calculate_1_1_1_5_6_Returns3()
        {
            //Arrange
            var sut = new DieOneCalculator();

            //Act
            var actual = sut.Calculate(new Roll()
                .AddDie(Die.One())
                .AddDie(Die.One())
                .AddDie(Die.One())
                .AddDie(Die.Four())
                .AddDie(Die.Five())
                .AddDie(Die.Six()));

            //Assert
            Assert.That(actual, Is.EqualTo(3));
        }
    }
}
