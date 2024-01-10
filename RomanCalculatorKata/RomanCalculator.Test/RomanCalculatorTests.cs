namespace RomanCalculator;

public class RomanCalculatorTests
{
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

    [TestCaseSource(typeof(TestData), nameof(TestData.Data))]
    public string Add_EmptyAndEmptyw_ReturnsEmpty(string op1, string op2)
    {
        //Act
        return new RomanCalculator().Add(op1, op2);
    }

    public static class TestData
    {
        public static IEnumerable<TestCaseData> Data
        {
            get
            {
                yield return new TestCaseData(string.Empty, string.Empty).Returns(string.Empty).SetName("Empty + Empty = Empty");
                yield return new TestCaseData(string.Empty, "I").Returns("I").SetName("Empty + I = I");
                yield return new TestCaseData("I", string.Empty).Returns("I").SetName("I + Empty = I");
            }
        }
    }
}