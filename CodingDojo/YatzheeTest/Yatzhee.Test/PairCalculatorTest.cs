namespace Yatzhee.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class PairCalculatorTest
    {
        [Test]
        public void Calculate_1_2_3_4_5_Returns0()
        {
            //Arrange
            var sut = new PairCalculator();
            var roll = new Roll()
                .AddDie(Die.One())
                .AddDie(Die.Two())
                .AddDie(Die.Three())
                .AddDie(Die.Four())
                .AddDie(Die.Five());
            
            //Act
            var actual = sut.Calculate(roll);
            
            //Assert
            Assert.That(actual, Is.EqualTo(0));
        }
    }
}