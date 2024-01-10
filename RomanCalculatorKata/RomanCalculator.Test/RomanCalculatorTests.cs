namespace RomanCalculator;

public class RomanCalculatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Add_EmptyAndEmpty_ReturnsEmpty()
    {
        //Arrange
        var sut = new RomanCalculator();

        //Act
        var actual = sut.Add(string.Empty, string.Empty);

        //Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }
}