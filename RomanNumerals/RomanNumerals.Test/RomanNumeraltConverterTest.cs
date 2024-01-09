namespace RomanNumerals
{
    [TestFixture]
    public class RomanNumeraltConverterTest
    {
        [Test]
        public void Convert_StringEmpty_Returns0()
        {
            //Arrange
            var romanNumeral = string.Empty;
            var sut = new RomanNumeraltConverter();

            //Act
            var actual = sut.Convert(romanNumeral);

            //Assert
            Assert.That(actual, Is.EqualTo(0));

        }
    }
}