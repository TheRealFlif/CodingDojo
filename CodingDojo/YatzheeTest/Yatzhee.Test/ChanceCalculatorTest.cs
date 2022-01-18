namespace Yatzhee
{
    using NUnit.Framework;

    public class ChanceCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculate_1_2_2_4_6_Returns15()
        {
            //Arrange
            var sut = new ChanceCalculator();
            var roll = new Roll()
                .AddDie(Die.One())
                .AddDie(Die.Two())
                .AddDie(Die.Two())
                .AddDie(Die.Four())
                .AddDie(Die.Six());

            //Act
            var value = sut.Calculate(roll);
            
            //Assert
            Assert.That(value, Is.EqualTo(15));
        }
    }
}