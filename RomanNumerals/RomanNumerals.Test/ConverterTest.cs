namespace RomanNumerals;

[TestFixture]
public class ConverterTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Convert_1_Returns_I()
    {
        //Arrange
        var sut = new Converter();
        var number = 1;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("I"));
    }

    [Test]
    public void Convert_2_Returns_II()
    {
        //Arrange
        var sut = new Converter();
        var number = 3;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("II"));
    }
}