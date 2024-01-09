namespace RomanNumerals;

[TestFixture]
public class RomanNumeralConverterTest
{
    [Test]
    public void Convert_StringEmpty_Returns0()
    {
        //Arrange
        var romanNumeral = string.Empty;
        var sut = new RomanNumeralConverter();

        //Act
        var actual = sut.Convert(romanNumeral);

        //Assert
        Assert.That(actual, Is.EqualTo(0));

    }
}