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

    [TestCaseSource(typeof(TestData), nameof(TestData.Numbers))]
    public string Convert_(int number)
    {
        return new Converter().Convert(number);
    }

    private static class TestData
    {
        public static IEnumerable<TestCaseData> Numbers
        {
            get
            {
                yield return new TestCaseData(1).Returns("I"); 
                yield return new TestCaseData(2).Returns("II");
                yield return new TestCaseData(3).Returns("III");
                yield return new TestCaseData(4).Returns("IV");
                yield return new TestCaseData(5).Returns("V");
                yield return new TestCaseData(6).Returns("VI");
                yield return new TestCaseData(7).Returns("VII");
                yield return new TestCaseData(8).Returns("VIII");
                yield return new TestCaseData(9).Returns("IX");
                yield return new TestCaseData(10).Returns("X");
                yield return new TestCaseData(11).Returns("XI");
                yield return new TestCaseData(12).Returns("XII");
                yield return new TestCaseData(13).Returns("XIII");
                yield return new TestCaseData(14).Returns("XIV");
                yield return new TestCaseData(15).Returns("XV");
                yield return new TestCaseData(16).Returns("XVI");
                yield return new TestCaseData(17).Returns("XVII");
                yield return new TestCaseData(18).Returns("XVIII");

                yield return new TestCaseData(1000).Returns("M");
                yield return new TestCaseData(2000).Returns("MM");
                yield return new TestCaseData(3000).Returns("MMM");
                yield return new TestCaseData(4000).Returns("MMMM");
            }
        }
    }
}