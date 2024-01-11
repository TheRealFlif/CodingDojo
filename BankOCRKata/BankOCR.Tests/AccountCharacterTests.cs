namespace BankOCR;

public class AccountCharacterTests
{
    [TestCaseSource(typeof(TestData), nameof(TestData.Characters))]
    public string Create_ReturnsCorrectString(int i)
    {
        //Arrange
        var sut = AccountCharacter.Create(i);
        
        //Assert
        return sut.ToString();
    }

    private static class TestData
    {
        public static IEnumerable<TestCaseData> Characters { get
            {
                yield return new TestCaseData(0).Returns(AccountCharacter.Zero().ToString());
                yield return new TestCaseData(1).Returns(AccountCharacter.One().ToString());
                yield return new TestCaseData(2).Returns(AccountCharacter.Two().ToString());
                yield return new TestCaseData(3).Returns(AccountCharacter.Three().ToString());
                yield return new TestCaseData(4).Returns(AccountCharacter.Four().ToString());
                yield return new TestCaseData(5).Returns(AccountCharacter.Five().ToString());
                yield return new TestCaseData(6).Returns(AccountCharacter.Six().ToString());
                yield return new TestCaseData(7).Returns(AccountCharacter.Seven().ToString());
                yield return new TestCaseData(8).Returns(AccountCharacter.Eight().ToString());
                yield return new TestCaseData(9).Returns(AccountCharacter.Nine().ToString());
                yield return new TestCaseData(-1).Returns(AccountCharacter.Blank().ToString());
            } 
        }
    }
}