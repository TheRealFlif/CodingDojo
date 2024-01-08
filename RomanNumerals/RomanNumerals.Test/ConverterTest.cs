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
        var number = 2;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("II"));
    }

    [Test]
    public void Convert_4_Returns_IV()
    {
        //Arrange
        var sut = new Converter();
        var number = 4;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("IV"));
    }

    [Test]
    public void Convert_5_Returns_V()
    {
        //Arrange
        var sut = new Converter();
        var number = 5;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("V"));
    }

    [Test]
    public void Convert_1001_Returns_MI()
    {
        //Arrange
        var sut = new Converter();
        var number = 1001;

        //Act
        var actual = sut.Convert(number);

        //Assert
        Assert.That(actual, Is.EqualTo("MI"));
    }
}