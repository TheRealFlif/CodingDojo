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
                yield return new TestCaseData("I", "I").Returns("II").SetName("I + I = II");
                yield return new TestCaseData("II", "I").Returns("III").SetName("II + I = III");
                yield return new TestCaseData("III", "I").Returns("IV").SetName("III + I = IV");
                yield return new TestCaseData("IV", "I").Returns("V").SetName("IV + I = V");
                yield return new TestCaseData("V", "I").Returns("VI").SetName("V + I = VI");
                yield return new TestCaseData("VI", "I").Returns("VII").SetName("VI + I = VII");
                yield return new TestCaseData("VII", "I").Returns("VIII").SetName("V + III = VIII");
                yield return new TestCaseData("VIII", "I").Returns("IX").SetName("VIII + I = IX");
                yield return new TestCaseData("II", "II").Returns("IV").SetName("II + II = IV");
                yield return new TestCaseData("III", "III").Returns("VI").SetName("III + III = VI");
                yield return new TestCaseData("IV", "IV").Returns("VIII").SetName("IV + IV = VIII");
                yield return new TestCaseData("V", "IV").Returns("IX").SetName("V + IV = IX");
            }
        }
    }
}